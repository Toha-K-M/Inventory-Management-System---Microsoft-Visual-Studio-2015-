using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //

        private void new_vendor_Click(object sender, EventArgs e)
        {
            new new_vendor().Show();
            this.Hide();
        }

        private void vendor_list_Click(object sender, EventArgs e)
        {

            new_vendor f2 = new new_vendor();
            f2.ChangeTab();
            f2.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new_vendor f3 = new new_vendor();
            f3.ChangeTab2();
            f3.Show();
            this.Hide();
        }

        private void new_orderbutton2_Click(object sender, EventArgs e)
        {
            new Purchase_Order().Show();
            this.Hide();
        }

        private void order_Listbutton3_Click(object sender, EventArgs e)
        {
            new Purchase_Order().Show();
            this.Hide();
        }
    }
}
