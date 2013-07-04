using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndroidClient
{

    //generated with xsd-tool
    //- xsd generieren : xsd.exe strings.xml
    //- Klasse erstellen : xsd strings.xsd /classes
    //manuell changes : 
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "resources")]
    //rename : AndroidResources, AndroidResourcesString

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "resources")]
    public partial class AndroidResources
    {

        private AndroidResourcesString[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("string", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public AndroidResourcesString[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AndroidResourcesString
    {

        private string nameField;
        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

}
