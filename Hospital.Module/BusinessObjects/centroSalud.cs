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
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class centroSalud : customBaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public centroSalud(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _nombre;
        [Persistent("nombre"), Size(250), XafDisplayName("Nombre Hospital")]
        [RuleRequiredField(DefaultContexts.Save)]
        public string nombre
        {
            get { return _nombre; }
            set { SetPropertyValue("nombre", ref _nombre, value); }
        }

        private string _direccion;
        [Persistent("direccion"), Size(255), XafDisplayName("Dirección")]
        public string direccion
        {
            get { return _direccion; }
            set { SetPropertyValue("direccion", ref _direccion, value); }
        }

        private string _telefono;
        [Persistent("telefono"), Size(25), XafDisplayName("Teléfono")]

        [ModelDefault("EditMask", "000-000-0000"), Index(0), VisibleInListView(false)]
        
        public string telefono
        {
            get { return _telefono; }
            set { SetPropertyValue("telefono", ref _telefono, value); }
        }

    }
}