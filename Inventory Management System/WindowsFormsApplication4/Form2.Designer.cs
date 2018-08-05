namespace WindowsFormsApplication4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.new_vendor = new System.Windows.Forms.Button();
            this.vendor_list = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.new_orderbutton2 = new System.Windows.Forms.Button();
            this.order_Listbutton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vendor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Purchase Order";
            // 
            // new_vendor
            // 
            this.new_vendor.Location = new System.Drawing.Point(71, 66);
            this.new_vendor.Name = "new_vendor";
            this.new_vendor.Size = new System.Drawing.Size(160, 40);
            this.new_vendor.TabIndex = 2;
            this.new_vendor.Text = "New Vendor";
            this.new_vendor.UseVisualStyleBackColor = true;
            this.new_vendor.Click += new System.EventHandler(this.new_vendor_Click);
            // 
            // vendor_list
            // 
            this.vendor_list.Location = new System.Drawing.Point(71, 112);
            this.vendor_list.Name = "vendor_list";
            this.vendor_list.Size = new System.Drawing.Size(160, 40);
            this.vendor_list.TabIndex = 3;
            this.vendor_list.Text = "Vendor List";
            this.vendor_list.UseVisualStyleBackColor = true;
            this.vendor_list.Click += new System.EventHandler(this.vendor_list_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Vendor Products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // new_orderbutton2
            // 
            this.new_orderbutton2.Location = new System.Drawing.Point(339, 66);
            this.new_orderbutton2.Name = "new_orderbutton2";
            this.new_orderbutton2.Size = new System.Drawing.Size(160, 40);
            this.new_orderbutton2.TabIndex = 5;
            this.new_orderbutton2.Text = "New Order";
            this.new_orderbutton2.UseVisualStyleBackColor = true;
            this.new_orderbutton2.Click += new System.EventHandler(this.new_orderbutton2_Click);
            // 
            // order_Listbutton3
            // 
            this.order_Listbutton3.Location = new System.Drawing.Point(339, 112);
            this.order_Listbutton3.Name = "order_Listbutton3";
            this.order_Listbutton3.Size = new System.Drawing.Size(160, 40);
            this.order_Listbutton3.TabIndex = 6;
            this.order_Listbutton3.Text = "Order List";
            this.order_Listbutton3.UseVisualStyleBackColor = true;
            this.order_Listbutton3.Click += new System.EventHandler(this.order_Listbutton3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 729);
            this.Controls.Add(this.order_Listbutton3);
            this.Controls.Add(this.new_orderbutton2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vendor_list);
            this.Controls.Add(this.new_vendor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button new_vendor;
        private System.Windows.Forms.Button vendor_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button new_orderbutton2;
        private System.Windows.Forms.Button order_Listbutton3;
    }
}