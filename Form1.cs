using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace OrderPizza
{
    public partial class FRM_OrderPizza : Form
    {
        public FRM_OrderPizza()
        {
            InitializeComponent();

            //Default Settings:
            DefaultForm();

        }


        string[] AllSizes = { "Small", "Medium", "Large" };
        string[] Crusts = { "Thin", "Thick" };
        string[] Toppings = { "Extra cheese", "Mushrooms", "Tomatoes", "Onion", "Olives", "Green Peppers" };
        string[] Place = { "Eat In", "Take Away" };


        // check if child group box is included:

        private bool GBIsIncluded(GroupBox ParentGB, string TargetedGBName)
        {
            foreach (System.Windows.Forms.GroupBox grp in ParentGB.Controls.OfType<System.Windows.Forms.GroupBox>())
            {
                if (grp.Name == TargetedGBName)
                {
                    return true;
                }
            }

            return false;
        }

        private void IncludeGB(GroupBox TargetedGB)
        {
            if (GBIsIncluded(GB_Options, TargetedGB.Name))
            {
                return;
            }
            else
                GB_Options.Controls.Add(TargetedGB);

        }

        private bool RadioButtonIsIncluded(GroupBox GRP, string RBName)
        {
            foreach (RadioButton RDB in GRP.Controls.OfType<RadioButton>())
            {
                if (RDB.Name == RBName)
                {
                    return true;
                }
            }

            return false;
        }

        private void IncludeRadioButton(GroupBox GRP, RadioButton RB)
        {
            if (RadioButtonIsIncluded(GRP, RB.Name))
            {
                return;
            }
            else
                GRP.Controls.Add(RB);
        }

        private bool CheckBoxIsIncluded(GroupBox GRP, string TargetedCheckBoxName)
        {
            foreach (CheckBox CHK in GRP.Controls.OfType<CheckBox>())
            {
                if (CHK.Name == TargetedCheckBoxName)
                {
                    return true;
                }
            }

            return false;
        }

        private void IncludeCheckBox(GroupBox GRP, CheckBox CHK)
        {
            if (CheckBoxIsIncluded(GRP, CHK.Name))
            {
                return;
            }

            GRP.Controls.Add(CHK);
        }


        private bool LabelIsIncluded(GroupBox GRP, string TargetedLabelName)
        {
            foreach (Label LBL in GRP.Controls.OfType<Label>())
            {
                if (LBL.Name == TargetedLabelName)
                { return true; }
            }
            return false;
        }


        private void IncludeLabel(GroupBox GRP, Label TargetedLabel)
        {
            if (LabelIsIncluded(GRP, TargetedLabel.Name)) { return; }

            GRP.Controls.Add(TargetedLabel);
        }



        string Separator = " ";

        float SizeCoast = 0;
        float CrustCoast = 0;
        float ToppingCoast = 0;
        float TotalPrice = 0;

        // ** DEFAULT VALUES: 
        private void DefaultSizes()
        {

            // Texts:
            RB_Size_Small.Text = AllSizes[0];
            RB_Size_Meduim.Text = AllSizes[1];
            RB_Size_Large.Text = AllSizes[2];

            // Values:

            RB_Size_Small.Checked = true;
            RB_Size_Meduim.Checked = false;
            RB_Size_Large.Checked = false;
        }

        private void DefaultCrust()
        {
            // Texts:
            RB_Crust_Thin.Text = Crusts[0];
            RB_Crust_Thick.Text = Crusts[1];

            // Values:

            RB_Crust_Thin.Checked = true;
            //RB_Crust_Thick.Checked = false;
        }

        private void DefaultTopping()
        {

            // Default Texts:
            CHK_ExtraCheese.Text = Toppings[0];
            CHK_Mushrooms.Text = Toppings[1];
            CHK_Tomatoes.Text = Toppings[2];
            CHK_Onion.Text = Toppings[3];
            CHK_Olives.Text = Toppings[4];
            CHK_GreenPeppers.Text = Toppings[5];



            // Default value:

            foreach (System.Windows.Forms.CheckBox CB in GB_Topping.Controls.OfType<System.Windows.Forms.CheckBox>())
            {


                CB.Checked = false;

            }
        }

        private void DefaultWhereToEat()
        {

            // Texts:

            RB_EatIn.Text = Place[0];
            RB_TakeAway.Text = Place[1];
            // Values:

            RB_EatIn.Checked = true;
            RB_TakeAway.Checked = false;
        }

        private void DefaultSummary()
        {

            LBL_Value_Size.Text = AllSizes[0];

            LBL_Value_Topping.Text = Separator;

            LBL_Value_Crust.Text = Crusts[0];

            LBL_Value_Where.Text = Place[0];

        }


        // ** Calculations of price:

        private float CalculateSizeCoast()
        {
            float CurrentSizeCoast = 0;
            foreach (System.Windows.Forms.RadioButton RB in GB_Size.Controls.OfType<System.Windows.Forms.RadioButton>())
            {
                if ((RB.Checked == true))
                {
                    CurrentSizeCoast = Convert.ToSingle(RB.Tag);
                }
            }
            return CurrentSizeCoast;
        }


        private float CalculateCrustCoast()
        {
            float CurrentCrustCoast = 0;
            if (RB_Crust_Thick.Checked == true)
            {
                CurrentCrustCoast = Convert.ToSingle(RB_Crust_Thick.Tag);
            }
            return CurrentCrustCoast;
        }

        private float CalculateToppingCoast()
        {

            List<float> ToppingList = new List<float>();
            float CurrentToppingCoast = 0;

            foreach (System.Windows.Forms.CheckBox CHK in GB_Topping.Controls.OfType<System.Windows.Forms.CheckBox>())
            {
                if (CHK.Checked == true)
                {
                    float CurrentValue = Convert.ToSingle(CHK.Tag);
                    ToppingList.Add(CurrentValue);
                }
            }

            foreach (float Item in ToppingList)
            {
                CurrentToppingCoast += Item;
            }
            return CurrentToppingCoast;
        }


        private void DefaultPrice()
        {
            // Calculate:

            TotalPrice = Convert.ToSingle(RB_Size_Small.Tag);

            // Print:
            LBL_Value_Price.Text = TotalPrice.ToString();
        }

        private float ClaculateTotalPrice()
        {

            SizeCoast = CalculateSizeCoast();

            CrustCoast = CalculateCrustCoast();

            ToppingCoast = CalculateToppingCoast();

            // Calculate value:

            TotalPrice = SizeCoast + CrustCoast + ToppingCoast;


            // Print :
            LBL_Value_Price.Text = TotalPrice.ToString();

            return TotalPrice;
        }

        private void SubscribeToSizeHandlers()
        {
            foreach (RadioButton RB in GB_Size.Controls.OfType<RadioButton>())
            {
                RB.CheckedChanged += ApplySizeChanges;
            }
        }

        private void SubscirbeToCrustHandlers()
        {
            foreach (RadioButton RB in GB_Crust.Controls.OfType<RadioButton>())
            {
                RB.CheckedChanged += ApplyCrustChanges;
            }
        }

        private void SubscribeToPlaceHandlers()
        {
            foreach (RadioButton RB in GB_WhereToEat.Controls.OfType<RadioButton>())
            {
                RB.CheckedChanged += ApplyPlaceChanges;
            }
        }

        private void SubscribeToToppingHandlers()
        {
            foreach (CheckBox CHK in GB_Topping.Controls.OfType<CheckBox>())
            {
                CHK.CheckedChanged += ApplyToppingsChanges;
            }
        }


        private void SubscribeEventHandlers()
        {
            SubscribeToSizeHandlers();
            SubscirbeToCrustHandlers();
            SubscribeToToppingHandlers();
            SubscribeToPlaceHandlers();
        }



        private void DefaultForm()
        {

            // Default size:

            DefaultSizes();

            // Default Crust:

            DefaultCrust();

            // Default Topping:

            DefaultTopping();

            // Default Where To eat:

            DefaultWhereToEat();

            // Default Summary:

            DefaultSummary();

            // Subscribe to event handlers for radio buttons and checkboxes
            SubscribeEventHandlers();
            // Default price:

            DefaultPrice();

            GB_Options.Enabled = true;

        }

        // Confirm & Reset Order:



        private void BTN_Confirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? ", "Confirm Order", MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Confirmed ...Happy Eating :-)");
                GB_Options.Enabled = false;
            }
            else
                MessageBox.Show("Choice your Pizza then :-) ");
        }

        private void BTN_Rest_Click(object sender, EventArgs e)
        {
            DefaultForm();
        }


        // Tracking Changes: Summary + Total Price:



        private void UpdateSummarySizeValue()
        {
            foreach (System.Windows.Forms.RadioButton RB in GB_Size.Controls.OfType<System.Windows.Forms.RadioButton>())
            {
                if (RB.Checked)
                {
                    LBL_Value_Size.Text = RB.Text;
                }
            }
        }

        private void UpdateSummaryCrustValue()
        {
            foreach (System.Windows.Forms.RadioButton RB in GB_Crust.Controls.OfType<System.Windows.Forms.RadioButton>())
            {
                if (RB.Checked)
                {
                    LBL_Value_Crust.Text = RB.Text;
                }
            }
        }




        private void UpdateSummaryPlaceValue()
        {
            foreach (System.Windows.Forms.RadioButton RB in GB_WhereToEat.Controls.OfType<System.Windows.Forms.RadioButton>())
            {
                if (RB.Checked)
                {
                    LBL_Value_Where.Text = RB.Text;
                }
            }
        }
        private void HandelMultiLineToppings(List<string> ChoosedToppingList)
        {
            // Check if there are any selected toppings
            if (ChoosedToppingList.Count > 0)
            {
                // Add the first three toppings on one line
                LBL_Value_Topping.Text = string.Join(" - ", ChoosedToppingList.Take(3));

                // Check if there are more than three toppings
                if (ChoosedToppingList.Count > 3)
                {
                    // Add a new line
                    LBL_Value_Topping.Text += Environment.NewLine;

                    // Add the remaining toppings on the next line
                    LBL_Value_Topping.Text += string.Join(" - ", ChoosedToppingList.Skip(3));
                }
            }
            else
            {
                LBL_Value_Topping.Text = string.Empty; // No selected toppings, clear the text
            }

        }
        private void UpdateSummaryToppingsValue()
        {
            // Create (dynamic Container /list) to hold values:

            List<string> ToppingLatestValues = new List<string>();


            foreach (System.Windows.Forms.CheckBox CHK in GB_Topping.Controls.OfType<System.Windows.Forms.CheckBox>())
            {
                if (CHK.Checked)
                {
                    ToppingLatestValues.Add(CHK.Text);
                }
            }

            // handel Items:
            HandelMultiLineToppings(ToppingLatestValues);


        }

        // Track changes of Pizza's sizes:

        private void ApplySizeChanges(object sender, EventArgs e)
        {
            UpdateSummarySizeValue();

            ClaculateTotalPrice();
        }


        private void ApplyCrustChanges(object sender, EventArgs e)
        {
            UpdateSummaryCrustValue();

            ClaculateTotalPrice();
        }

        private void ApplyToppingsChanges(object sender, EventArgs e)
        {
            UpdateSummaryToppingsValue();

            ClaculateTotalPrice();
        }

        private void ApplyPlaceChanges(object sender, EventArgs e)
        {
            UpdateSummaryPlaceValue();

            
        }





    }

}
