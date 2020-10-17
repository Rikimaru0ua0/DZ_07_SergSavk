using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_07_SergSavk
{
    public partial class Form1 : Form
    {
        public int value;
        public bool flagPlay = false;
        //public int move = 0;
        public string last_Move = "0";




        public void Win()
        {
            if (int.Parse(lblNumber.Text) == value)
            {
                lblNumber2.Text = "Вы выйграли за " + lblNumber1.Text + " ходов," + " набрав число " + value;
                lblNumber1.Text = "0";
                flagPlay = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
            btnCommand0.Text = "Play";
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            btnLast.Text = "-1 ход";
            lblNumber.Text = "0";
            lblNumber1.Text = "0";
            lblNumber2.Text = "0";            
            this.Text = "Удвоитель";
            
        }
        public void btnCommand0_Click(object sender, EventArgs e)
        {
            //value = 5;
            Random r = new Random();
            value = r.Next(10, 110);           
            lblNumber2.Text = "Наберите заданное число " + value.ToString();
            flagPlay = true;
            lblNumber.Text = "0";
            lblNumber1.Text = "0";
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            //move = 1;
            last_Move = lblNumber.Text;
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblNumber1.Text = (int.Parse(lblNumber1.Text) + 1).ToString();
            Win();
            
        }


        private void btnCommand2_Click(object sender, EventArgs e)
        {
            //move = 2;
            last_Move = lblNumber.Text;
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblNumber1.Text = (int.Parse(lblNumber1.Text) + 1).ToString();
            Win();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (flagPlay == false)
            {
                lblNumber.Text = "0";
                lblNumber1.Text = "0";
            }
            else
            {
                lblNumber.Text = "0";
                lblNumber1.Text = (int.Parse(lblNumber1.Text) + 1).ToString();
            }            
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            
            lblNumber.Text = last_Move;
        }
    }
}
