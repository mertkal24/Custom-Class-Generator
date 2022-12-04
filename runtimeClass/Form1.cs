using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace runtimeClass
{
    public partial class Form1 : Form
    {
        List<object> all_object = new List<object>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student ogrenci = new Student()
            {
                Name = "mert",
                Not = 100,
                Ortalama = 100
            };
            Service bus = new Service()
            {
                Id = 1,
                Plaka = "61FA353",
            };
            School okul = new School()
            {
                Adress = "Trabzon",
                TelNo = "05369852157",
            };
            List<PropertyInfo[]> all_props = new List<PropertyInfo[]>();
            PropertyInfo[] stdnprp = ogrenci.GetType().GetProperties();
            PropertyInfo[] busPrp = bus.GetType().GetProperties();
            PropertyInfo[] schlPrp = okul.GetType().GetProperties();
            all_props.Add(stdnprp);
            all_props.Add(busPrp);
            all_props.Add(schlPrp);
            all_object.Add(ogrenci);
            all_object.Add(bus);
            all_object.Add(okul);
            foreach (PropertyInfo[] classProps in all_props)
            {
                foreach (PropertyInfo props in classProps)
                {
                    allProps.Items.Add(props);                   
                }
            }


        }

        private void pushPropButton_Click(object sender, EventArgs e)
        {
            
            foreach(Object obj in allProps.CheckedItems)
            {
                customClassProps.Items.Add((PropertyInfo)obj);
            }
            
        }

        private void createClass_Click(object sender, EventArgs e)
        {
            StringBuilder prps = new StringBuilder();
            foreach(PropertyInfo props in customClassProps.Items)
            {
                foreach(Object obj in all_object)
                {
                    if (obj.GetType().GetProperties().Contains(props))
                    {
                        string type = props.PropertyType.Name;
                        string name = props.Name;
                        string deger = obj.GetType().GetProperty(props.Name).GetValue(obj).ToString();
                        prps.Append(type + " " + name + "=" + deger+";");
                        MessageBox.Show(prps.ToString());
                        MessageBox.Show(deger);
                    }
                }
               
            }
        }

        private void getInstance_Click(object sender, EventArgs e)
        {

        }
    }
}
