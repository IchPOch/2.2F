using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._2F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ras_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(den.Text);
            switch (n)
            {
                case 1: rab.Text = ("Понедельник\n c 8 до 10"); break;
                case 2: rab.Text = ("Вторник\n Не работает"); break;
                case 3: rab.Text = ("Среда\n Не работает"); break;
                case 4: rab.Text = ("Четверг\n Не работает"); break;
                case 5: rab.Text = ("Пятница\n Не работает"); break;
                case 6: rab.Text = ("Суббота\n Не работает"); break;
                case 7: rab.Text = ("Воскресенье\n Не работает"); break;
                default: rab.Text = ("Вы ошиблись"); break;
            }

        }
    }
}
