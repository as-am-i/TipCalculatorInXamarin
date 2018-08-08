// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TipCalculatorInXamarin.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField billAmountTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton calculateButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tipAmountLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField tipPercentageTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (billAmountTextField != null) {
                billAmountTextField.Dispose ();
                billAmountTextField = null;
            }

            if (calculateButton != null) {
                calculateButton.Dispose ();
                calculateButton = null;
            }

            if (tipAmountLabel != null) {
                tipAmountLabel.Dispose ();
                tipAmountLabel = null;
            }

            if (tipPercentageTextField != null) {
                tipPercentageTextField.Dispose ();
                tipPercentageTextField = null;
            }
        }
    }
}