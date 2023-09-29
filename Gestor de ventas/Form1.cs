using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestor_de_ventas
{
    public partial class Form1 : Form
    {
        string path = @"Data Source=SAMUEL\SQLEXPRESS; Initial Catalog=Ventas; Integrated Security=True;";
        SqlConnection con;
        SqlCommand SetCmd;
        SqlCommand GetCmd;



        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection(path);

            ClientLocationCmb.Items.Add("Local");
            ClientLocationCmb.Items.Add("Foráneo");

            DisplayNewOrderView(false);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProdImg.AllowDrop = true;

        }
        private void SaveOrderButton_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SetCmd = new SqlCommand("INSERT INTO Clientes" +
                    " (Client_Phone, Client_Email, Client_Name, Client_Location) " +
                    "values('" + ClientPhoneTxt.Text + "','" + ClientMailTxt.Text + "'," +
                    "'" + ClientNameTxt.Text + "','" + ClientLocationCmb.SelectedIndex + "')", con);
                SetCmd.ExecuteNonQuery();

                ClientPhoneTxt.Text = "";
                ClientMailTxt.Text = "";
                ClientNameTxt.Text = "";
                ClientLocationCmb.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DisplayNewOrderView(false);
        }
        private void ClientLocationCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            DisplayNewOrderView(true);
        }

        private void ProdImg_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var filenames = data as string[];
                if (filenames.Length > 0)
                    ProdImg.Image = Image.FromFile(filenames[0]);
            }
        }

        private void DisplayNewOrderView(bool visibility)
        {
            ClientPanel.Visible = visibility;
            OrderPanel.Visible = visibility;
            ProvPanel.Visible = visibility;
            SaveOrderButton.Visible = visibility;
            DeleteOrderInfoButton.Visible = visibility;
            Search_Panel.Visible = !visibility;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProdImg_Click(object sender, EventArgs e)
        {

        }

        private void ProdImg_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void label3_Click(object sender, EventArgs e)
        {
 
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click_1(object sender, EventArgs e)
        {

        }

        private void label22_Click_1(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
