using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decision_maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // get the input from the user
            var option1=tbxOption1.Text;
            var option2=tbxOption2.Text;
            var option3=tbxOption3.Text;
            var option4=tbxOption4.Text;
            var option5=tbxOption5.Text;
            var option6=tbxOption6.Text;

            // create array for all the options
            string[] allOptions = {option1,option2,option3,option4,option5,option6};
            
            // create list for options that are not empty
            List<string> full_options= new List<string>();


            // loop through all options 
            foreach (var option in allOptions)
            {
                // get only options that are not empty
                if (String.IsNullOrEmpty(option)==false)
                {
                    full_options.Add(option);
                }
            }

            // get length of options that are not empty
            int options_length = full_options.Count;

            // create a random number in a range of options_length
            Random rnd = new Random();
            int num = rnd.Next(options_length);

            // get random choice from options list
            string random_choice = full_options[num];

            MessageBox.Show(random_choice);

        }
    }
}
