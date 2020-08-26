using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace Hospital.Module.BusinessObjects
{
      
    [NonPersistent]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class customBaseObject : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public customBaseObject(Session session)
            : base(session)
        {
        }
        
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            CreadoPor = SecuritySystem.CurrentUserName;
            FechaCreacion = DateTime.Now;
        }

        public static bool IsProcess;
        protected override void OnSaving()
        {
            base.OnSaving();
            if (!IsProcess)
            {
                this.ModificadoPor = SecuritySystem.CurrentUserName;
                FechaModificacion = DateTime.Now;

            }
            else
            {
                this.ModificadoPor = "System";
                FechaModificacion = DateTime.Now;
            }
        }
        // Fields...
        private string _ModificadoPor;
        private string _CreadoPor;

        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        [Persistent("creado_por")]
        public string CreadoPor
        {
            get
            {
                return _CreadoPor;
            }
            private set
            {
                SetPropertyValue("CreadoPor", ref _CreadoPor, value);
            }
        }
        [Browsable(false)]
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        [Persistent("modificado_por")]
        public string ModificadoPor
        {
            get
            {
                return _ModificadoPor;
            }
            set
            {
                SetPropertyValue("ModificadoPor", ref _ModificadoPor, value);
            }
        }


        private DateTime _FechaCreacion;
        [Browsable(false)]
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        [ModelDefault("DisplayFormat", "{0: MM/dd/yyyy hh:mm tt}")]
        [ModelDefault("EditMask", "MM/dd/yyyy hh:mm tt")]
        [Persistent("fecha_creacion")]
        public DateTime FechaCreacion
        {
            get
            {
                return _FechaCreacion;
            }
            set
            {
                SetPropertyValue("FechaCreacion", ref _FechaCreacion, value);
            }
        }

        private DateTime _FechaModificacion;
        [Browsable(false)]
        [VisibleInDetailView(false)]
        [VisibleInListView(false)]
        [VisibleInLookupListView(false)]
        [ModelDefault("DisplayFormat", "{0: MM/dd/yyyy hh:mm tt}")]
        [ModelDefault("EditMask", "MM/dd/yyyy hh:mm tt")]
        [Persistent("fecha_modificacion")]
        public DateTime FechaModificacion
        {
            get
            {
                return _FechaModificacion;
            }
            set
            {
                SetPropertyValue("FechaModificacion", ref _FechaModificacion, value);
            }
        }

        private bool _idGenerado;
        [Persistent("id_generado")]
        [VisibleInListView(false), VisibleInDetailView(false)]
        [NonCloneable]
        public bool idGenerado
        {
            get { return _idGenerado; }
            set { SetPropertyValue("idGenerado", ref _idGenerado, value); }
        }

    }
}