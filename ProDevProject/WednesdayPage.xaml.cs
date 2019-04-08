using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProDevProject
{
    public partial class WednesdayPage : ContentPage
    {
        public WednesdayPage()
        {
            InitializeComponent();
            Calculations c = new Calculations();
            Database db = new Database();
            int bench = db.getBench();
            int press = db.getPress();
            this.BackgroundColor = Color.LightSlateGray;

            // Changes the Label text to the correct weights
            wedPress1Label.Text = c.calc(press, .75) + " x5";
            wedPress2Label.Text = c.calc(press, .85) + " x5";
            wedPress3Label.Text = c.calc(press, .95) + " x1+";
            wedPress4Label.Text = c.calc(press, .90) + " x3";
            wedPress5Label.Text = c.calc(press, .85) + " x3";
            wedPressLabel.Text = c.calc(press, .80) + " x3";
            wedPress7Label.Text = c.calc(press, .75) + " x5";
            wedPress8Label.Text = c.calc(press, .70) + " x5";
            wedPress9Label.Text = c.calc(press, .65) + " x5+";

            wedIncline1Label.Text = c.calc(bench, .40) + " x6";
            wedIncline2Label.Text = c.calc(bench, .50) + " x5";
            wedIncline3Label.Text = c.calc(bench, .60) + " x3";
            wedIncline4Label.Text = c.calc(bench, .60) + " x5";
            wedIncline5Label.Text = c.calc(bench, .60) + " x7";
            wedIncline6Label.Text = c.calc(bench, .60) + " x4";
            wedIncline7Label.Text = c.calc(bench, .60) + " x6";
            wedIncline8Label.Text = c.calc(bench, .60) + " x8";




            wedPress9Check.Toggled += wedPressCheck_Toggled;
            wedIncline8Check.Toggled += wedInclineCheck_Toggled;
            wedFacePull3Check.Toggled += wedFacePullCheck_Toggled;
            wedLatRaise3Check.Toggled += wedLatRaiseCheck_Toggled;

        }

        private void wedPressCheck_Toggled(Object sender, EventArgs eventArgs)
        {
            if (wedPress1Check.IsToggled && wedPress2Check.IsToggled && wedPress3Check.IsToggled && wedPress4Check.IsToggled && wedPress5Check.IsToggled && wedPress6Check.IsToggled && wedPress7Check.IsToggled && wedPress8Check.IsToggled && wedPress9Check.IsToggled)
            {
                wedPressButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                wedPressButton.BackgroundColor = Color.Black;
            }

        }


        private void wedInclineCheck_Toggled(Object sender, EventArgs eventArgs)
        {
            if (wedIncline1Check.IsToggled && wedIncline2Check.IsToggled && wedIncline3Check.IsToggled && wedIncline4Check.IsToggled && wedIncline5Check.IsToggled && wedIncline6Check.IsToggled && wedIncline7Check.IsToggled && wedIncline8Check.IsToggled)
            {
                wedInclineButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                wedInclineButton.BackgroundColor = Color.Black;
            }

        }

        private void wedFacePullCheck_Toggled(object sender, EventArgs eventArgs)
        {

            if (wedFacePull1Check.IsToggled && wedFacePull2Check.IsEnabled && wedFacePull3Check.IsEnabled)
            {
                wedFacePullButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                wedFacePullButton.BackgroundColor = Color.Black;

            }
        }

        private void wedLatRaiseCheck_Toggled(object sender, EventArgs eventArgs)
        {

            if (wedLatRaise1Check.IsToggled && wedLatRaise2Check.IsEnabled && wedLatRaise3Check.IsEnabled)
            {
                wedLatRaiseButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                wedLatRaiseButton.BackgroundColor = Color.Black;

            }
        }

    }
}
