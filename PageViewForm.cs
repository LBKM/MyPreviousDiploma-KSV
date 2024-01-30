using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaProjectActEmp_KSV
{
    public partial class PageViewForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        int pageSize = 3;
        int pageNumber = 0;
        public PageViewForm()
        {

            InitializeComponent();

        }

        private void PageViewForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.WORKER". При необходимости она может быть перемещена или удалена.
            this.wORKERTableAdapter.Fill(this.actEmpDataSet.WORKER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.USER". При необходимости она может быть перемещена или удалена.
            this.uSERTableAdapter.Fill(this.actEmpDataSet.USER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.SPECIALITY". При необходимости она может быть перемещена или удалена.
            this.sPECIALITYTableAdapter.Fill(this.actEmpDataSet.SPECIALITY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.POST". При необходимости она может быть перемещена или удалена.
            this.pOSTTableAdapter.Fill(this.actEmpDataSet.POST);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.EVENT_MATERIALS". При необходимости она может быть перемещена или удалена.
            this.eVENT_MATERIALSTableAdapter.Fill(this.actEmpDataSet.EVENT_MATERIALS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.EVENT". При необходимости она может быть перемещена или удалена.
            this.eVENTTableAdapter.Fill(this.actEmpDataSet.EVENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.EDUCATION_FORM". При необходимости она может быть перемещена или удалена.
            this.eDUCATION_FORMTableAdapter.Fill(this.actEmpDataSet.EDUCATION_FORM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.DISCIPLINE". При необходимости она может быть перемещена или удалена.
            this.dISCIPLINETableAdapter.Fill(this.actEmpDataSet.DISCIPLINE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.ACTIVITY_EMPLOYEE". При необходимости она может быть перемещена или удалена.
            this.aCTIVITY_EMPLOYEETableAdapter.Fill(this.actEmpDataSet.ACTIVITY_EMPLOYEE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.ACCESS_LEVEL". При необходимости она может быть перемещена или удалена.
            this.aCCESS_LEVELTableAdapter.Fill(this.actEmpDataSet.ACCESS_LEVEL);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.WORKER". При необходимости она может быть перемещена или удалена.
            this.wORKERTableAdapter.Fill(this.actEmpDataSet.WORKER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.USER". При необходимости она может быть перемещена или удалена.
            this.uSERTableAdapter.Fill(this.actEmpDataSet.USER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.SPECIALITY". При необходимости она может быть перемещена или удалена.
            this.sPECIALITYTableAdapter.Fill(this.actEmpDataSet.SPECIALITY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.POST". При необходимости она может быть перемещена или удалена.
            this.pOSTTableAdapter.Fill(this.actEmpDataSet.POST);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.EVENT_MATERIALS". При необходимости она может быть перемещена или удалена.
            this.eVENT_MATERIALSTableAdapter.Fill(this.actEmpDataSet.EVENT_MATERIALS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.EVENT". При необходимости она может быть перемещена или удалена.
            this.eVENTTableAdapter.Fill(this.actEmpDataSet.EVENT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.EDUCATION_FORM". При необходимости она может быть перемещена или удалена.
            this.eDUCATION_FORMTableAdapter.Fill(this.actEmpDataSet.EDUCATION_FORM);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.DISCIPLINE". При необходимости она может быть перемещена или удалена.
            this.dISCIPLINETableAdapter.Fill(this.actEmpDataSet.DISCIPLINE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.ACTIVITY_EMPLOYEE". При необходимости она может быть перемещена или удалена.
            this.aCTIVITY_EMPLOYEETableAdapter.Fill(this.actEmpDataSet.ACTIVITY_EMPLOYEE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.ACCESS_LEVEL". При необходимости она может быть перемещена или удалена.
            this.aCCESS_LEVELTableAdapter.Fill(this.actEmpDataSet.ACCESS_LEVEL);
            string connectionString = "Server=PR59\\SQLEXPRESS;Database=user2;User Id=user2;Password=212345;";
        }
       // void FillServiceList()
       // {
       //     this.serviceTableAdapter.FillByPageView(this.dataSet1.Service, pageNumber, pageSize);
       //     ServiceListView.Items.Clear(); //Открыли цикл foreach в котором Row - представляет все строк таблицы Service
       //     foreach (DataRow Row in dataSet1.Service.Rows)
       //     {
       //         string[] items = new string[6];
       //         items[1] = Row["Title"].ToString();
       //         items[2] = Row["Cost"].ToString();
       //         items[3] = $"{Convert.ToDouble(Row["DurationInSeconds"]) / 60} мин.";
       //         items[4] = $"{Convert.ToDouble(Row["Discount"]) * 100}%";
       //         items[5] = String.Format("{0:0.00}", Convert.ToDouble(Row["Cost"]) - (Convert.ToDouble(Row["Cost"]) / 100)
       //* (Convert.ToDouble(Row["Discount"]) * 100));
       //         ListViewItem it = new ListViewItem();
       //         it.Text = Row["ID"].ToString();
       //         it.SubItems.AddRange(items);
       //         ServiceListView.Items.Add(it);
       //         ServiceListView.Items[ServiceListView.Items.Count - 1].BackColor = items[4] != "0%" ? Color.LightGreen : Color.White;
       //     }
       //     var cn = new OleDbConnection();
       //     cn.ConnectionString = Properties.Settings.Default.ConnectionString;
       //     cn.Open();
       //     var sql = new OleDbCommand("SELECT Count (*) FROM Service", cn);
       //     object count = sql.ExecuteScalar();
       //     label4.Text = $"{ServiceListView.Items.Count} из { count }";
       //     cn.Close();
       //     if (ServiceListView.Items.Count > 0)
       //         ServiceListView.Items[0].Selected = true;
       //     else
       //         pictureBox.Image =
       //         Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\not_found.png");
       // }
        private void aCCESS_LEVELBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aCCESS_LEVELBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.actEmpDataSet);

        }
    }
}
