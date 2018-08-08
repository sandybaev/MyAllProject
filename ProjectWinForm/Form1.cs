using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ProjectWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Справка пустой текст
            /***
             * 
             * тут 
             * 1 проверка xml файла на существование
               2 если существует то чтение расписания
               3 если расписание нулевое то ничего не делать
               4 если файл не пуст то заполнение таб части программы данными из файла
               5 если файл не пуст то запуск данных согласно расписанию
               
            *
            * 
            ***/
            #endregion


        }


        #region Перетаскивание формы когда в свойстах формы нет заголовка
        private int x = 0; private int y = 0;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));
            }
        }

        #endregion






    }
}
