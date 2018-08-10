using System;
namespace TipCalculatorInXamarin
{
    public class TipCalculator
    {
        public TipCalculator()
        {
        }

        private double tipAmount;

        public string calculateTip(string textFieldString, string textFieldTip)
        {
            string tipAmountText = "Invalid Bill";

            if (textFieldString != "")
            {
                if (textFieldTip != "")
                {
                    tipAmount = double.Parse(textFieldString) * double.Parse(textFieldTip) * 0.01;
                }
                else
                {
                    tipAmount = double.Parse(textFieldString) * 0.15;
                }
                tipAmountText = $"Tip: {tipAmount}";
            }

            return tipAmountText;
        }

        public string adjustTipPercentage(string textFieldString, int tipPercentage)
        {
            //tipPercentageTextField.Text = tipPercentage.ToString();
            string textFieldTip = tipPercentage.ToString();
            return calculateTip(textFieldString, textFieldTip);
        }
    }
}
