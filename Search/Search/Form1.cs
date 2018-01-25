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
using System.Xml.Linq;
using System.Xml.Serialization;
//-------------------------------------------------------------------------
namespace Search
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();

            XElement root = XElement.Load("../../XML Data.xml");

            XmlSerializer formatter = new XmlSerializer(typeof(User));

            foreach (var item in root.Elements())
            {
                using (MemoryStream stringInMemoryStream = new MemoryStream(ASCIIEncoding.Default.GetBytes(item.ToString())))
                {
                    try
                    {
                        users.Add(formatter.Deserialize(stringInMemoryStream) as User);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(item);
                        break;
                    }
                }
            }

            foreach (var item in users)
            {
                cBCountry.Items.Add(item.Country);
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string name = tBName.Text;
            string surname = tBSurname.Text;
            string gender = cBGender.Text;
            string country = cBCountry.Text;
            //int FromAge = int.Parse(mTBFromAge.Text);
            //int ToAge = int.Parse(mTBToAge.Text);

            var result = users.FindAll(user => user.Name == name);

            foreach (var item in result)
            {
                rTBFullInfo.Text = item.Name;
            }
        }
    }
}
//-------------------------------------------------------------------------