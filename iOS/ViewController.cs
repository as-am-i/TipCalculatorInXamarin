using System;
using Foundation;
using UIKit;

namespace TipCalculatorInXamarin.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TipCalculator calc = new TipCalculator();

            calculateButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                tipAmountLabel.Text = calc.calculateTip(billAmountTextField.Text, tipPercentageTextField.Text);
            };

            billAmountTextField.AddTarget((sender, e) =>
            {
                tipAmountLabel.Text = calc.calculateTip(billAmountTextField.Text, tipPercentageTextField.Text);
            }, UIControlEvent.EditingChanged);

            tipPercentageTextField.AddTarget((sender, e) =>
            {
                tipAmountLabel.Text = calc.calculateTip(billAmountTextField.Text, tipPercentageTextField.Text);
            }, UIControlEvent.EditingChanged);

            tipPercentageSlider.ValueChanged += (sender, e) =>
            {
                int tipPercentage = (int)tipPercentageSlider.Value;

                tipPercentageTextField.Text = tipPercentage.ToString();
                tipAmountLabel.Text = calc.adjustTipPercentage(billAmountTextField.Text, tipPercentage);
            };

        }
    }
}
