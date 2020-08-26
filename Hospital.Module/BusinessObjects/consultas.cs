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
    public class consultas : XPCustomObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public consultas(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();

            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
            fecha = DateTime.Now;

        }
        private Int32 _id;
        [XafDisplayName("Id")]
        [Persistent("id")]
        [Key(true)]
        public Int32 Id
        {
            get { return _id; }
            set
            {
                SetPropertyValue("id", ref _id, value);
            }

        }

        private pacientes _pacientes;
        //[Association]

        public pacientes pacientes
        {
            get { return _pacientes; }

            set { SetPropertyValue<pacientes>(nameof(pacientes), ref _pacientes, value); }
        }


        private medicos _medicos;
        //[Association]

        public medicos medicos
        {
            get { return _medicos; }

            set { SetPropertyValue<medicos>(nameof(medicos), ref _medicos, value); }
        }



        private string _descripcion;
        [Persistent("descripcion"), Size(255), XafDisplayName("Descripcion")]
        public string descripcion
        {
            get { return _descripcion; }
            set { SetPropertyValue("descripcion", ref _descripcion, value); }
        }

        private string _motivo;
        [Persistent("motivo"), Size(255), XafDisplayName("motivo de consulta")]
        public string motivo
        {
            get { return _motivo; }
            set { SetPropertyValue("motivo", ref _motivo, value); }
        }

        private DateTime _fecha;
        [ModelDefault("DisplayFormat", "{0: MM/dd/yyyy}"), ModelDefault("EditMask", "MM/dd/yyyy")]
        [Persistent("fecha")]
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

    }
}