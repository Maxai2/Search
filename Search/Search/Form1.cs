using GMap.NET.MapProviders;
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
        List<User> tempUser = new List<User>();

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

            gMapFull.DragButton = MouseButtons.Left;

            gMapFull.MinZoom = 5;
            gMapFull.MaxZoom = 100;

            gMapFull.Zoom = 10;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            tempUser.Clear();

            DateTime year = new DateTime();

            string name = "";

            if (tBName.Text != "")
                name = tBName.Text;

            string surname = "";

            if (tBSurname.Text != "")
                surname = tBSurname.Text;

            string gender = "";

            if (cBGender.Text != "")
                gender = cBGender.Text;

            string country = "";

            if (cBCountry.Text != "")
                country = cBCountry.Text;

            int FromAge = 0;
            int fromYear = 0;

            if (mTBFromAge.Text != "")
            {
                FromAge = int.Parse(mTBFromAge.Text);
                fromYear = year.Year - FromAge;
            }

            int ToAge = 0;
            int toYear = 0;

            if (mTBToAge.Text != "")
            {
                ToAge = int.Parse(mTBToAge.Text);
                toYear = year.Year - ToAge;
            }

            var result = users.FindAll(user => user?.Name == name && user?.LastName == surname && user?.Gender == gender && user?.Country == country && int.Parse(user?.BirthDate.Substring(6)) == fromYear);

            foreach (var item in result)
            {
                lBUsers.Items.Add($"{item.LastName} {item.Name}");
                tempUser.Add(item);
            }
        }

        private void lBUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            gMapFull.DragButton = MouseButtons.Left;
            gMapFull.MapProvider = GMapProviders.BingMap;

            string curItem = lBUsers.SelectedItem.ToString();

            int index = lBUsers.FindString(curItem);

            double lat = Convert.ToDouble(tempUser[index].Lat);
            double lont = Convert.ToDouble(tempUser[index].Lon);

            gMapFull.Position = new GMap.NET.PointLatLng(lat, lont);

            tBNameFull.Text = tempUser[index].Name;
            tBSurnameFull.Text = tempUser[index].LastName;
            tBGenderFull.Text = tempUser[index].Gender;
            tBLanguageFull.Text = tempUser[index].Language;
            tBRaceFull.Text = tempUser[index].Race;
            tBEmailFull.Text = tempUser[index].Email;
            tBCityFull.Text = tempUser[index].City;
            tBJobFull.Text = tempUser[index].Job;
            tBCountryFull.Text = tempUser[index].Country;
            tBCompanyFull.Text = tempUser[index].Company;
            tBDepartmentFull.Text = tempUser[index].Department;
            tBBirthDateFull.Text = tempUser[index].BirthDate;
        }
    }
}
//-------------------------------------------------------------------------