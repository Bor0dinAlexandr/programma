using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game2x2
{
    
    public partial class Form1 : Form
    {
        int Score = 0;
        int Record = 0;
        
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(l1.Text);
            int y = Convert.ToInt32(l2.Text);
            int ress = x * y;
            string result = Convert.ToString(ress);

            if (textBox1.Text == result)
            {
                label3.Text = "Нажми проверка";
                Score+=x+y;
                label7.Text = Convert.ToString("Счёт: " + Score);
                label2.Text = "Проверка";
                textBox1.Text = null;
                Random random = new Random();
                x = random.Next(1, 10);
                y = random.Next(1, 10);
                l1.Text = Convert.ToString(x);
                l2.Text = Convert.ToString(y);
            }
            else 
            {
                label3.Text = "Вы проиграли!";
                label2.Text = "Играть";
                l1.Text = "2";
                l2.Text = "2";
                Score = 0;
                textBox1.Text = null;
                
            }
            if (Record <= Score)
            {
                Record = Score;
                label5.Text = Convert.ToString("Рекорд: " + Record);
                label7.Text = Convert.ToString("Счёт: " + Score);
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DarkSlateGray;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.ForeColor= Color.Black;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }
        Point lastpoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = e.Location;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = e.Location;
        }
    }
}
