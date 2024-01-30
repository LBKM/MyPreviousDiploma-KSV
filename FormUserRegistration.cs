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
    public partial class FormUserRegistration : Form
    {
        private string text = string.Empty;
        public FormUserRegistration()
        {
            InitializeComponent();
        }
        private Bitmap CreateImage(int width, int height)
        {
            // создание рандома 
            Random rnd = new Random();
            //Создание изображение
            Bitmap result = new Bitmap(Width, Height);
            //Вычислим позицию текста
            int iHeight = 80;
            int iWidth = 300;
            int Xpos = rnd.Next(iWidth);
            int Ypos = rnd.Next(iHeight);
            //Добавим различные цвета для вывода текста 
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };
            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);
            //Пусть фон картинки будет серым
            g.Clear(Color.White);
            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            for (int i = 0; i < 6; ++i)
                text += ALF[rnd.Next(ALF.Length)];
            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 65),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));
            // немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));

            //Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);
            return result;
        }


        private void FormUserRegistration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "actEmpDataSet.ACCESS_LEVEL". При необходимости она может быть перемещена или удалена.
            this.aCCESS_LEVELTableAdapter.Fill(this.actEmpDataSet.ACCESS_LEVEL);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBoxCode.Image = this.CreateImage(pictureBoxCode.Width, pictureBoxCode.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text == this.text)
            {
                button1.Enabled = true;
                textBoxCode.Clear();
            }
            else
            {
                MessageBox.Show("Ошибка!");
                pictureBoxCode.Image = this.CreateImage(pictureBoxCode.Width, pictureBoxCode.Height); textBoxCode.Clear();
            }
        }
    }
}
