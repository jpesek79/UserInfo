//Program:    Bag Orders Chapter 10 Problem 6
//Programmer: Joseph Pesek
//Date:       4/28/2017
//Purpose:    Create an oder form for selling bags

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseBags
{
    public partial class BagsForm : Form
    {
        public BagsForm()
        {
            InitializeComponent();

            //sets the default value of the orders
            this.cmboBeadBag.SelectedIndex = 0;
            this.cmboDesignBag.SelectedIndex = 0;
            this.cmboFringeBag.SelectedIndex = 0;
            this.cmboLeatherBag.SelectedIndex = 0;
            this.cmboPirateBag.SelectedIndex = 0;
            this.cmboPlainBag.SelectedIndex = 0;
        }

        //Submit Button checks for quantities and displays error or order
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (this.cmboBeadBag.SelectedIndex == 0 && this.cmboDesignBag.SelectedIndex == 0 && this.cmboFringeBag.SelectedIndex == 0 && this.cmboLeatherBag.SelectedIndex == 0 && this.cmboPirateBag.SelectedIndex == 0 && this.cmboPlainBag.SelectedIndex == 0)
            {
                MessageBox.Show("You must select at least 1 bag to order.");
                cmboDesignBag.Focus();
            }
            else
            {
                //prices for bags
                int decPrice = 50 * cmboDesignBag.SelectedIndex;
                int beadPrice = 45 * cmboBeadBag.SelectedIndex;
                int piratePrice = 40 * cmboPirateBag.SelectedIndex;
                int fringePrice = 25 * cmboFringeBag.SelectedIndex;
                int leatherPrice = 80 * cmboLeatherBag.SelectedIndex;
                int plainPrice = 20 * cmboPlainBag.SelectedIndex;
                int subTotal = decPrice + beadPrice + piratePrice + fringePrice + leatherPrice + plainPrice;
                double total;
                double shipping;

                if (this.radOverNight.Checked == true)
                {
                    shipping = subTotal * .1;
                    total = subTotal + shipping;

                    MessageBox.Show("You have ordered:\n\n" + cmboBeadBag.SelectedIndex + " Beaded Bags: $" + beadPrice + "\n" + cmboDesignBag.SelectedIndex + " Decorative Bags: $" + decPrice + "\n" + cmboFringeBag.SelectedIndex + " Fringe Bags: $" + fringePrice + "\n" + cmboLeatherBag.SelectedIndex + " Leather Bags: $" + leatherPrice + "\n" + cmboPirateBag.SelectedIndex + " Pirate Bags: $" + piratePrice + "\n" + cmboPlainBag.SelectedIndex + " Plain Bags: $" + cmboPlainBag.SelectedIndex + "\n\n" + "SubTotal: $" + subTotal + "\n" + "Shipping: $" + shipping + "\n\n" + "Total: $" + total);
                }
                else if (this.radThreeDay.Checked == true)
                {
                    shipping = subTotal * .07;
                    total = subTotal + shipping;

                    MessageBox.Show("You have ordered:\n\n" +         cmboBeadBag.SelectedIndex + " Beaded Bags: $" + beadPrice + "\n" + cmboDesignBag.SelectedIndex + " Decorative Bags: $" + decPrice + "\n" + cmboFringeBag.SelectedIndex + " Fringe Bags: $" + fringePrice + "\n" + cmboLeatherBag.SelectedIndex + " Leather Bags: $" + leatherPrice + "\n" + cmboPirateBag.SelectedIndex + " Pirate Bags: $" + piratePrice + "\n" + cmboPlainBag.SelectedIndex + " Plain Bags: $" + cmboPlainBag.SelectedIndex + "\n" + "SubTotal: $" + subTotal + "\n" + "Shipping: $" + shipping + "\n" + "Total: $" + total);
                }
                else if (this.radStandard.Checked == true)
                {
                    shipping = subTotal * .05;
                    total = subTotal + shipping;

                    MessageBox.Show("You have ordered:\n\n" + cmboBeadBag.SelectedIndex + " Beaded Bags: $" + beadPrice + "\n" + cmboDesignBag.SelectedIndex + " Decorative Bags: $" + decPrice + "\n" + cmboFringeBag.SelectedIndex + " Fringe Bags: $" + fringePrice + "\n" + cmboLeatherBag.SelectedIndex + " Leather Bags: $" + leatherPrice + "\n" + cmboPirateBag.SelectedIndex + " Pirate Bags: $" + piratePrice + "\n" + cmboPlainBag.SelectedIndex + " Plain Bags: $" + cmboPlainBag.SelectedIndex + "\n" + "SubTotal: $" + subTotal + "\n" + "Shipping: $" + shipping + "\n" + "Total: $" + total);
                }
                else
                {
                    MessageBox.Show("Please select a shipping method.");
                    radOverNight.Focus();
                }
                 
              
            }
        }

        //sets the clear function to the clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.cmboBeadBag.SelectedIndex = 0;
            this.cmboDesignBag.SelectedIndex = 0;
            this.cmboFringeBag.SelectedIndex = 0;
            this.cmboLeatherBag.SelectedIndex = 0;
            this.cmboPirateBag.SelectedIndex = 0;
            this.cmboPlainBag.SelectedIndex = 0;
            this.radOverNight.Checked = false;
            this.radStandard.Checked = false;
            this.radThreeDay.Checked = false;

            cmboDesignBag.Focus();
        }
    }
}
