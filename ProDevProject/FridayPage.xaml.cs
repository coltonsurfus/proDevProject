using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProDevProject
{
    public partial class FridayPage : ContentPage
    {
        public FridayPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.LightSlateGray;
            Calculations c = new Calculations();
            Database db = new Database();
            int bench = db.getBench();
            // Changes the Label text to the correct weights
            friBench1Label.Text = c.calc(bench, .75) + " x5";
            friBench2Label.Text = c.calc(bench, .85) + " x3";
            friBench3Label.Text = c.calc(bench, .95) + " x1+";
            friBench4Label.Text = c.calc(bench, .90) + " x3";
            friBench5Label.Text = c.calc(bench, .85) + " x5";
            friBench6Label.Text = c.calc(bench, .80) + " x3";
            friBench7Label.Text = c.calc(bench, .75) + " x5";
            friBench8Label.Text = c.calc(bench, .70) + " x3";
            friBench9Label.Text = c.calc(bench, .65) + " x5+";

            friCg1Label.Text = c.calc(bench, .40) + " x5";
            friCg2Label.Text = c.calc(bench, .50) + " x5";
            friCg3Label.Text = c.calc(bench, .60) + " x3";
            friCg4Label.Text = c.calc(bench, .60) + " x5";
            friCg5Label.Text = c.calc(bench, .60) + " x7";
            friCg6Label.Text = c.calc(bench, .60) + " x4";
            friCg7Label.Text = c.calc(bench, .60) + " x6";
            friCg8Label.Text = c.calc(bench, .60) + " x8";




            friBench9Check.Toggled += friBenchCheck_Toggled;
            friCg8Check.Toggled += friCgCheck_Toggled;
            friDbCurls3Check.Toggled += friDbCurlsCheck_Toggled;
            friTriExt3Check.Toggled += friTriExtCheck_Toggled;
        }

        private void friBenchCheck_Toggled(Object sender, EventArgs eventArgs)
        {
            if (friBench1Check.IsToggled && friBench2Check.IsToggled && friBench3Check.IsToggled && friBench4Check.IsToggled && friBench5Check.IsToggled && friBench6Check.IsToggled && friBench7Check.IsToggled && friBench8Check.IsToggled && friBench9Check.IsToggled)
            {
                friBenchButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                friBenchButton.BackgroundColor = Color.Black;
            }

        }


        private void friCgCheck_Toggled(Object sender, EventArgs eventArgs)
        {
            if (friCg1Check.IsToggled && friCg2Check.IsToggled && friCg3Check.IsToggled && friCg4Check.IsToggled && friCg5Check.IsToggled && friCg6Check.IsToggled && friCg7Check.IsToggled && friCg8Check.IsToggled)
            {
                friCgButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                friCgButton.BackgroundColor = Color.Black;
            }

        }

        private void friDbCurlsCheck_Toggled(object sender, EventArgs eventArgs)
        {

            if (friDbCurls1Check.IsToggled && friDbCurls2Check.IsEnabled && friDbCurls3Check.IsEnabled)
            {
                friDbCurlsButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                friDbCurlsButton.BackgroundColor = Color.Black;

            }
        }

        private void friTriExtCheck_Toggled(object sender, EventArgs eventArgs)
        {

            if (friTriExt1Check.IsToggled && friTriExt2Check.IsEnabled && friTriExt3Check.IsEnabled)
            {
                friTriExtButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                friTriExtButton.BackgroundColor = Color.Black;

            }
        }
    }
}
