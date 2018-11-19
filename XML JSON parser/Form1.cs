using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XML_JSON_parser
{
    public partial class Form1 : Form
    {
        LocalDBContext db;
    
        public Form1()
        {
            InitializeComponent();
            db = new LocalDBContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
                Persona persona;

            if (xmlRadioButton.Checked)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona), new XmlRootAttribute("Persona"));

                persona = (Persona) xmlSerializer.Deserialize(new StringReader(texto));

                db.personas.Add(persona);
                db.SaveChangesAsync();


            } else if (jsonRadioButton.Checked){



                persona = JsonConvert.DeserializeObject<Persona>(texto);

                db.personas.Add(persona);
                db.SaveChangesAsync();

            }

        }
    }
}
