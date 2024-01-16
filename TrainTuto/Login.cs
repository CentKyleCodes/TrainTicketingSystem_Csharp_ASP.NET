using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainTuto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }else if(UNameTb.Text == "Admin" &&  PasswordTb.Text == "Admin")
            {
                Train Obj = new Train();
                Obj.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Wrong Credentials!!!");
                UNameTb.Text = "";
                PasswordTb.Text = "";
            }


        }
    }
}
