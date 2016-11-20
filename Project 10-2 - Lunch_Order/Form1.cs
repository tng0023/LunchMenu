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

        double subtotal = 0;  //initialize the calculations
        double tax = .0775;
        double total = 0;
        double currentTotal = 0;
        int counter = 1;

        public void btn_placeOrder_Click(object sender, EventArgs e) //button click to calculate pricing
        {
            if (rtxt_summary.Text == " ")
            {
                MessageBox.Show("Please place an order.", "Order Error");
            }
            else
            {
                summary();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e) //clears all radio buttons, checkboxes and textboxes
        {
            subtotal = 0;
            tax = 0;
            total = 0;
            currentTotal = 0;
            txt_subtotal.Text = " ";
            txt_tax.Text = " ";
            txt_total.Text = " ";
            rdb_hamburger.Checked = false;
            rdb_pizza.Checked = false;
            rdb_salad.Checked = false;
            rtxt_summary.Text = " ";
            foreach (Control control in grp_extras.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)control).Checked = false;
                }
                foreach (Control control1 in grp_extras.Controls)
                {
                    if (control1.GetType() == typeof(CheckBox))
                    {
                        ((CheckBox)control1).Checked = false;
                    }
                }
                foreach (Control control2 in grp_extras.Controls)
                {
                    if (control2.GetType() == typeof(CheckBox))
                    {
                        ((CheckBox)control2).Checked = false;
                    }
                }
            }
        }

        public void clearC() //method to clear all controls
        {
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            txt_subtotal.Text = "";
            txt_tax.Text = "";
            txt_total.Text = "";
        }

        private void totals() //method to calculate totals into text boxes
        {
            tax = Convert.ToDouble(subtotal * .0775);
            total = Convert.ToDouble(subtotal + tax);
            currentTotal = currentTotal + total;
            counter++;

            string sub = subtotal.ToString("c");  //formats data to currency
            string Tax = tax.ToString("c");
            string Total = total.ToString("c");
            txt_subtotal.Text = Convert.ToString(sub);
            txt_tax.Text = Convert.ToString(Tax);
            txt_total.Text = Convert.ToString(Total);

        }

        private void summary() //method for order summary
        {
            DialogResult dialogResult = MessageBox.Show("Does this complete your order?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(rtxt_summary.Text + "\n\n" + "Grand Total: " + currentTotal.ToString("c"), "Order Summary");
            }
            else if (dialogResult == DialogResult.No)
            {
                clearC();
                rdb_hamburger.Checked = false;
                rdb_pizza.Checked = false;
                rdb_salad.Checked = false;
                return;
            }
            MessageBox.Show("Thank you for your order!", "Order Confirmed");
            this.Close();
        }

        private void rdb_pizza_CheckedChanged(object sender, EventArgs e) //updates pizza items
        {
            if (rdb_pizza.Checked == true)
            {
                clearC();
                grp_extras.Text = ("Add-on items($.50/each)");
                chk1.Text = ("Pepperoni");
                chk2.Text = ("Sausage");
                chk3.Text = ("Olives");
            }
        }

        private void rdb_salad_CheckedChanged(object sender, EventArgs e) //updates salad items
        {
            if (rdb_salad.Checked == true)
            {
                clearC();
                grp_extras.Text = ("Add-on items($.25/each)");
                chk1.Text = ("Croutons");
                chk2.Text = ("Bacon bits");
                chk3.Text = ("Bread Sticks");
            }
        }

        private void rdb_hamburger_CheckedChanged(object sender, EventArgs e) //updates hamburger items
        {
            if (rdb_hamburger.Checked == true)
            {
                clearC();
                grp_extras.Text = ("Add-on items($.75/each)");
                chk1.Text = ("Lettuce, tomato, onions");
                chk2.Text = ("Mayonnaise and mustard");
                chk3.Text = ("French fries");
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btn_addOrder_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (rdb_hamburger.Checked)
                {
                    subtotal = 6.95;
                    rtxt_summary.Text += "Order #: " + counter + "\n" + rdb_hamburger.Text;
                    if (chk1.Checked)
                    {
                        subtotal += .75;
                        rtxt_summary.Text += ("\n" + chk1.Text + " - $.75");
                    }
                    if (chk2.Checked)
                    {
                        subtotal += .75;
                        rtxt_summary.Text += ("\n" + chk2.Text + " - $.75");
                    }
                    if (chk3.Checked)
                    {
                        subtotal += .75;
                        rtxt_summary.Text += ("\n" + chk3.Text + " - $.75");
                    }
                    totals();
                    rtxt_summary.Text += "\n----------------------------\nSubtotal: " + txt_subtotal.Text + "\nTax: " + txt_tax.Text + "\nTotal: " + txt_total.Text + "\nGrand Total: " + currentTotal.ToString("c") + "\n*************************\n";
                    rdb_hamburger.Checked = false;
                    rdb_pizza.Checked = false;
                    rdb_salad.Checked = false;
                    chk1.Checked = false;
                    chk2.Checked = false;
                    chk3.Checked = false;
                }
                else if (rdb_pizza.Checked)
                {
                    subtotal = 5.95;
                    rtxt_summary.Text += "Order #: " + counter + "\n" + rdb_pizza.Text;
                    if (chk1.Checked)
                    {
                        subtotal += .50;
                        rtxt_summary.Text += ("\n" + chk1.Text + " - $.50");
                    }
                    if (chk2.Checked)
                    {
                        subtotal += .50;
                        rtxt_summary.Text += ("\n" + chk2.Text + " - $.50");
                    }
                    if (chk3.Checked)
                    {
                        subtotal += .50;
                        rtxt_summary.Text += ("\n" + chk3.Text + " - $.50");
                    }
                    totals();
                    rtxt_summary.Text += "\n----------------------------\nSubtotal: " + txt_subtotal.Text + "\nTax: " + txt_tax.Text + "\nTotal: " + txt_total.Text + "\nGrand Total: " + currentTotal.ToString("c") + "\n*************************\n";
                    rdb_hamburger.Checked = false;
                    rdb_pizza.Checked = false;
                    rdb_salad.Checked = false;
                    chk1.Checked = false;
                    chk2.Checked = false;
                    chk3.Checked = false;
                }
                else if (rdb_salad.Checked)
                {
                    subtotal = 4.95;
                    rtxt_summary.Text += "Order #: " + counter + "\n" + rdb_salad.Text;
                    if (chk1.Checked)
                    {
                        subtotal += .25;
                        rtxt_summary.Text += ("\n" + chk1.Text + " - $.25");
                    }
                    if (chk2.Checked)
                    {
                        subtotal += .25;
                        rtxt_summary.Text += ("\n" + chk2.Text + " - $.25");
                    }
                    if (chk3.Checked)
                    {
                        subtotal += .25;
                        rtxt_summary.Text += ("\n" + chk3.Text + " - $.25");
                    }
                    totals();
                    rtxt_summary.Text += "\n----------------------------\nSubtotal: " + txt_subtotal.Text + "\nTax: " + txt_tax.Text + "\nTotal: " + txt_total.Text + "\nGrand Total: " + currentTotal.ToString("c") + "\n*************************\n";
                    rdb_hamburger.Checked = false;
                    rdb_pizza.Checked = false;
                    rdb_salad.Checked = false;
                    chk1.Checked = false;
                    chk2.Checked = false;
                    chk3.Checked = false;
                }
            }
            catch
            {
                MessageBox.Show("Please place an order!", "Error");
            }
        }
    }
}
