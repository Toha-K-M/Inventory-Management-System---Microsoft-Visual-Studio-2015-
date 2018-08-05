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
    public partial class vendor_product : Form
    {
        public vendor_product()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MasterChief\documents\visual studio 2015\Projects\WindowsFormsApplication4\WindowsFormsApplication4\Database1.mdf;Integrated Security=True");
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vendor_productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendor_productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void vendor_product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.vendor_product' table. You can move, or remove it, as needed.
            this.vendor_productTableAdapter.Fill(this.database1DataSet1.vendor_product);
            label4.Text = new_vendor.sendtext;
            label5.Text = new_vendor.sendtext2;
        }

        private void vendor_productBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vendor_product values('" + label4.Text + "','" + label5.Text + "','" + textBox1.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            if (textBox2.Text != string.Empty)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vendor_product values('" + label4.Text + "','" + label5.Text + "','" + textBox2.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            if (textBox3.Text != string.Empty)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vendor_product values('" + label4.Text + "','" + label5.Text + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            if (textBox4.Text != string.Empty)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vendor_product values('" + label4.Text + "','" + label5.Text + "','" + textBox4.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            if (textBox5.Text != string.Empty)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vendor_product values('" + label4.Text + "','" + label5.Text + "','" + textBox5.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            if (textBox6.Text != string.Empty)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vendor_product values('" + label4.Text + "','" + label5.Text + "','" + textBox6.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            if (textBox7.Text != string.Empty)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vendor_product values('" + label4.Text + "','" + label5.Text + "','" + textBox7.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            if (textBox8.Text != string.Empty)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vendor_product values('" + label4.Text + "','" + label5.Text + "','" + textBox8.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            if (textBox9.Text != string.Empty)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vendor_product values('" + label4.Text + "','" + label5.Text + "','" + textBox9.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            if (textBox10.Text != string.Empty)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vendor_product values('" + label4.Text + "','" + label5.Text + "','" + textBox10.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            MessageBox.Show("Succcessfully added Product for this Vendor");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
            textBox9.ResetText();
            textBox10.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
