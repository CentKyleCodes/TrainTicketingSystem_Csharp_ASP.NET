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
   public partial class Conducters : Form
    {
        public Conducters()
        {
            InitializeComponent();
            Con = new Functions();
            ShowConducters();
        }

        Functions Con;
        private void ShowConducters()
        {
            string Query = "select * from ConducterTbl";
            ConducterDGV.DataSource = Con.GetData(Query);
        }
        private void Clear()
        {
            CNameTb.Text = "";
            GenderTb.Text = "";
            MobileTb.Text = "";
            AddressTb.Text = "";
            MobileTb.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Train Obj = new Train();
            Obj.Show();
            this.Hide();
        }

        private void CNameTb_Text(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (CNameTb.Text == "" || AddressTb.Text == "" || ExpTb.Text == "" || MobileTb.Text == "" || GenderTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");

            }
            else
            {
                try
                {
                    string CName = CNameTb.Text;
                    string GName = GenderTb.Text;
                    int Experience = Convert.ToInt32(ExpTb.Text);
                    string Phone = MobileTb.Text;
                    string Address = AddressTb.Text;
                    string Query = "insert into ConducterTbl values('{0}','{1}','{2}','{3}','{4}',{5})";
                    Query = string.Format(Query, CName, GName, CDOBTb.Value.Date.ToString(), Phone, Address, Experience);
                    Con.setData(Query);
                    MessageBox.Show("Conducter Added!!!");
                    ShowConducters();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int Key = 0;
        private void ConducterDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CNameTb.Text = ConducterDGV.SelectedRows[0].Cells[1].Value.ToString();
            GenderTb.Text = ConducterDGV.SelectedRows[0].Cells[2].Value.ToString();
           // TCapacityTb.Text = ConducterDGV.SelectedRows[0].Cells[3].Value.ToString();
            MobileTb.Text = ConducterDGV.SelectedRows[0].Cells[4].Value.ToString();
            AddressTb.Text = ConducterDGV.SelectedRows[0].Cells[5].Value.ToString();
            ExpTb.Text = ConducterDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (CNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ConducterDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CNameTb.Text == "" || AddressTb.Text == "" || ExpTb.Text == "" || MobileTb.Text == "" || GenderTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");

            }
            else
            {
                try
                {
                    string CName = CNameTb.Text;
                    string GName = GenderTb.Text;
                    int Experience = Convert.ToInt32(ExpTb.Text);
                    string Phone = MobileTb.Text;
                    string Address = AddressTb.Text;
                    string Query = "update ConducterTbl set  CName = '{0}',CGender = '{1}',CDOB = '{2}', CPhone = '{3}',CAddress='{4}',CExp = {5} where CCode = {6}";
                    Query = string.Format(Query, CName, GName, CDOBTb.Value.Date.ToString(), Phone, Address, Experience,Key);
                    Con.setData(Query);
                    MessageBox.Show("Conducter Updated!!!");
                    ShowConducters();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string Query = "delete from ConducterTbl where CCode = {0} ";
                    Query = string.Format(Query, Key);
                    Con.setData(Query);
                    MessageBox.Show("Conducter Deleted!!!");
                    ShowConducters();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
