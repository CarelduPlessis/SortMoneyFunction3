using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortMoneyFunction3
{
    public partial class SortMoney : Form
    {
        public SortMoney()
        {
            InitializeComponent();
        }

        private void btnSortMoney_Click(object sender, EventArgs e)
        {
            // Declaring variable 
            int[] size = { 100, 50, 20, 10, 5, 2, 1 };
            TextBox textBox;
            int money1 = 0; // Store results
            int money2 = Convert.ToInt32(tbxEnterValue.Text); // User Input: Total amount of money to be sorted

            for (int i = 0; i < size.Length; i++)
            { 
                textBox = (TextBox)this.Controls["tbxMoney" + size[i]];
                // Pass variables in to the method 
                // using out keyword 
                Addition(money2, out money1, size[i]); // call function
                textBox.Text = money1.ToString(); // Display results in textbox
                money2 = money2 - (money1 * size[i]); // calculating how much is left of the "User Input" value
            }
        }

        // Method in which out parameter is passed 
        // and this method returns the value of 
        // the passed parameter 
        public static void Addition(int money2, out int money1, int size)
        {
            money1 = money2 / size;
        }
    }
}
