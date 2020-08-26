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
    [DefaultProperty("NombreCompleto")]
    [ImageName("BO_Contact")]
    //
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class medicos : customBaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public medicos(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
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
            set {
                
                if (SetPropertyValue("apellidos", ref _apellidos, value))
                OnChanged("NombreCompleto");   
                         
            }
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
        
        public string telefono
        {
            get { return _telefono; }
            set { SetPropertyValue("telefono", ref _telefono, value); }
        }
    }
}