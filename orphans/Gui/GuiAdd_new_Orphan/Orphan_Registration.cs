using DevExpress.Xpo;
using DevExpress.XtraCharts;
using orphan.Core.Model;
using orphan.Data;
using orphan.Data.SqlServer;
using orphans.Code;
using orphans.Gui.GuiAdd_new_Orphan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace orphans.Gui.GuiOrphan_Registration
{
    public partial class Orphan_Registration : Form
    {
        private readonly int ID;
        private readonly OrphanDataUserControl1 orphanDataUserControl1;
        private NewOrphan newOrphan;
        private readonly IDataHelper<NewOrphan> dataHelper;
        private readonly GuiLoading.LoadingForm loadingForm;
        private bool IsSaveDataSuccess;
        private ApplicationDbContext Context;
        private readonly Country country;
        public Orphan_Registration(int Id, OrphanDataUserControl1 userControl1)
        {
            InitializeComponent();
            dataHelper = (IDataHelper<NewOrphan>)ConfigrationonObjectManager.GetObject("NewOrphan");
            loadingForm = new GuiLoading.LoadingForm();
            ID = Id;
            orphanDataUserControl1 = userControl1;

            Context = new ApplicationDbContext();
        }


        private void add_new_Orphan_UserControl11_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void classificationOrphan_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var sd=   classificationOrphan.SelectedIndex = 0;
            // textBox3.Text = sd.ToString();

        }

        private void buttonSaveOrphan_Click(object sender, EventArgs e)
        {
            //if(!SaveData())
            // {
            // //    orphanDataUserControl1.LoadData();


            // }
            // IsSaveDataSuccess = false;
            AddData();
        }



        //Methods
        private bool SaveData()
        {
            if (IsFiledEmpty())
            {
                MessagCollections.ShowFiledRequired();

            }
            else
            {
                loadingForm.Show();
                if (ID == 0)//add
                {
                    AddData();
                }
                else//edit
                {

                }
                loadingForm.Hide();
            }
            return IsSaveDataSuccess;
        }
        private bool IsFiledEmpty()
        {
            if (comboBoxCity.Text == string.Empty || comboBoxCity.Text == string.Empty)
            {
                return true;


            }
            else
            {
                return false;
            }
        }
        private async Task AddData()
        {
            NewOrphan newOrphan = new NewOrphan
            {
                NameOrphan = textBoxNameofOrphan.Text,
                OrphanClassification = comboboxclassificationOrphan.SelectedItem.ToString(),
                Gender = comboBoxGander.SelectedItem.ToString(),
                EducationalLevel = comboBoxEducationalLevel.SelectedItem.ToString(),
                Classroom = comboBoxClassroom.SelectedItem.ToString(),
                PhoneNumber = int.Parse(textBoxPhoneNumber.Text),
                InsideOrphanage = comboBoxInsideOrphanage.SelectedItem.ToString(),
                HousingType = comboBoxHousingType.SelectedItem.ToString(),
                NumberRoom = (int?)numericUpDownNumberRoom.Value,
                AmountRent = double.Parse(textBoxAmountRent.Text),
                PlaceOfBirth = textBoxPlaceOfBirth.Text,
                numberBrothers = (int?)numericUpDownnumberBrothers.Value,
                numberSisters = (int?)numericUpDownnumberSisters.Value,
                OrphanStatus = comboBoxOrphanStatus.SelectedItem.ToString(),
                healthStatus = comboBoxhealthStatus.SelectedItem.ToString(),
                CausesDisease = comboBoxCausesDisease.SelectedItem.ToString(),
                QualityHousing = comboBoxQualityHousing.SelectedItem.ToString(),
                Address = textBoxAddress.Text,
                DateBirth = dateTimePickerDataBirth.Value,
                OrphanHobby = textBoxOrphanHobby.Text,
                AmountOfQuran = comboBoxAmountOfQuran.SelectedItem.ToString(),
                ClosestPlaceOtLive = textBoxClosestPlaceOtLive.Text,
                Description = richTextBoxDescription.Text,
                //IamgeName=
                //MotherName=textBoxMotherName.Text,
                //MotherCondition=comboBoxMotherCondition.SelectedItem.ToString(),
                //MotherNationalNumber=int.Parse(textBoxMotherNationalNumber.Text),
                //DMotherWork=comboBoxDMotherWork.SelectedItem.ToString(),
                //FatherName=textBoxFatherName.Text,
                //FatherNationalNumber=int.Parse(textBoxFatherNationalNumber.Text),
                //FatherWorkBeforeDeath=textBoxFatherWorkBeforeDeath.Text,
                //DateFatherDeath=dateTimePickerDateFatherDeath.Value,
                //GuardianName=textBoxGuardianName.Text,
                //GuardianWork=textBoxGuardianWork.Text,
                //GuardianNationalNumber=int.Parse(textBoxGuardianNationalNumber.Text),
                //RelationshipWithOrphanhood=textBoxRelationshipWithOrphanhood.Text,
                CountryId = comboBoxcountry.SelectedIndex,

            };
            //dataHelper.Add(newOrphan);

            var result = await dataHelper.AddAsync(newOrphan);
            if (result == 0)
            {
                // MessagCollections.ShowErrorServer();
                throw new NotImplementedException();
            }
            else
            {
                //Toast
                MessageBox.Show("ok add");
                IsSaveDataSuccess = true;
            }
            //eidt
        }

        private void comboBoxcountry_BindingContextChanged(object sender, EventArgs e)
        {
            //ApplicationDbContext context = new ApplicationDbContext();
            var table = Context.country.Select(m => new { countryname = m.Name }).ToList();
            foreach (var country in table)
            {
                comboBoxcountry.Items.Add(country.countryname);
            }

        }

        private void comboBoxcountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCity_BindingContextChanged(object sender, EventArgs e)
        {
            var table = Context.city.Select(n => new { Cityname = n.Name }).ToList();
            foreach (var city in table)
            {
                comboBoxCity.Items.Add(city.Cityname);
            }
        }

        private void comboBoxDirectorate_BindingContextChanged(object sender, EventArgs e)
        {
            var table = Context.directorate.Select(n => new { directorateName = n.Name }).ToList();
            foreach (var directorates in table)
            {
                comboBoxDirectorate.Items.Add(directorates.directorateName);
            }
        }

        private void comboBoxVillage_BindingContextChanged(object sender, EventArgs e)
        {
            var table = Context.village.Select(n => new { villageName = n.Name }).ToList();
            foreach (var villages in table)
            {
                comboBoxVillage.Items.Add(villages.villageName);
            }
        }

        private void comboBoxNationality_BindingContextChanged(object sender, EventArgs e)
        {
            var table = Context.nationality.Select(n => new { nationalitieName = n.Name }).ToList();
            foreach (var nationalities in table)
            {
                comboBoxNationality.Items.Add(nationalities.nationalitieName);
            }
        }
    }
}
