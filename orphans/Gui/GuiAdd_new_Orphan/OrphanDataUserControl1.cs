using ClosedXML.Excel;
using DevExpress.Xpo.Logger;
using orphan.Core.Model;
using orphan.Data;
using orphans.Code;
using orphans.Gui.GuiLoading;
using orphans.Gui.GuiOrphan_Registration;
using orphans.Gui.GuiOrphanOperations;
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

namespace orphans.Gui.GuiAdd_new_Orphan
{
    public partial class OrphanDataUserControl1 : UserControl

    {
        //Variables
        private readonly IDataHelper<NewOrphan> dataHelper;
        private static OrphanDataUserControl1 _OrphanDataUserControl1;
        private readonly LoadingForm loadingForm;
        public OrphanDataUserControl1()
        {
            InitializeComponent();

            dataHelper = (IDataHelper<NewOrphan>)ConfigrationonObjectManager.GetObject(nameof(NewOrphan));
            loadingForm = new LoadingForm();
            LoadData();
        }

        private void HomeUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }


        private void buttonAddnewOrphan_Click(object sender, EventArgs e)
        {
            Orphan_Registration orphan_Registration = new(0,this);
            orphan_Registration.Show();

        }

        private void buttonOrphanDetails_Click(object sender, EventArgs e)
        {
            OrphanDetails orphanDetails = new();
            orphanDetails.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static OrphanDataUserControl1 Instance()
        {

            return _OrphanDataUserControl1 ?? (new OrphanDataUserControl1());
        }
        public async void LoadData()
        {
            loadingForm.Show();

            dataGridView1.DataSource = await dataHelper.GetAllDataAsync();
            if (dataGridView1.DataSource == null)
            {
                MessagCollections.ShowErrorServer();
            }
            else
            {

            }
            SetColumsTitle();
            loadingForm.Hide();

        }
        private void SetColumsTitle()
        {
            dataGridView1.Columns[0].HeaderText = "رقم الطلب";
            dataGridView1.Columns[1].HeaderText = "اسم اليتيم";
            dataGridView1.Columns[2].HeaderText = "تصنيف اليتيم";
            dataGridView1.Columns[3].HeaderText = "الجنس";
            dataGridView1.Columns[4].HeaderText = "الدولة";
            dataGridView1.Columns[5].HeaderText = "المدينة";
            dataGridView1.Columns[6].HeaderText = "الولاية";
            dataGridView1.Columns[7].HeaderText = "المرحلة التعليمية";
            dataGridView1.Columns[8].HeaderText = "تاريخ الولادة";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private async void buttonExport_Click(object sender, EventArgs e)

        {
            DataTable dataTable = new DataTable();
            //loadingForm.Show();
            var data= await dataHelper.GetAllDataAsync();
            using(var reader=FastMember.ObjectReader.Create(data))
            {
               
                dataTable.Load(reader);
            }
            //loadingForm.Hide();
           DataTable dataTableArranged= SetDataTableColumns(dataTable);

            bool SaveResult = ExportAsXlsxFile(dataTableArranged);



          
        }

        private bool ExportAsXlsxFile(DataTable dataTableArranged)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "تصديرالملف على شكل اكسل";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Excel file (.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            var result=saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook xLWorkbook=new XLWorkbook())
                    {
                        xLWorkbook.AddWorksheet(dataTableArranged, "Data");
                        using (MemoryStream ms=new MemoryStream())
                        {
                            xLWorkbook.SaveAs(ms);
                            File.WriteAllBytes(saveFileDialog.FileName, ms.ToArray());
                            return true;
                        }
                    }
                }
                catch 
                {

                    return false;
                }
            }
            else { return false; }
        }

        private DataTable SetDataTableColumns(DataTable dataTable)

        {
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["Id"].ColumnName= "Id";
            dataTable.Columns["NameOrphan"].SetOrdinal(1);
            dataTable.Columns["NameOrphan"].ColumnName= "اسم اليتيم";
            dataTable.Columns["OrphanClassification"].SetOrdinal(2);
            dataTable.Columns["OrphanClassification"].ColumnName = "تصنيف اليتيم";
            dataTable.Columns["Gender"].SetOrdinal(3);
            dataTable.Columns["Gender"].ColumnName = "الجنس";
            dataTable.Columns["Country"].SetOrdinal(4);
            dataTable.Columns["Country"].ColumnName = "الدولة";
            dataTable.Columns["City"].SetOrdinal(5);
            dataTable.Columns["City"].ColumnName = "المدينة";
            dataTable.Columns["Village"].SetOrdinal(6);
            dataTable.Columns["Village"].ColumnName = "الولاية";
            dataTable.Columns["EducationalLevel"].SetOrdinal(7);
            dataTable.Columns["EducationalLevel"].ColumnName = "المرحلة التعليمية";
            dataTable.Columns["DateBirth"].SetOrdinal(8);
            dataTable.Columns["DateBirth"].ColumnName = "تاريخ الولادة";



            return dataTable;
        }
        
    }
}
