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
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();
            Con = new Functions();
            ShowTrains();


        }
        Functions Con;
        private void ShowTrains()
        {
            string Query = "select * from TrainTbl";
            TrainsDGV.DataSource = Con.GetData(Query);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Clear()
        {
            TNameTb.Text = "";
            TNumberTb.Text = "";
            TCapacityTb.Text = "";
            TConditionTb.Text = "";
            TColorTb.Text = "";

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || TNumberTb.Text == "" || TCapacityTb.Text == "" || TConditionTb.Text == "" || TColorTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");

            }
            else
            {
                try
                {
                    string TName = TNameTb.Text;
                    string TNumber = TNumberTb.Text;
                    int Capacity = Convert.ToInt32(TCapacityTb.Text);
                    string Condition = TConditionTb.Text;
                    string Color = TColorTb.Text;
                    string Query = "insert into TrainTbl values('{0}','{1}','{2}','{3}','{4}','{5}')";
                    Query = string.Format(Query, TName, TNumber, Capacity, InDateTb.Value.Date.ToString(), Condition, Color);
                    Con.setData(Query);
                    MessageBox.Show("Train Added!!!");
                    ShowTrains();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
        int Key = 0;
        private void TrainsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TNameTb.Text = TrainsDGV.SelectedRows[0].Cells[1].Value.ToString();
            TNumberTb.Text = TrainsDGV.SelectedRows[0].Cells[2].Value.ToString();
            TCapacityTb.Text = TrainsDGV.SelectedRows[0].Cells[3].Value.ToString();
            //TNameTb.Text = TrainsDGV.SelectedRows[0].Cells[4].Value.ToString();
            TConditionTb.Text = TrainsDGV.SelectedRows[0].Cells[5].Value.ToString();
            TColorTb.Text = TrainsDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (TNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TrainsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {
            if (TNameTb.Text == "" || TNumberTb.Text == "" || TCapacityTb.Text == "" || TConditionTb.Text == "" || TColorTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string TName = TNameTb.Text;
                    string TNumber = TNumberTb.Text;
                    int Capacity = Convert.ToInt32(TCapacityTb.Text);
                    string Condition = TConditionTb.Text;
                    string Color = TColorTb.Text;
                    string Query = "update TrainTbl set TName = '{0}', TNumber = '{1}', Capacity = {2},InDate = '{3}', Condition = '{4}',Color = '{5}' where TCode = {6}";
                    Query = string.Format(Query, TName, TNumber, Capacity, InDateTb.Value.Date.ToString(), Condition, Color, Key);
                    Con.setData(Query);
                    MessageBox.Show("Train Updated!!!");
                    ShowTrains();
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
                MessageBox.Show("Select a Train");

            }
            else
            {
                try
                {
                    string Query = "delete from TrainTbl where TCode = {0} ";
                    Query = string.Format(Query, Key);
                    Con.setData(Query);
                    MessageBox.Show("Train Delete!!!");
                    ShowTrains();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Conducters Obj = new Conducters();
            Obj.Show();
            this.Hide();

        }

        private void TNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Conducters Obj = new Conducters();
            Obj.Show(); 
            this.Hide();   
        }
    }
}

        
    
