using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProDevProject
{
    public partial class SaturdayPage : ContentPage
    {
        public SaturdayPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.LightSlateGray;

            satDL8Check.Toggled += satDLCheck_Toggled;
            satFs6Check.Toggled += satFsCheck_Toggled;
            satBarbellRow3Check.Toggled += satBarbellRowCheck_Toggled;
            satLatPulldown3Check.Toggled += satLatPulldownCheck_Toggled;
        }

        private void satDLCheck_Toggled(Object sender, EventArgs eventArgs)
        {
            if (satDL1Check.IsToggled && satDL2Check.IsToggled && satDL3Check.IsToggled && satDL4Check.IsToggled && satDL5Check.IsToggled && satDL6Check.IsToggled && satDL7Check.IsToggled && satDL8Check.IsToggled)
            {
                satDLButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                satDLButton.BackgroundColor = Color.Black;
            }

        }


        private void satFsCheck_Toggled(Object sender, EventArgs eventArgs)
        {
            if (satFs1Check.IsToggled && satFs2Check.IsToggled && satFs3Check.IsToggled && satFs4Check.IsToggled && satFs5Check.IsToggled && satFs6Check.IsToggled)
            {
                satFsButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                satFsButton.BackgroundColor = Color.Black;
            }

        }

        private void satBarbellRowCheck_Toggled(object sender, EventArgs eventArgs)
        {

            if (satBarbellRow1Check.IsToggled && satBarbellRow2Check.IsEnabled && satBarbellRow3Check.IsEnabled)
            {
                satBarbellRowButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                satBarbellRowButton.BackgroundColor = Color.Black;

            }
        }

        private void satLatPulldownCheck_Toggled(object sender, EventArgs eventArgs)
        {

            if (satLatPulldown1Check.IsToggled && satLatPulldown2Check.IsEnabled && satLatPulldown3Check.IsEnabled)
            {
                satLatPulldownButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                satLatPulldownButton.BackgroundColor = Color.Black;

            }
        }
    }
}
