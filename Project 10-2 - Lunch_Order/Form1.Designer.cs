namespace Project_10_2___Lunch_Order
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grp_lunch = new System.Windows.Forms.GroupBox();
            this.rdb_salad = new System.Windows.Forms.RadioButton();
            this.rdb_pizza = new System.Windows.Forms.RadioButton();
            this.rdb_hamburger = new System.Windows.Forms.RadioButton();
            this.grp_extras = new System.Windows.Forms.GroupBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_placeOrder = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rtxt_summary = new System.Windows.Forms.RichTextBox();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grp_lunch.SuspendLayout();
            this.grp_extras.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_lunch
            // 
            this.grp_lunch.Controls.Add(this.rdb_salad);
            this.grp_lunch.Controls.Add(this.rdb_pizza);
            this.grp_lunch.Controls.Add(this.rdb_hamburger);
            this.grp_lunch.Location = new System.Drawing.Point(13, 23);
            this.grp_lunch.Name = "grp_lunch";
            this.grp_lunch.Size = new System.Drawing.Size(225, 174);
            this.grp_lunch.TabIndex = 0;
            this.grp_lunch.TabStop = false;
            this.grp_lunch.Text = "Main Course";
            // 
            // rdb_salad
            // 
            this.rdb_salad.AutoSize = true;
            this.rdb_salad.Location = new System.Drawing.Point(7, 119);
            this.rdb_salad.Name = "rdb_salad";
            this.rdb_salad.Size = new System.Drawing.Size(128, 24);
            this.rdb_salad.TabIndex = 3;
            this.rdb_salad.TabStop = true;
            this.rdb_salad.Tag = "";
            this.rdb_salad.Text = "Salad - $4.95";
            this.rdb_salad.UseVisualStyleBackColor = true;
            this.rdb_salad.CheckedChanged += new System.EventHandler(this.rdb_salad_CheckedChanged);
            // 
            // rdb_pizza
            // 
            this.rdb_pizza.AutoSize = true;
            this.rdb_pizza.Location = new System.Drawing.Point(7, 73);
            this.rdb_pizza.Name = "rdb_pizza";
            this.rdb_pizza.Size = new System.Drawing.Size(184, 24);
            this.rdb_pizza.TabIndex = 2;
            this.rdb_pizza.TabStop = true;
            this.rdb_pizza.Tag = "";
            this.rdb_pizza.Text = "Cheese Pizza - $5.95";
            this.rdb_pizza.UseVisualStyleBackColor = true;
            this.rdb_pizza.CheckedChanged += new System.EventHandler(this.rdb_pizza_CheckedChanged);
            // 
            // rdb_hamburger
            // 
            this.rdb_hamburger.AutoSize = true;
            this.rdb_hamburger.Location = new System.Drawing.Point(7, 26);
            this.rdb_hamburger.Name = "rdb_hamburger";
            this.rdb_hamburger.Size = new System.Drawing.Size(167, 24);
            this.rdb_hamburger.TabIndex = 1;
            this.rdb_hamburger.TabStop = true;
            this.rdb_hamburger.Tag = "";
            this.rdb_hamburger.Text = "Hamburger - $6.95";
            this.rdb_hamburger.UseVisualStyleBackColor = true;
            this.rdb_hamburger.CheckedChanged += new System.EventHandler(this.rdb_hamburger_CheckedChanged);
            // 
            // grp_extras
            // 
            this.grp_extras.Controls.Add(this.chk3);
            this.grp_extras.Controls.Add(this.chk2);
            this.grp_extras.Controls.Add(this.chk1);
            this.grp_extras.Location = new System.Drawing.Point(283, 23);
            this.grp_extras.Name = "grp_extras";
            this.grp_extras.Size = new System.Drawing.Size(277, 174);
            this.grp_extras.TabIndex = 1;
            this.grp_extras.TabStop = false;
            this.grp_extras.Text = "Add-on Items";
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(7, 119);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(22, 21);
            this.chk3.TabIndex = 2;
            this.chk3.Tag = "";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(7, 72);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(22, 21);
            this.chk2.TabIndex = 1;
            this.chk2.Tag = "";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(7, 26);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(22, 21);
            this.chk1.TabIndex = 0;
            this.chk1.Tag = "";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.txt_tax);
            this.groupBox3.Controls.Add(this.txt_subtotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(283, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 166);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Total";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(161, 111);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(100, 26);
            this.txt_total.TabIndex = 5;
            this.txt_total.TabStop = false;
            // 
            // txt_tax
            // 
            this.txt_tax.Location = new System.Drawing.Point(161, 72);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.ReadOnly = true;
            this.txt_tax.Size = new System.Drawing.Size(100, 26);
            this.txt_tax.TabIndex = 4;
            this.txt_tax.TabStop = false;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(161, 34);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(100, 26);
            this.txt_subtotal.TabIndex = 3;
            this.txt_subtotal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax (7.75%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.Location = new System.Drawing.Point(20, 283);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.Size = new System.Drawing.Size(148, 44);
            this.btn_placeOrder.TabIndex = 3;
            this.btn_placeOrder.Tag = "";
            this.btn_placeOrder.Text = "&Order Checkout";
            this.btn_placeOrder.UseVisualStyleBackColor = true;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(174, 346);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(103, 40);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Tag = "";
            this.btn_exit.Text = "&Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(20, 346);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(148, 39);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Tag = "";
            this.btn_clear.Text = "&Clear Entire Order";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rtxt_summary
            // 
            this.rtxt_summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_summary.Location = new System.Drawing.Point(593, 49);
            this.rtxt_summary.Name = "rtxt_summary";
            this.rtxt_summary.ReadOnly = true;
            this.rtxt_summary.Size = new System.Drawing.Size(374, 340);
            this.rtxt_summary.TabIndex = 6;
            this.rtxt_summary.TabStop = false;
            this.rtxt_summary.Text = "";
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.Location = new System.Drawing.Point(20, 220);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(148, 43);
            this.btn_addOrder.TabIndex = 2;
            this.btn_addOrder.Tag = "";
            this.btn_addOrder.Text = "&Add Order";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Order Summary";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_placeOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(979, 404);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.rtxt_summary);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_placeOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grp_extras);
            this.Controls.Add(this.grp_lunch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.grp_lunch.ResumeLayout(false);
            this.grp_lunch.PerformLayout();
            this.grp_extras.ResumeLayout(false);
            this.grp_extras.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_lunch;
        private System.Windows.Forms.RadioButton rdb_salad;
        private System.Windows.Forms.RadioButton rdb_pizza;
        private System.Windows.Forms.RadioButton rdb_hamburger;
        private System.Windows.Forms.GroupBox grp_extras;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_placeOrder;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RichTextBox rtxt_summary;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Label label4;
    }
}

