using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Binkley
{
    public partial class EAAddUpdate : Form
    {
        public static string addOrMod = "";
        public EAAddUpdate()
        {
            InitializeComponent();
        }

        private void saveButtonEAF_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }


            if (addOrMod == "add")
            {

            }

            if (addOrMod == "mod")
            {

            }

            ClearTextboxes();
            this.Visible = false;
            Calender.custForm.Visible = true;
        }

        private void cancelButtonEAF_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
            this.Visible = false;
            Calender.custForm.Visible = true;
        }

        // Void -> Void
        // This method clears the forms textboxes
        public void ClearTextboxes()
        {
            foreach (Control txtBox in this.Controls)
            {
                if (txtBox is TextBox)
                {
                    txtBox.Text = "";
                }
            }
        }

        // void -> Boolean
        // This function ensures that no textboxes are left empty
        public bool ValidateInput()
        {
            foreach (Control txtBox in this.Controls)
            {
                if ((txtBox is TextBox) && (txtBox.Text == ""))
                {
                    MessageBox.Show("There cannot be any empt inputs!", "Customer Edit Error", MessageBoxButtons.OK);
                    return false;
                }
            }

            return true;
        }
    }
}
