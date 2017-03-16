using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace Vulnerabilities.Vulnerabilities.Deserialization
{
    public partial class FileDeserialization : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filename = Request.Params["file"];

            // Create an instance of the XmlSerializer specifying type and namespace.
            XmlSerializer serializer = new XmlSerializer(typeof(OrderedItem));

            // A FileStream is needed to read the XML document.
            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);

            // Declare an object variable of the type to be deserialized.
            OrderedItem i;

            // Use the Deserialize method to restore the object's state.
            i = (OrderedItem)serializer.Deserialize(reader);
            fs.Close();

            // Write out the properties of the object.
            Response.Write(i.Name + "\t" + i.Id);
        }
    }

    public class OrderedItem
    {
        private int id;
        private string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}