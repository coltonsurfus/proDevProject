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
            this.BackgroundColor = Color.LightSlateGray;

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
