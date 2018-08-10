using Android.App;
using Android.Widget;
using Android.OS;

namespace TipCalculatorInXamarin.Droid
{
    [Activity(Label = "TipCalculatorInXamarin", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            TipCalculator calc = new TipCalculator();

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            TextView tipAmountResult = FindViewById<TextView>(Resource.Id.tipAmountResult);
            EditText billAmountTextField = FindViewById<EditText>(Resource.Id.billAmountText);
            EditText tipPercentageTextField = FindViewById<EditText>(Resource.Id.tipPercentageText);
            SeekBar tipSeekBar = FindViewById<SeekBar>(Resource.Id.tipSeekBar);


            Button calculateButton = FindViewById<Button>(Resource.Id.calculateButton);
            calculateButton.Click += (sender, e) =>
            {
                tipAmountResult.Text = calc.calculateTip(billAmountTextField.Text, tipPercentageTextField.Text);
            };

            billAmountTextField.TextChanged += (sender, e) =>
            {
                tipAmountResult.Text = calc.calculateTip(billAmountTextField.Text, tipPercentageTextField.Text);
            };

            tipPercentageTextField.TextChanged += (sender, e) =>
            {
                tipAmountResult.Text = calc.calculateTip(billAmountTextField.Text, tipPercentageTextField.Text);
            };

            tipSeekBar.ProgressChanged += (sender, e) =>
            {
                int tipPercentage = (int)tipSeekBar.Progress;

                tipPercentageTextField.Text = tipPercentage.ToString();
                tipAmountResult.Text = calc.adjustTipPercentage(billAmountTextField.Text, tipPercentage);
            };
        }
    }
}

