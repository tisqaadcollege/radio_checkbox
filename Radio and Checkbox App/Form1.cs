using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_and_Checkbox_App
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void btnShowOrHide_Click(object sender, EventArgs e)
        {
            // Show or Hide Listbox and Combobox 
            if(chkShoworHide.Checked == true)
            {
                lstCountry.Visible = true;
                cmbHoppy.Visible = true;
            }
            else
            {
                lstCountry.Visible = false;
                cmbHoppy.Visible = false;
            }
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            // Add Country in Listbox
            lstCountry.Items.Add(txtCountry.Text);

        }

        private void btnDelCountry_Click(object sender, EventArgs e)
        {
            // Delete Country from Listbox
            int x;
            x = lstCountry.SelectedIndex;
            lstCountry.Items.RemoveAt(x);
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            // Change Background Color in Form
            if(rdbRed.Checked == true)
            {
                BackColor = Color.Red;
            }
            else if(rdbGreen.Checked == true)
            {
                BackColor = Color.Green;

            }
            else if(rdbBlue.Checked == true)
            {
                BackColor = Color.Blue;
            }
            else if(rdbYellow.Checked == true)
            {
                base.BackColor = Color.Yellow; 
            }
            else
            {
                MessageBox.Show("Please Select Background Color you want!");
            }
        }

        private void btnAddHoppy_Click(object sender, EventArgs e)
        {
            // Add Hoppies in Combobox
            cmbHoppy.Items.Add(txtHoppy.Text);
        }

        private void btnDelHoppy_Click(object sender, EventArgs e)
        {
            // Delete Hoppies from ComboBox
            int x;
            x = cmbHoppy.SelectedIndex;
            cmbHoppy.Items.RemoveAt(x);
        }
    }
}
