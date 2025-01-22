using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class FrmPizzaOrder : Form
    {
      
        public FrmPizzaOrder()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {

            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbMeduim.Checked)
            {
                lblSize.Text = "Meduim";
                return;
            }

            if (rbLarg.Checked)
            {
                lblSize.Text = "Larg";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string Toppings = "";

            if (chkExtraChees.Checked)
            {
                Toppings = chkExtraChees.Text;
            }

            if (chkOnion.Checked)
            {
                Toppings += ", " + chkOnion.Text;
            }

            if (chkMushrooms.Checked)
            {
                Toppings += ", " + chkMushrooms.Text;
            }

            if (chkOlives.Checked)
            {
                Toppings += ", " + chkOlives.Text;
            }

            if (chkTomatoes.Checked)
            {
                Toppings += ", " + chkTomatoes.Text;
            }

            if (chkGreenPeppers.Checked)
            {
                Toppings += ", " + chkGreenPeppers.Text;
            }

            if (Toppings.StartsWith(","))
            {
                Toppings = Toppings.Substring(1, Toppings.Length - 1).Trim();
            }

            if (Toppings == "")
            {
                Toppings = "No Toppings.";
            }

            lblToppings.Text = Toppings;
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }

            if (rbThinkCrust.Checked)
            {
                lblCrustType.Text = "Think Crust";
                return;
            }
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                return;
            }

            if (rbTakeOut.Checked)
            {

                lblWhereToEat.Text = "Take Out";
                return;
            }
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)

                return Convert.ToSingle(rbSmall.Tag);

            else if (rbMeduim.Checked)

                return Convert.ToSingle(rbMeduim.Tag);

            else

                return Convert.ToSingle(rbLarg.Tag);
            
        }

        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if (chkExtraChees.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag) ;

            if (chkOnion.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);

            if (chkMushrooms.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);

            if (chkOlives.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);

            if (chkTomatoes.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);

            if (chkGreenPeppers.Checked)
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);

            return ToppingsTotalPrice;
        }

        float GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);

            else
                return Convert.ToSingle(rbThinkCrust.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            lblTotallPrice.Text = "$" + CalculateTotalPrice();
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        void ResetForm()
        {
            btnOrderPizza.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrustType.Enabled = true;
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

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void FrmPizzaOrder_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question
                , MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success");

                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
