using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProDevProject
{
    public partial class TuesdayPage : ContentPage
    {
        public TuesdayPage()
        {
            InitializeComponent();
            Calculations c = new Calculations();
            Database db = new Database();
            int deadlift = db.getDeadlift();
            int squat = db.getSquat();
            this.BackgroundColor = Color.LightSlateGray;

            // Changes the Label text to the correct weights
            tuesdayDL1Label.Text = c.calc(deadlift, .75) + " x5";
            tuesdayDL2Label.Text = c.calc(deadlift, .85) + " x3";
            tuesdayDL3Label.Text = c.calc(deadlift, .95) + " x1+";
            tuesdayDL4Label.Text = c.calc(deadlift, .90) + " x3";
            tuesdayDL5Label.Text = c.calc(deadlift, .85) + " x3";
            tuesdayDLLabel.Text = c.calc(deadlift, .80) + " x3";
            tuesdayDL7Label.Text = c.calc(deadlift, .75) + " x3";
            tuesdayDL8Label.Text = c.calc(deadlift, .70) + " x3";
            tuesdayDL9Label.Text = c.calc(deadlift, .65) + " x3";

            tuesdayFs1Label.Text = c.calc(squat, .35) + " x5";
            tuesdayFs2Label.Text = c.calc(squat, .45) + " x5";
            tuesdayFs3Label.Text = c.calc(squat, .55) + " x3";
            tuesdayFs4Label.Text = c.calc(squat, .55) + " x5";
            tuesdayFs5Label.Text = c.calc(squat, .55) + " x7";
            tuesdayFs6Label.Text = c.calc(squat, .55) + " x4";
            tuesdayFs7Label.Text = c.calc(squat, .55) + " x6";
            tuesdayFs8Label.Text = c.calc(squat, .55) + " x8";









            tuesdayDL9Check.Toggled += tuesdayDeadLiftCheck_Toggled;
            tuesdayFs8Check.Toggled += tuesdayFrontSquatCheck_Toggled;
            tuesdayCableRow3Check.Toggled += tuesdayCableRowCheck_Toggled;
            tuesdayShrug3Check.Toggled += tuesdayShrugCheck_Toggled;

        }

        private void tuesdayDeadLiftCheck_Toggled(Object sender, EventArgs eventArgs)
        {
            if (tuesdayDL1Check.IsToggled && tuesdayDL2Check.IsToggled && tuesdayDL3Check.IsToggled && tuesdayDL4Check.IsToggled && tuesdayDL5Check.IsToggled && tuesdayDL6Check.IsToggled && tuesdayDL7Check.IsToggled && tuesdayDL8Check.IsToggled && tuesdayDL9Check.IsToggled)
            {
                tuesdayDLButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                tuesdayDLButton.BackgroundColor = Color.Black;
            }

        }


        private void tuesdayFrontSquatCheck_Toggled(Object sender, EventArgs eventArgs)
        {
            if (tuesdayFs1Check.IsToggled && tuesdayFs2Check.IsToggled && tuesdayFs3Check.IsToggled && tuesdayFs4Check.IsToggled && tuesdayFs5Check.IsToggled && tuesdayFs6Check.IsToggled && tuesdayFs7Check.IsToggled && tuesdayFs8Check.IsToggled)
            {
                tuesdayFsButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                tuesdayFsButton.BackgroundColor = Color.Black;
            }

        }

        private void tuesdayCableRowCheck_Toggled(object sender, EventArgs eventArgs)
        {

            if (tuesdayCableRow1Check.IsToggled && tuesdayCableRow2Check.IsEnabled && tuesdayCableRow3Check.IsEnabled)
            {
                tuesdayCableRowButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                tuesdayCableRowButton.BackgroundColor = Color.Black;

            }
        }

        private void tuesdayShrugCheck_Toggled(object sender, EventArgs eventArgs)
        {

            if (tuesdayShrug1Check.IsToggled && tuesdayShrug2Check.IsEnabled && tuesdayShrug3Check.IsEnabled)
            {
                tuesdayShrugButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                tuesdayShrugButton.BackgroundColor = Color.Black;

            }
        }
    }
}
