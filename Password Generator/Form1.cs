using System;
using System.Windows.Forms;
using PssGenerate;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenrate_Click(object sender, EventArgs e)
        {
            if (PssLength.Text != null)
            {
                int lengthPss = int.Parse(PssLength.Text);
                if (lengthPss <= 0)
                {
                    lengthPss = 20;
                }

                PssGenerate.PssGenerate.PssSpecialization specialization = 0;


                if (chUpperCase.Checked)
                {
                    specialization |= PssGenerate.PssGenerate.PssSpecialization.IncludeUpperCase;
                }

                if (chLowerCase.Checked)
                {
                    specialization |= PssGenerate.PssGenerate.PssSpecialization.IncludeLowerCase;
                }

                if (chIncludeNum.Checked)
                {
                    specialization |= PssGenerate.PssGenerate.PssSpecialization.IncludeNumber;
                }

                if (chIncludeSym.Checked)
                {
                    specialization |= PssGenerate.PssGenerate.PssSpecialization.IncludeSymbol;
                }

                InPss.Text = PssGenerate.PssGenerate.PasswordGt(lengthPss, specialization);
            }
            else
            {
                MessageBox.Show("Entre Password Length !", "Invaild Length", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(InPss.Text))
            {
                Clipboard.SetText(InPss.Text);
                MessageBox.Show("Password copied to clipboard!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
                MessageBox.Show("There is no password to copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}