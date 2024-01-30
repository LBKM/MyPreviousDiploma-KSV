using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestClass;

namespace DiplomaProjectActEmp_KSV
{
    public partial class FormMainMenu : Form
    {
        private bool isPanelExpanded = false;
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
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
            string connectionString = "Server=PR59\\SQLEXPRESS;Database=user2;User Id=user2;Password=212345;";
            FillActEmpList();

        }
        void FillActEmpList()
        {
            ListViewActEmp.Items.Clear();
            foreach (DataRow Row in actEmpDataSet.ACTIVITY_EMPLOYEE.Rows)
            {
                string[] items = new string[10];
                DataRow TempRow;
                TempRow = Row.GetParentRow("FK_ACTIVITY_EMPLOYEE_DISCIPLINE");
                items[1] = TempRow[1].ToString();
                TempRow = Row.GetParentRow("FK_ACTIVITY_EMPLOYEE_WORKER");
                items[2] = TempRow["Name"].ToString();
                items[3] = TempRow["Surname"].ToString();
                items[4] = TempRow["Lastname"].ToString();
                TempRow = Row.GetParentRow("FK_ACTIVITY_EMPLOYEE_EDUCATION_FORM");
                items[5] = TempRow["Education_Form"].ToString();
                TempRow = Row.GetParentRow("FK_ACTIVITY_EMPLOYEE_SPECIALITY");
                items[6] = TempRow["Name"].ToString();
                items[7] = Row[4].ToString();
                TempRow = Row.GetParentRow("FK_ACTIVITY_EMPLOYEE_EVENT");
                items[8] = TempRow["Name"].ToString();
                ListViewItem it = new ListViewItem();
                it.Text = Row["ActEmp_ID"].ToString();
                it.SubItems.AddRange(items);
                ListViewActEmp.Items.Add(it);
            }
            Countlabel.Text = $"{ListViewActEmp.Items.Count} из {actEmpDataSet.ACTIVITY_EMPLOYEE.Rows.Count}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormChartsView formChartsView = new FormChartsView();
            formChartsView.Show();
        }

        private void выходВОкноАвторизацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuthorization form = new FormAuthorization();
            form.Show();
        }

        private void ToggleFilter()
        {
            if (isPanelExpanded)
            {
                panel1.Width = 0;
                isPanelExpanded = false;
                groupBox1.Height = 250;
                button4.Text = "Открыть фильтр";
            }
            else
            {
                
                isPanelExpanded = true;
                groupBox1.Height = 325;
                button4.Text = "Закрыть фильтр";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToggleFilter();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormForClass formForClass = new FormForClass();
            formForClass.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormAddChangeActEmp formAddChangeActEmp = new FormAddChangeActEmp();
            formAddChangeActEmp.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PageViewForm pageViewForm = new PageViewForm();
            pageViewForm.ShowDialog();
        }
    }
}