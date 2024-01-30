using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestClass;

namespace DiplomaProjectActEmp_KSV
{
    public partial class FormForClass : Form
    {
        public FormForClass()
        {
            InitializeComponent();
        }

        private void FormForClass_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.POST". При необходимости она может быть перемещена или удалена.
            this.pOSTTableAdapter.Fill(this.actEmpDataSet.POST);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.WORKER". При необходимости она может быть перемещена или удалена.
            this.wORKERTableAdapter.Fill(this.actEmpDataSet.WORKER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.ACTIVITY_EMPLOYEE". При необходимости она может быть перемещена или удалена.
            this.aCTIVITY_EMPLOYEETableAdapter.Fill(this.actEmpDataSet.ACTIVITY_EMPLOYEE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredCode = textBox1.Text;

            MethodicalCodeValidator validator = new MethodicalCodeValidator();
            if (validator.IsValidMethodicalCode(enteredCode))
            {
                MessageBox.Show("Код методической активности правильный.", "Успех");
            }
            else
            {
                MessageBox.Show("Неправильный код методической активности. Пример правильного кода: 01.24.21", "Ошибка");
            }
        }
    }
}
