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
    public partial class new_vendor : Form
    {
        string del_item;
        public new_vendor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MasterChief\documents\visual studio 2015\Projects\WindowsFormsApplication4\WindowsFormsApplication4\Database1.mdf;Integrated Security=True");
        ////
        // private readonly Form2 _Form2;
        //public new_vendor(Form2 form2)
        //{
        //  _Form2 = form2;
        //}
        ///
        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void new_vendor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.vendor_product' table. You can move, or remove it, as needed.
            //this.vendor_productTableAdapter.Fill(this.database1DataSet1.vendor_product);
            // TODO: This line of code loads data into the 'database1DataSet1.new_vendor' table. You can move, or remove it, as needed.
            this.new_vendorTableAdapter1.Fill(this.database1DataSet1.new_vendor);
            // TODO: This line of code loads data into the 'database1DataSet.new_vendor' table. You can move, or remove it, as needed.
            // this.new_vendorTableAdapter.Fill(this.database1DataSet.new_vendor);
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "Select Company Name";
            display_data();
            

        }

        private void Add_Click(object sender, EventArgs e)
        {
            newvendorBindingSource7.AddNew();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (textBox2.Text != string.Empty)
                {
                    this.Validate();
                    this.newvendorBindingSource7.EndEdit();
                    new_vendorTableAdapter1.Update(this.database1DataSet1);
                    // this.tableAdapterManager.UpdateAll(this.database1DataSet1);
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into new_vendor values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+ textBox4.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                   // dataGridView1.Update();
                  //  dataGridView1.Refresh();
                }
                else {
                    MessageBox.Show("Please fill out the Name", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else {
                MessageBox.Show("Please fill out the Company Name", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.newvendorBindingSource7.MoveNext();
        }

        ///Changing Tab Page
        public void ChangeTab()
        {
            TabControl.SelectedTab = tabPage2;
        }
        public void ChangeTab2()
        {
            TabControl.SelectedTab = tabPage3;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.newvendorBindingSource7.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.newvendorBindingSource7.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != string.Empty)
            {
                if (textBox6.Text != string.Empty)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this ?", "Deleting a Vendor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from new_vendor where [Comapny Name] =@Name";
                        cmd.Parameters.AddWithValue("@Name", textBox5.Text);
                        cmd.Parameters.AddWithValue("@No", label7.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        this.newvendorBindingSource7.RemoveCurrent();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out the Name", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill out the Company Name", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ///
           // var result = MessageBox.Show("Are you sure you want to delete this ?", "Deleting a Vendor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static string sendtext = "";
        public static string sendtext2 = "";
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                if (textBox2.Text != string.Empty)
                {
                    sendtext = textBox1.Text;
                    sendtext2 = textBox2.Text;
                    new vendor_product().Show();
                }
                else
                {
                    MessageBox.Show("Please fill out the Name", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill out the Company Name", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != string.Empty)
            {
                if (textBox6.Text != string.Empty)
                {
                    var result = MessageBox.Show("Are you sure you want to Update this ?", "Updating a Vendor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update new_vendor set Name =@Name , Phone =@Phone , Address =@Address where No=@No";
                        cmd.Parameters.AddWithValue("@No", label7.Text);
                        cmd.Parameters.AddWithValue("@Name", textBox6.Text);
                        cmd.Parameters.AddWithValue("@Phone", textBox7.Text);
                        cmd.Parameters.AddWithValue("@Address", textBox8.Text);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        this.Validate();
                        this.newvendorBindingSource7.EndEdit();
                        new_vendorTableAdapter1.Update(this.database1DataSet1);
                        MessageBox.Show("Updated Successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill out the Name", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please fill out the Company Name", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void searchNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.new_vendorTableAdapter1.SearchName(this.database1DataSet1.new_vendor, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.newvendorBindingSource7.MoveFirst();
            nameToolStripTextBox.Clear();
            searchNameToolStripButton.PerformClick();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.new_vendorTableAdapter1.FillBy(this.database1DataSet1.new_vendor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void checkautocomplete() {
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
                textBox9.Text = (rd["Name"].ToString());
            }
            //need to handle exception here
            textBox9.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox9.AutoCompleteMode = AutoCompleteMode.Append;
            textBox9.AutoCompleteCustomSource = autocomp;
           // cmd.ExecuteNonQuery();
            //cmd.Dispose();
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkautocomplete();
            display_data();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              del_item = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
              textBox20.Text = del_item;
            //MessageBox.Show(item.ToString());
            // this.Validate();
            //this.newvendorBindingSource7.EndEdit();
            // new_vendorTableAdapter1.Update(this.database1DataSet1);
            // MessageBox.Show("Updated Successfully");
        }
        private void dataGridView2_Edit(object sender, DataGridViewCellEventArgs e) {
            var item = dataGridView2.Rows[e.RowIndex].Cells[2].Value;
            textBox10.Text = item.ToString();
            MessageBox.Show(item.ToString());
        }

        public void display_data() {
            string y = comboBox1.Text;
              con.Open();
              SqlCommand cmd = con.CreateCommand();
              cmd.CommandType = CommandType.Text;
              cmd.CommandText = "select Product,id from vendor_product where [Company Name]=@CompanyName";
              cmd.Parameters.AddWithValue("@CompanyName", y);
              cmd.ExecuteNonQuery();
              DataTable it = new DataTable();
              SqlDataAdapter ia = new SqlDataAdapter(cmd);
              ia.Fill(it);
              dataGridView2.DataSource = it;
              //cmd.Dispose();
              con.Close();
            dataGridView2.Columns[0].Width = 200;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                //getting row number
                var id = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                //MessageBox.Show(i);
                dataGridView2.Update();
                dataGridView2.Refresh();
                //getting updated product
                var pro = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                //MessageBox.Show(id);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update vendor_product set Product =@Product where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Product", pro);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ) {
                
            }
        }
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
               /* var id = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            
                string y = comboBox1.Text;
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update vendor_product set Product (select row_number() over )";
                cmd.Parameters.AddWithValue("@CompanyName", y);
                cmd.Parameters.AddWithValue("@Product",id);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("hi");
                //DataTable it = new DataTable();
                //SqlDataAdapter ia = new SqlDataAdapter(cmd);
                //ia.Fill(it);
                // dataGridView2.DataSource = it;
                //cmd.Dispose();
                con.Close();
                display_data();*/
               
            
        }

        //adding new product
        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                if (textBox10.Text != string.Empty)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into vendor_product values('" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox10.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                if (textBox11.Text != string.Empty)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into vendor_product values('" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox11.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                if (textBox12.Text != string.Empty)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into vendor_product values('" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox12.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                if (textBox13.Text != string.Empty)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into vendor_product values('" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox13.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                if (textBox14.Text != string.Empty)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into vendor_product values('" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox14.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                if (textBox19.Text != string.Empty)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into vendor_product values('" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox19.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                if (textBox18.Text != string.Empty)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into vendor_product values('" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox18.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                if (textBox17.Text != string.Empty)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into vendor_product values('" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                if (textBox16.Text != string.Empty)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into vendor_product values('" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox16.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                if (textBox15.Text != string.Empty)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into vendor_product values('" + comboBox1.Text + "','" + textBox9.Text + "','" + textBox15.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                display_data();
            }
            else {
                MessageBox.Show("Please fill out the Company Name", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox10.ResetText();
            textBox11.ResetText();
            textBox12.ResetText();
            textBox13.ResetText();
            textBox14.ResetText();
            textBox15.ResetText();
            textBox16.ResetText();
            textBox17.ResetText();
            textBox18.ResetText();
            textBox19.ResetText();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string y = comboBox1.Text;
            var result = MessageBox.Show("Are you sure you want to delete this ?", "Deleting a Vendor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from vendor_product where [Company Name] =@CompanyName AND Product =@Product";
                cmd.Parameters.AddWithValue("@CompanyName", y);
                cmd.Parameters.AddWithValue("@Product", del_item);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                display_data();
                textBox20.ResetText();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
