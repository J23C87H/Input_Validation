using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace InputValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating validation pattern through regular expression
            const string pattern = @"^[1]?[\s.-]?\(?[2-9][\d]{2}\)?[\s.-]?[2-9][\d]{2}[\s.-]?[\d]{4}$";

            //setting validation to false
            bool valid = false;

            //pulling text from textbox1 to compare
            string text = textBox1.Text;

            //If statement to compare validation string to entered string
            if (Regex.IsMatch(text, pattern)) valid = true;

            //If statement to change Results Label (label3)
            if (valid) label3.Text = "Valid Phone Number Format";
            else label3.Text = "Invalid Phone Number Format";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear Results Label Text
            label3.Text = "[Results]";

            //Clear TextBox
            textBox1.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Exit button
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Creating Form2 to display a list of valid inputs
            Form2 validInputs = new Form2();

            //Showing Form2 through ShowDialog
            validInputs.ShowDialog();

        }


    }
}
