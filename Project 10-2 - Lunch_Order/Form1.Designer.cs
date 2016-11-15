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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_salad = new System.Windows.Forms.RadioButton();
            this.rdb_pizza = new System.Windows.Forms.RadioButton();
            this.rdb_hamburger = new System.Windows.Forms.RadioButton();
            this.grp_hamburger = new System.Windows.Forms.GroupBox();
            this.chk_fries = new System.Windows.Forms.CheckBox();
            this.chk_ketchup = new System.Windows.Forms.CheckBox();
            this.chk_lettuce = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_placeOrder = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.grp_pizza = new System.Windows.Forms.GroupBox();
            this.chk_olives = new System.Windows.Forms.CheckBox();
            this.chk_sausage = new System.Windows.Forms.CheckBox();
            this.chk_pepperoni = new System.Windows.Forms.CheckBox();
            this.grp_salad = new System.Windows.Forms.GroupBox();
            this.chk_breadsticks = new System.Windows.Forms.CheckBox();
            this.chk_bacon = new System.Windows.Forms.CheckBox();
            this.chk_croutons = new System.Windows.Forms.CheckBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grp_hamburger.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grp_pizza.SuspendLayout();
            this.grp_salad.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_salad);
            this.groupBox1.Controls.Add(this.rdb_pizza);
            this.groupBox1.Controls.Add(this.rdb_hamburger);
            this.groupBox1.Location = new System.Drawing.Point(13, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Course";
            // 
            // rdb_salad
            // 
            this.rdb_salad.AutoSize = true;
            this.rdb_salad.Location = new System.Drawing.Point(7, 119);
            this.rdb_salad.Name = "rdb_salad";
            this.rdb_salad.Size = new System.Drawing.Size(128, 24);
            this.rdb_salad.TabIndex = 2;
            this.rdb_salad.Text = "Salad - $4.95";
            this.rdb_salad.UseVisualStyleBackColor = true;
            this.rdb_salad.CheckedChanged += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // rdb_pizza
            // 
            this.rdb_pizza.AutoSize = true;
            this.rdb_pizza.Location = new System.Drawing.Point(7, 73);
            this.rdb_pizza.Name = "rdb_pizza";
            this.rdb_pizza.Size = new System.Drawing.Size(125, 24);
            this.rdb_pizza.TabIndex = 1;
            this.rdb_pizza.Text = "Pizza - $5.95";
            this.rdb_pizza.UseVisualStyleBackColor = true;
            this.rdb_pizza.CheckedChanged += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // rdb_hamburger
            // 
            this.rdb_hamburger.AutoSize = true;
            this.rdb_hamburger.Location = new System.Drawing.Point(7, 26);
            this.rdb_hamburger.Name = "rdb_hamburger";
            this.rdb_hamburger.Size = new System.Drawing.Size(167, 24);
            this.rdb_hamburger.TabIndex = 0;
            this.rdb_hamburger.Text = "Hamburger - $6.95";
            this.rdb_hamburger.UseVisualStyleBackColor = true;
            this.rdb_hamburger.CheckedChanged += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // grp_hamburger
            // 
            this.grp_hamburger.Controls.Add(this.chk_fries);
            this.grp_hamburger.Controls.Add(this.chk_ketchup);
            this.grp_hamburger.Controls.Add(this.chk_lettuce);
            this.grp_hamburger.Location = new System.Drawing.Point(276, 17);
            this.grp_hamburger.Name = "grp_hamburger";
            this.grp_hamburger.Size = new System.Drawing.Size(277, 174);
            this.grp_hamburger.TabIndex = 1;
            this.grp_hamburger.TabStop = false;
            this.grp_hamburger.Text = "Add-on Items ($.75/each)";
            this.grp_hamburger.Visible = false;
            this.grp_hamburger.TextChanged += new System.EventHandler(this.grp_hamburger_TextChanged);
            this.grp_hamburger.VisibleChanged += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // chk_fries
            // 
            this.chk_fries.AutoSize = true;
            this.chk_fries.Location = new System.Drawing.Point(7, 119);
            this.chk_fries.Name = "chk_fries";
            this.chk_fries.Size = new System.Drawing.Size(124, 24);
            this.chk_fries.TabIndex = 2;
            this.chk_fries.Text = "French Fries";
            this.chk_fries.UseVisualStyleBackColor = true;
            this.chk_fries.Visible = false;
            // 
            // chk_ketchup
            // 
            this.chk_ketchup.AutoSize = true;
            this.chk_ketchup.Location = new System.Drawing.Point(7, 72);
            this.chk_ketchup.Name = "chk_ketchup";
            this.chk_ketchup.Size = new System.Drawing.Size(237, 24);
            this.chk_ketchup.TabIndex = 1;
            this.chk_ketchup.Text = "Ketchup, Mustard, and Mayo";
            this.chk_ketchup.UseVisualStyleBackColor = true;
            this.chk_ketchup.Visible = false;
            // 
            // chk_lettuce
            // 
            this.chk_lettuce.AutoSize = true;
            this.chk_lettuce.Location = new System.Drawing.Point(7, 26);
            this.chk_lettuce.Name = "chk_lettuce";
            this.chk_lettuce.Size = new System.Drawing.Size(257, 24);
            this.chk_lettuce.TabIndex = 0;
            this.chk_lettuce.Text = "Lettuce, Tomatoes, and Onions";
            this.chk_lettuce.UseVisualStyleBackColor = true;
            this.chk_lettuce.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.txt_tax);
            this.groupBox3.Controls.Add(this.txt_subtotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 166);
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
            this.btn_placeOrder.Location = new System.Drawing.Point(379, 234);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.Size = new System.Drawing.Size(148, 44);
            this.btn_placeOrder.TabIndex = 3;
            this.btn_placeOrder.Text = "Place &Order";
            this.btn_placeOrder.UseVisualStyleBackColor = true;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.Location = new System.Drawing.Point(379, 352);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(148, 40);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "E&xit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // grp_pizza
            // 
            this.grp_pizza.Controls.Add(this.chk_olives);
            this.grp_pizza.Controls.Add(this.chk_sausage);
            this.grp_pizza.Controls.Add(this.chk_pepperoni);
            this.grp_pizza.Location = new System.Drawing.Point(270, 30);
            this.grp_pizza.Name = "grp_pizza";
            this.grp_pizza.Size = new System.Drawing.Size(277, 167);
            this.grp_pizza.TabIndex = 3;
            this.grp_pizza.TabStop = false;
            this.grp_pizza.Text = "Add-on Items ($.50/each)";
            this.grp_pizza.Visible = false;
            this.grp_pizza.TextChanged += new System.EventHandler(this.grp_pizza_TextChanged);
            this.grp_pizza.VisibleChanged += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // chk_olives
            // 
            this.chk_olives.AutoSize = true;
            this.chk_olives.Location = new System.Drawing.Point(7, 113);
            this.chk_olives.Name = "chk_olives";
            this.chk_olives.Size = new System.Drawing.Size(77, 24);
            this.chk_olives.TabIndex = 2;
            this.chk_olives.Text = "Olives";
            this.chk_olives.UseVisualStyleBackColor = true;
            this.chk_olives.Visible = false;
            // 
            // chk_sausage
            // 
            this.chk_sausage.AutoSize = true;
            this.chk_sausage.Location = new System.Drawing.Point(6, 67);
            this.chk_sausage.Name = "chk_sausage";
            this.chk_sausage.Size = new System.Drawing.Size(99, 24);
            this.chk_sausage.TabIndex = 1;
            this.chk_sausage.Text = "Sausage";
            this.chk_sausage.UseVisualStyleBackColor = true;
            this.chk_sausage.Visible = false;
            // 
            // chk_pepperoni
            // 
            this.chk_pepperoni.AutoSize = true;
            this.chk_pepperoni.Location = new System.Drawing.Point(7, 34);
            this.chk_pepperoni.Name = "chk_pepperoni";
            this.chk_pepperoni.Size = new System.Drawing.Size(107, 24);
            this.chk_pepperoni.TabIndex = 0;
            this.chk_pepperoni.Text = "Pepperoni";
            this.chk_pepperoni.UseVisualStyleBackColor = true;
            this.chk_pepperoni.Visible = false;
            // 
            // grp_salad
            // 
            this.grp_salad.Controls.Add(this.chk_breadsticks);
            this.grp_salad.Controls.Add(this.chk_bacon);
            this.grp_salad.Controls.Add(this.chk_croutons);
            this.grp_salad.Location = new System.Drawing.Point(257, 30);
            this.grp_salad.Name = "grp_salad";
            this.grp_salad.Size = new System.Drawing.Size(284, 167);
            this.grp_salad.TabIndex = 3;
            this.grp_salad.TabStop = false;
            this.grp_salad.Text = "Add-on Items ($.25/each)";
            this.grp_salad.Visible = false;
            this.grp_salad.TextChanged += new System.EventHandler(this.grp_salad_TextChanged);
            // 
            // chk_breadsticks
            // 
            this.chk_breadsticks.AutoSize = true;
            this.chk_breadsticks.Location = new System.Drawing.Point(7, 112);
            this.chk_breadsticks.Name = "chk_breadsticks";
            this.chk_breadsticks.Size = new System.Drawing.Size(118, 24);
            this.chk_breadsticks.TabIndex = 2;
            this.chk_breadsticks.Text = "Breadsticks";
            this.chk_breadsticks.UseVisualStyleBackColor = true;
            this.chk_breadsticks.Visible = false;
            // 
            // chk_bacon
            // 
            this.chk_bacon.AutoSize = true;
            this.chk_bacon.Location = new System.Drawing.Point(7, 67);
            this.chk_bacon.Name = "chk_bacon";
            this.chk_bacon.Size = new System.Drawing.Size(112, 24);
            this.chk_bacon.TabIndex = 1;
            this.chk_bacon.Text = "Bacon Bits";
            this.chk_bacon.UseVisualStyleBackColor = true;
            this.chk_bacon.Visible = false;
            // 
            // chk_croutons
            // 
            this.chk_croutons.AutoSize = true;
            this.chk_croutons.Location = new System.Drawing.Point(7, 26);
            this.chk_croutons.Name = "chk_croutons";
            this.chk_croutons.Size = new System.Drawing.Size(100, 24);
            this.chk_croutons.TabIndex = 0;
            this.chk_croutons.Text = "Croutons";
            this.chk_croutons.UseVisualStyleBackColor = true;
            this.chk_croutons.Visible = false;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(379, 293);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(148, 39);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_placeOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(572, 412);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.grp_salad);
            this.Controls.Add(this.grp_pizza);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_placeOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grp_hamburger);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_hamburger.ResumeLayout(false);
            this.grp_hamburger.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grp_pizza.ResumeLayout(false);
            this.grp_pizza.PerformLayout();
            this.grp_salad.ResumeLayout(false);
            this.grp_salad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_salad;
        private System.Windows.Forms.RadioButton rdb_pizza;
        private System.Windows.Forms.RadioButton rdb_hamburger;
        private System.Windows.Forms.GroupBox grp_hamburger;
        private System.Windows.Forms.CheckBox chk_fries;
        private System.Windows.Forms.CheckBox chk_ketchup;
        private System.Windows.Forms.CheckBox chk_lettuce;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_placeOrder;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox grp_pizza;
        private System.Windows.Forms.CheckBox chk_olives;
        private System.Windows.Forms.CheckBox chk_sausage;
        private System.Windows.Forms.CheckBox chk_pepperoni;
        private System.Windows.Forms.GroupBox grp_salad;
        private System.Windows.Forms.CheckBox chk_breadsticks;
        private System.Windows.Forms.CheckBox chk_bacon;
        private System.Windows.Forms.CheckBox chk_croutons;
        private System.Windows.Forms.Button btn_clear;
    }
}

