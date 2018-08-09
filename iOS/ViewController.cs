using System;
using Foundation;
using UIKit;

namespace TipCalculatorInXamarin.iOS
{
    public partial class ViewController : UIViewController
    {
        private string textFieldString = "";
        private string textFieldTip = "";

        private double tipAmount;


        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            calculateButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                calculateTip();
            };

            billAmountTextField.AddTarget((sender, e) =>
            {
                calculateTip();
            }, UIControlEvent.EditingChanged);

            tipPercentageTextField.AddTarget((sender, e) =>
            {
                calculateTip();
            }, UIControlEvent.EditingChanged);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        public void calculateTip()
        {
            textFieldString = billAmountTextField.Text;
            textFieldTip = tipPercentageTextField.Text;

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
                tipAmountLabel.Text = $"Tip: {tipAmount}";
            }
            else
            {
                tipAmountLabel.Text = "Invalid Bill";
            }
        }
    }
}
