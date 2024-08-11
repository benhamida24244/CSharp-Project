using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void UpdateSize()
        {
            CalculateAllPrice();
            if (rbSamll.Checked)
            {
                lblSize.Text = "Small";
            }
            else if(rbMedium.Checked)
            {
                lblSize.Text = "Medium";
            }
            else if(rbLarge.Checked)
            {
                lblSize.Text = "Large";
            }
        }
        void UpdateCrust()
        {
            CalculateAllPrice();

            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin";
            }
            else if (rbThickCrust.Checked)
            {
                lblCrustType.Text = "Think";
            }
        }
        void UpdatePlace()
        {

            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
            }
            if (rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out";
            }
        }
        void UpdateTopping()
        {
            CalculateAllPrice();
            StringBuilder STopping = new StringBuilder();
            if (chkExtraChees.Checked)
            {
                if (STopping.Length > 0) STopping.Append(",");
                STopping.Append(" Extra Cheese");
            }
            if (chkMushrooms.Checked)
            {
                if (STopping.Length > 0) STopping.Append(",");
                STopping.Append(" Mushrooms");
            }
            if (chkTomatos.Checked)
            {
                if (STopping.Length > 0) STopping.Append(",");

                STopping.Append(" Tomato");
            }
            if (chkOlives.Checked)
            {
                if (STopping.Length > 0) STopping.Append(",");

                STopping.Append(" Olives");
            }
            if (chkOnion.Checked)
            {
                if (STopping.Length > 0) STopping.Append(",");

                STopping.Append(" Onion");

            }
            if (chkGreenPeppers.Checked)
            {
                if (STopping.Length > 0) STopping.Append(",");

                STopping.Append(" Green Peppers");
            }
            if(STopping.Length == 0)
            {
                STopping.Append("No Toppings.");
            }
            lblToppings.Text = STopping.ToString();
            }

        void UpdateOrderAccept()
        {
            if(MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                if(MessageBox.Show("Order Placed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    UpdateSeccessOrder();
                }
            }
        }
        void UpdateSeccessOrder()
        {
            //Size
            rbSamll.Enabled = false;
            rbMedium.Enabled = false;
            rbLarge.Enabled = false;
            //Crust Typing
            rbThinCrust.Enabled = false;
            rbThickCrust.Enabled = false;
            //Toppings
            chkExtraChees.Enabled = false;
            chkMushrooms.Enabled = false;
            chkTomatos.Enabled = false;
            chkOlives.Enabled = false;
            chkOnion.Enabled = false;
            chkGreenPeppers.Enabled = false;
            //Place To Eat
            rbEatIn.Enabled = false;
            rbTakeOut.Enabled = false;
        }

        void ResetOrder()
        {
            //Size
            rbSamll.Enabled = true;
            rbMedium.Enabled = true;
            rbLarge.Enabled = true;
            //Crust Typing
            rbThinCrust.Enabled = true;
            rbThickCrust.Enabled = true;
            //Toppings
            chkExtraChees.Enabled = true;
            chkMushrooms.Enabled = true;
            chkTomatos.Enabled = true;
            chkOlives.Enabled = true;
            chkOnion.Enabled = true;
            chkGreenPeppers.Enabled = true;
            //Place To Eat
            rbEatIn.Enabled = true;
            rbTakeOut.Enabled = true;
        }

        void CalculateAllPrice()
        {
            float Total = ClaculateSizePrice() + ClaculateCrustPrice() + CalculateToppingsPrice();
            string s1 = "$" + Total.ToString();
            lblTotalPrice.Text = s1;
        }
        float ClaculateSizePrice()
        {
            float Total = 5;
            if (rbSamll.Checked)
            {
                Total = 5;
            }
            if (rbMedium.Checked)
            {
                Total += 3;
            }
            if (rbLarge.Checked)
            {
                Total += 6;
            }
            return Total;
        }
        float ClaculateCrustPrice()
        {
            float Total = 0;
            if (rbThinCrust.Checked)
            {
                Total = 0;
            }
             if (rbThickCrust.Checked)
            {
                Total += 2;
            }
            return Total;
        }
        float CalculateToppingsPrice()
        {
            float Total = 0;
            if(chkExtraChees.Checked)
            {
                Total += 1;
            }
            if (chkMushrooms.Checked)
            {
                Total += 1;
            }
            if (chkTomatos.Checked)
            {
                Total += 1;
            }
            if (chkOlives.Checked)
            {
                Total += 1;
            }
            if (chkOnion.Checked)
            {
                Total += 1;

            }
            if (chkGreenPeppers.Checked)
            {
                Total += 1;
            }
            return Total;
        }

   

        private void rbSamll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlace();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlace();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            UpdateOrderAccept();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetOrder();
        }
    }
}
