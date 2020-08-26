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
using DevExpress.DashboardCommon.Viewer;

namespace Hospital.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("NombreCompleto")]
    [ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class pacientes : customBaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public pacientes(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
            // fecha = DateTime.Now.Year;
            
        }

        private string _cedula;
        [XafDisplayName("Cédula")]

        [ModelDefault("EditMask", "000-0000000-0"), Index(0), VisibleInListView(false)]
        [Persistent("cedula"), RuleRequiredField(DefaultContexts.Save)]
        public string cedula
        {
            get { return _cedula; }
            set { SetPropertyValue("cedula", ref _cedula, value); }
        }


        private string _nombres;
        [XafDisplayName("Nombres")]
        [VisibleInListView(true)]
        [Size(30)]
        public string nombres
        {
            get { return _nombres; }
            set { SetPropertyValue("nombres", ref _nombres, value); }
        }

        private string _apellidos;
        [XafDisplayName("Apellidos")]

        [Persistent("apellidos"), RuleRequiredField(DefaultContexts.Save)]
        public string apellidos
        {
            get { return _apellidos; }
            set { SetPropertyValue("apellidos", ref _apellidos, value); }
        }

        [PersistentAlias("Concat([nombres], ' ', [apellidos])")]
        [VisibleInListView(false)]
        public string NombreCompleto
        {
            get
            {
                return (string)EvaluateAlias("NombreCompleto");
            }
        }

        private string _telefono;
        [XafDisplayName("Teléfono")]

        [ModelDefault("EditMask", "(000)000-0000"), Index(0), VisibleInListView(false)]
        [Persistent("telefono"), RuleRequiredField(DefaultContexts.Save)]
        public string telefono
        {
            get { return _telefono; }
            set { SetPropertyValue("telefono", ref _telefono, value); }
        }

        private DateTime _fecha;
        [ModelDefault("DisplayFormat", "{0: MM/dd/yyyy}"), ModelDefault("EditMask", "MM/dd/yyyy")]
        [Persistent("fecha")]
        [XafDisplayName("Fecha de Nacimiento")]
        [ImmediatePostData]
        public DateTime fecha
        {
            get {return _fecha;}
            set {SetPropertyValue("fecha", ref _fecha, value);}
        }

        //[VisibleInListView(false)]
        [XafDisplayName("Edad"), ToolTip("Edad")]
        public string Edad2
        {
            get
            {
                try
                {
                    if (fecha.Year != 1)
                    {
                        int _edad2 = (int)((DateTime.Now - fecha).TotalDays / 365.242199);
                        return string.Format("{0}  ", _edad2 + " Años");
                    }
                    else
                    {
                        return "";
                    }
                }
                catch (Exception xx)
                {

                    return "";
                }
            }
        }

        

    }
}