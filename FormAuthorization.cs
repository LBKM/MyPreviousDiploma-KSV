using ClassLibrary_HAU_KSV;
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

namespace DiplomaProjectActEmp_KSV
{
    public partial class FormAuthorization : DevExpress.XtraEditors.XtraForm
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }
        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.USER". При необходимости она может быть перемещена или удалена.
            this.uSERTableAdapter.Fill(this.actEmpDataSet.USER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.USER". При необходимости она может быть перемещена или удалена.
            this.uSERTableAdapter.Fill(this.actEmpDataSet.USER);
            checkBox1.Checked = false;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=PR59\\SQLEXPRESS;Database=user2;User Id=user2;Password=212345;";
            string login = guna2TextBoxLogin.Text;
            string password = guna2TextBoxPassword.Text;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM [User] WHERE Login = @Login AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);
                    int count = (int)command.ExecuteScalar();
                    {
                        //checkBox1.Checked = false;
                        if (count > 0)
                        {
                            //MessageBox.Show("ЧОООООООООООООО это вернае имя пользователя или пароль.");
                            FormMainMenu dialog = new FormMainMenu();
                            dialog.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            // Неверные учетные данные.
                            MessageBox.Show("Неверное имя пользователя или пароль.");
                            MessageBox.Show("admin, adminpass");
                        }
                    }
                }           
        }

        private void uSERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.actEmpDataSet);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUserRegistration dialog = new FormUserRegistration();
            dialog.ShowDialog();
        }

        private void guna2GradientButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            FormMainMenu dialog = new FormMainMenu();
            dialog.Name = "РЕЖИМ ГОСТЯ. Учёт методической активности педагогов. Главное меню. КСВ4П";
            dialog.ShowDialog();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Encrypting_HAU_KSV encryptor = new Encrypting_HAU_KSV();
            string Str_Before = guna2TextBoxPassword.Text;
            string Str_Key = "37482";
            textBox2.Text = encryptor.code_KSV_HAU(Str_Before, Str_Key);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUserRegistration formUserRegistration = new FormUserRegistration();
            formUserRegistration.ShowDialog();
        }
    }
}
