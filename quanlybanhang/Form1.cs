using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlybanhang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelbody.Controls.Add(childForm);
            panelbody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void panelbody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new thongke());
            if (button1.BackColor == Color.Black)
            {
                ///
                button1.BackColor = Color.DarkGreen;

                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Black;
                button8.BackColor = Color.Black;
                button9.BackColor = Color.Black;

            }
            else
            {
                button1.BackColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new sanpham());
            if (button2.BackColor == Color.Black)
            {
                ///
                button2.BackColor = Color.DarkGreen;

                button1.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Black;
                button8.BackColor = Color.Black;
                button9.BackColor = Color.Black;

            }
            else
            {
                button2.BackColor = Color.Black;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new hoadon());
            if (button4.BackColor == Color.Black)
            {
                ///
                button4.BackColor = Color.DarkGreen;

                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button1.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Black;
                button8.BackColor = Color.Black;
                button9.BackColor = Color.Black;

            }
            else
            {
                button4.BackColor = Color.Black;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new nhanvien());
            if (button3.BackColor == Color.Black)
            {
                ///
                button3.BackColor = Color.DarkGreen;

                button2.BackColor = Color.Black;
                button1.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Black;
                button8.BackColor = Color.Black;
                button9.BackColor = Color.Black;

            }
            else
            {
                button3.BackColor = Color.Black;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new khachhang());
            if (button5.BackColor == Color.Black)
            {
                ///
                button5.BackColor = Color.DarkGreen;

                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button1.BackColor = Color.Black;
                button6.BackColor = Color.Black;
                button8.BackColor = Color.Black;
                button9.BackColor = Color.Black;

            }
            else
            {
                button5.BackColor = Color.Black;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new lichsu());
            if (button6.BackColor == Color.Black)
            {
                ///
                button6.BackColor = Color.DarkGreen;

                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                button1.BackColor = Color.Black;
                button8.BackColor = Color.Black;
                button9.BackColor = Color.Black;

            }
            else
            {
                button6.BackColor = Color.Black;
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new doimatkhau());
            if (button8.BackColor == Color.Black)
            {
                ///
                button8.BackColor = Color.DarkGreen;

                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Black;
                button1.BackColor = Color.Black;
                button9.BackColor = Color.Black;

            }
            else
            {
                button8.BackColor = Color.Black;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            dangnhap dangnhap2 = new dangnhap();
            dangnhap2.ShowDialog();
            if (button9.BackColor == Color.Black)
            {
                ///
                button9.BackColor = Color.DarkGreen;

                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                button6.BackColor = Color.Black;
                button8.BackColor = Color.Black;
                button1.BackColor = Color.Black;

            }
            else
            {
                button9.BackColor = Color.Black;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
    }
}
