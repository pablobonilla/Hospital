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
    public class internamientos : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public internamientos(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            fecha = DateTime.Now;
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string habitacion;
        private pacientes _pacientes;
        public pacientes pacientes
        {
            get { return _pacientes; }

            set { SetPropertyValue<pacientes>(nameof(pacientes), ref _pacientes, value); }
        }

        private string _motivo;
        [Persistent("motivo"), Size(255), XafDisplayName("Motivo Internamiento")]
        public string motivo
        {
            get { return _motivo; }
            set { SetPropertyValue("motivo", ref _motivo, value); }
        }


        private string _seguimiento;
        [Persistent("seguimiento"), Size(255), XafDisplayName("Seguimiento ")]
        public string seguimiento
        {
            get { return _seguimiento; }
            set { SetPropertyValue("seguimiento", ref _seguimiento, value); }
        }

        
        [Size(SizeAttribute.DefaultStringMappingFieldSize), XafDisplayName("No. Habitación")]
        public string _habitacion
        {
            get => habitacion;
            set => SetPropertyValue(nameof(_habitacion), ref habitacion, value);
        }

        private DateTime _fecha;
        [ModelDefault("DisplayFormat", "{0: MM/dd/yyyy}"), ModelDefault("EditMask", "MM/dd/yyyy")]
        [Persistent("fecha"), XafDisplayName("Fecha de Ingreso")]
        public DateTime fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                SetPropertyValue("fecha", ref _fecha, value);
            }
        }

        private DateTime _fecha2;
        [ModelDefault("DisplayFormat", "{0: MM/dd/yyyy}"), ModelDefault("EditMask", "MM/dd/yyyy")]
        [Persistent("fecha2"), XafDisplayName("Fecha de Salida")]
        public DateTime fecha2
        {
            get
            {
                return _fecha2;
            }
            set
            {
                SetPropertyValue("fecha2", ref _fecha2, value);
            }
        }


    }
}