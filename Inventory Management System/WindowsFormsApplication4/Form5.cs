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

namespace WindowsFormsApplication4
{
    public partial class Purchase_Order : Form
    {
        public Purchase_Order()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MasterChief\documents\visual studio 2015\Projects\WindowsFormsApplication4\WindowsFormsApplication4\Database1.mdf;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void Home_button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }
        public void checkautocomplete()
        {
            string x = comboBox1.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from new_vendor Where [Comapny Name]=@CompanyName";
            cmd.Parameters.AddWithValue("@CompanyName", x);
            SqlDataReader rd = cmd.ExecuteReader();
            AutoCompleteStringCollection autocomp = new AutoCompleteStringCollection();
            while (rd.Read())
            {
                autocomp.Add(rd.GetString(2));
                textBox1.Text = (rd["Name"].ToString());
                textBox2.Text = (rd["Phone"].ToString());
                textBox4.Text = (rd["Address"].ToString());
            }
            //need to handle exception here
           // textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
          //  textBox1.AutoCompleteMode = AutoCompleteMode.Append;
            //textBox1.AutoCompleteCustomSource = autocomp;
            // cmd.ExecuteNonQuery();
            //cmd.Dispose();
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkautocomplete();
        }

        private void Purchase_Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.ven_stock_location' table. You can move, or remove it, as needed.
            this.ven_stock_locationTableAdapter.Fill(this.database1DataSet1.ven_stock_location);
            // TODO: This line of code loads data into the 'database1DataSet1.vendor_product' table. You can move, or remove it, as needed.
            this.vendor_productTableAdapter.Fill(this.database1DataSet1.vendor_product);
            // TODO: This line of code loads data into the 'database1DataSet1.new_vendor' table. You can move, or remove it, as needed.
            this.new_vendorTableAdapter.Fill(this.database1DataSet1.new_vendor);
         //   tableLayoutPanel1.RowCount = 0;

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //this.tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
       
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox7.
        }

        private void comboBox40_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorproductBindingSource.EndEdit();
            ven_stock_locationTableAdapter.Update(this.database1DataSet1);
            //string x = location_textBox100.Text;
            //  stock_default_comboBox2.Items.Add(x);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ven_stock_location values ('" + location_textBox100.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            stock_default_comboBox2.DataSource = null;
            stock_default_comboBox2.DataSource =this.venstocklocationBindingSource;
            stock_default_comboBox2.Refresh();
        }
    }
}
