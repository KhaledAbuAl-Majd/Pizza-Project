using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class FrmPizzaOrder : Form
    {


         void MakeToppingValue(string Value = "No Toppings", short Price = 0, bool Checked = true)
        {
            if (Checked)
            {
                if (lblToppingsValue.Text == "No Toppings")
                    lblToppingsValue.Text = Value;
                else
                    lblToppingsValue.Text = lblToppingsValue.Text + ", " + Value;
                int Total = Convert.ToInt32(lblTotalPriceValue.Text);
                Total += Price;
                lblTotalPriceValue.Text = Total.ToString();
            }
            else
            {
                int Total = Convert.ToInt32(lblTotalPriceValue.Text) ;
                Total -= Price;
                lblTotalPriceValue.Text = Total.ToString();

                int Index =lblToppingsValue.Text.IndexOf(Value);
                int Length = Value.Length;

                if (lblToppingsValue.Text.Length != Value.Length)
                {
                    if (Index == 0)
                    {
                        Length += 2;
                        
                    }
                    else
                    {
                        Index -= 2;
                        Length += 2;

                    }
                }

                lblToppingsValue.Text = lblToppingsValue.Text.Remove(Index,Length);

                if (lblToppingsValue.Text == "")
                    lblToppingsValue.Text = "No Toppings";
            }

           
        }
        public FrmPizzaOrder()
        {
            InitializeComponent();
        }

        private void gbOrderSummary_Enter(object sender, EventArgs e)
        {

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                lblSizeValue.Tag = rbSmall.Tag;
                lblSizeValue.Text = rbSmall.Text;
            
            }
            else
            {
                int Total = Convert.ToInt32(lblTotalPriceValue.Text);
                Total -= Convert.ToInt32(rbSmall.Tag);
                lblTotalPriceValue.Text = Total.ToString();
            }

        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMeduim.Checked)
            {
                lblSizeValue.Tag = rbMeduim.Tag;
                lblSizeValue.Text = rbMeduim.Text;
            }
            else
            {
                int Total = Convert.ToInt32(lblTotalPriceValue.Text);
                Total -= Convert.ToInt32(rbMeduim.Tag);
                lblTotalPriceValue.Text = Total.ToString();
            }
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarg.Checked)
            {
                lblSizeValue.Tag = rbLarg.Tag;
                lblSizeValue.Text = rbLarg.Text;
            }
            else
            {
                int Total = Convert.ToInt32(lblTotalPriceValue.Text);
                Total -= Convert.ToInt32(rbLarg.Tag);
                lblTotalPriceValue.Text = Total.ToString();
            }

        }

        private void lblTotalPriceValue_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSizeValue_TextChanged(object sender, EventArgs e)
        {
            int Total = Convert.ToInt32(lblTotalPriceValue.Text);
            Total += Convert.ToInt32(lblSizeValue.Tag);
            lblTotalPriceValue.Text = Total.ToString();

        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThinCrust.Checked)
            {
                lblCrustTypeValue.Tag = rbThinCrust.Tag;
                lblCrustTypeValue.Text = rbThinCrust.Text;
            }
            else
            {
                int Total = Convert.ToInt32(lblTotalPriceValue.Text);
                Total -= Convert.ToInt32(rbThinCrust.Tag);
                lblTotalPriceValue.Text = Total.ToString();
            }
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            MakeToppingValue(chkExtraChees.Text, Convert.ToInt16(chkExtraChees.Tag), chkExtraChees.Checked);
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            MakeToppingValue(chkOnion.Text, Convert.ToInt16(chkOnion.Tag), chkOnion.Checked);
        }

        private void gbToppings_Enter(object sender, EventArgs e)
        {

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            MakeToppingValue(chkMushrooms.Text, Convert.ToInt16(chkMushrooms.Tag), chkMushrooms.Checked);
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            MakeToppingValue(chkOlives.Text, Convert.ToInt16(chkOlives.Tag), chkOlives.Checked);
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            MakeToppingValue(chkTomatoes.Text, Convert.ToInt16(chkTomatoes.Tag), chkTomatoes.Checked);
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            MakeToppingValue(chkGreenPeppers.Text, Convert.ToInt16(chkGreenPeppers.Tag)
                , chkGreenPeppers.Checked);
        }

        private void lblSizeValue_Click(object sender, EventArgs e)
        {

        }

        private void lblCrustTypeValue_Click(object sender, EventArgs e)
        {
            int Total = Convert.ToInt32(lblTotalPriceValue.Text);
            Total += Convert.ToInt32(lblCrustType.Tag);
            lblTotalPriceValue.Text = Total.ToString();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThinkCrust.Checked)
            {
                lblCrustTypeValue.Tag = rbThinkCrust.Tag;
                lblCrustTypeValue.Text = rbThinkCrust.Text;
            }
            else
            {
                int Total = Convert.ToInt32(lblTotalPriceValue.Text);
                Total -= Convert.ToInt32(rbThinkCrust.Tag);
                lblTotalPriceValue.Text = Total.ToString();
            }
        }

        private void lblCrustTypeValue_TextChanged(object sender, EventArgs e)
        {
            int Total = Convert.ToInt32(lblTotalPriceValue.Text);
            Total += Convert.ToInt32(lblCrustTypeValue.Tag);
            lblTotalPriceValue.Text = Total.ToString();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEatIn.Checked)
                lblWhereToEatvalue.Text = rbEatIn.Text;
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeOut.Checked)
                lblWhereToEatvalue.Text = rbTakeOut.Text;
        }

        private void butOrderPizza_Click(object sender, EventArgs e)
        {
            if (gbSize.Enabled)

                if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    MessageBox.Show("Order Placed Successfully", "Success");

                    gbSize.Enabled = false;
                    gbCrustType.Enabled = false;
                    gbToppings.Enabled = false;
                    gbWhereToEat.Enabled = false;
                }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            rbMeduim.Checked = true;
            rbThinCrust.Checked = true;
            rbEatIn.Checked = true;

            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;
        }
    }
}
