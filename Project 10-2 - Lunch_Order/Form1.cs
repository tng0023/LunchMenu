using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_10_2___Lunch_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double subtotal = 0;
        double tax = .0775;
        double total = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void btn_placeOrder_Click(object sender, EventArgs e)
        {
            if(rdb_hamburger.Checked == true)
            {
                clear();
                hamburger();               

            }
            else if(rdb_pizza.Checked == true)
            {
                clear();
                pizza();
            }
            else if(rdb_salad.Checked == true)
            {
                clear();
                salad();
            }
            
        }

        public void hamburger()
        {
            if (rdb_hamburger.Checked == true)
            {
                grp_pizza.Visible = false;
                grp_salad.Visible = false;
                grp_hamburger.Visible = true;
                chk_fries.Visible = true;
                chk_ketchup.Visible = true;
                chk_lettuce.Visible = true;
            }
            foreach (CheckBox c in grp_hamburger.Controls)
            {
                if (c.Checked == true)
                {
                    subtotal = Convert.ToDouble(6.95 + .75);
                    tax = Convert.ToDouble(subtotal * .0775);
                    total = Convert.ToDouble(subtotal + tax);

                    string sub = subtotal.ToString("c");
                    string Tax = tax.ToString("c");
                    string Total = total.ToString("c");
                    txt_subtotal.Text = Convert.ToString(sub);
                    txt_tax.Text = Convert.ToString(Tax);
                    txt_total.Text = Convert.ToString(Total);
                }
            }
        }

        public void pizza()
        {
            if (rdb_pizza.Checked == true)
            {
                grp_hamburger.Visible = false;
                grp_salad.Visible = false;
                grp_pizza.Visible = true;
                chk_olives.Visible = true;
                chk_pepperoni.Visible = true;
                chk_sausage.Visible = true;
                subtotal = Convert.ToDouble(5.95);

                foreach (CheckBox c in grp_pizza.Controls)
                {
                    if (c.Checked == true)
                    {
                        subtotal = Convert.ToDouble(5.95 + .50);
                        tax = Convert.ToDouble(subtotal * .0775);
                        total = Convert.ToDouble(subtotal + tax);

                        string sub = subtotal.ToString("c");
                        string Tax = tax.ToString("c");
                        string Total = total.ToString("c");
                        txt_subtotal.Text = Convert.ToString(sub);
                        txt_tax.Text = Convert.ToString(Tax);
                        txt_total.Text = Convert.ToString(Total);
                    }
                }
            }
        }

        public void salad()
        {
            if (rdb_salad.Checked == true)
            {
                grp_salad.Visible = true;
                grp_hamburger.Visible = false;
                grp_pizza.Visible = false;
                chk_croutons.Visible = true;
                chk_bacon.Visible = true;
                chk_breadsticks.Visible = true;
                subtotal = Convert.ToDouble(4.95);

                foreach (CheckBox c in grp_salad.Controls)
                {
                    if (c.Checked == true)
                    {
                        
                        subtotal = Convert.ToDouble(4.95 + .25);
                        tax = Convert.ToDouble(subtotal * .0775);
                        total = Convert.ToDouble(subtotal + tax);

                        string sub = subtotal.ToString("c");
                        string Tax = tax.ToString("c");
                        string Total = total.ToString("c");
                        txt_subtotal.Text = Convert.ToString(sub);
                        txt_tax.Text = Convert.ToString(Tax);
                        txt_total.Text = Convert.ToString(Total);
                    }
                    else
                    {
                        if (c.Checked == true)
                        {
                            subtotal = Convert.ToDouble(4.95);
                            tax = Convert.ToDouble(subtotal * .0775);
                            total = Convert.ToDouble(subtotal + tax);

                            string sub = subtotal.ToString("c");
                            string Tax = tax.ToString("c");
                            string Total = total.ToString("c");
                            txt_subtotal.Text = Convert.ToString(sub);
                            txt_tax.Text = Convert.ToString(Tax);
                            txt_total.Text = Convert.ToString(Total);
                        }
                    }
                }
            }
        }

        public void clear()
        {
            txt_subtotal.Text = " ";
            txt_tax.Text = " ";
            txt_total.Text = " ";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grp_salad_TextChanged(object sender, EventArgs e)
        {
            txt_subtotal.Text = " ";
            txt_tax.Text = " ";
            txt_total.Text = " ";
        }

        private void grp_hamburger_TextChanged(object sender, EventArgs e)
        {
            txt_subtotal.Text = " ";
            txt_tax.Text = " ";
            txt_total.Text = " ";
        }

        private void grp_pizza_TextChanged(object sender, EventArgs e)
        {
            txt_subtotal.Text = " ";
            txt_tax.Text = " ";
            txt_total.Text = " ";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_subtotal.Text = " ";
            txt_tax.Text = " ";
            txt_total.Text = " ";
            foreach (Control control in grp_hamburger.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)control).Checked = false;
                }
            foreach (Control control1 in grp_pizza.Controls)
                {
                    if (control1.GetType() == typeof(CheckBox))
                    {
                        ((CheckBox)control1).Checked = false;
                    }
                }
            foreach (Control control2 in grp_salad.Controls)
                {
                    if (control2.GetType() == typeof(CheckBox))
                    {
                        ((CheckBox)control2).Checked = false;
                    }
                }
            }
        }
    }
}

