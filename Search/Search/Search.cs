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
    public partial class FSearch : Form
    {
        List<User> users = new List<User>();
        List<User> tempUser = new List<User>();

        public FSearch() 
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

            gMapFull.MinZoom = 1;
            gMapFull.MaxZoom = 100;

            gMapFull.Zoom = 15;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            tempUser.Clear();
            lBUsers.Items.Clear();

            int FromAge = 0;
            int FromYear = 2018;

            if (mTBFromAge.Text != "")
            {
                FromAge = int.Parse(mTBFromAge.Text);
                FromYear = DateTime.Now.Year - FromAge;
            }

            int ToAge = 0;
            int toYear = 1;

            if (mTBToAge.Text != "")
            {
                ToAge = int.Parse(mTBToAge.Text);
                toYear = DateTime.Now.Year - ToAge;
            }

            tempUser = users;

            if (tBName.Text != "")
                tempUser = tempUser.FindAll(user => user.Name == tBName.Text);
            if (tBSurname.Text != "")
                tempUser = tempUser.FindAll(user => user.LastName == tBSurname.Text);
            if (cBGender.Text != "" && cBGender.Text != "Any")
                tempUser = tempUser.FindAll(user => user.Gender == cBGender.Text);
            if (cBCountry.Text != "")
                tempUser = tempUser.FindAll(user => user.Country == cBCountry.Text);

            tempUser = tempUser.FindAll(user => Convert.ToDateTime(user.BirthDate).Year <= FromYear &&
                                                Convert.ToDateTime(user.BirthDate).Year >= toYear);

            if (tempUser.Count == 0)
            {
                MessageBox.Show("No user with matching search parameters");
                return;
            }

            for (int i = 0; i < tempUser.Count; i++)
                lBUsers.Items.Add($"{i + 1} - {tempUser[i].LastName} {tempUser[i].Name}");
        }

        double lat;
        double lont;

        private void lBUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBUsers.SelectedItem == null)
                return;

            gMapFull.MapProvider = GMapProviders.GoogleMap;
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

        private void gMapFull_OnMapZoomChanged()
        {
            //gMapFull.Position = new GMap.NET.PointLatLng(lat, lont);
        }
    }
}
//-------------------------------------------------------------------------