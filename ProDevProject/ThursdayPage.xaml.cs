using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProDevProject
{
    public partial class ThursdayPage : ContentPage
    {
        public ThursdayPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.LightSlateGray;

            thursSquat9Check.Toggled += thursSquatCheck_Toggled;
            thursSumo8Check.Toggled += thursSumoCheck_Toggled;
            thursLegPress3Check.Toggled += thursLegPressCheck_Toggled;
            thursHamCurl3Check.Toggled += thursHamCurlCheck_Toggled;

        }

        private void thursSquatCheck_Toggled(Object sender, EventArgs eventArgs)
        {
            if (thursSquat1Check.IsToggled && thursSquat2Check.IsToggled && thursSquat3Check.IsToggled && thursSquat4Check.IsToggled && thursSquat5Check.IsToggled && thursSquat6Check.IsToggled && thursSquat7Check.IsToggled && thursSquat8Check.IsToggled && thursSquat9Check.IsToggled)
            {
                thursSquatButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                thursSquatButton.BackgroundColor = Color.Black;
            }

        }


        private void thursSumoCheck_Toggled(Object sender, EventArgs eventArgs)
        {
            if (thursSumo1Check.IsToggled && thursSumo2Check.IsToggled && thursSumo3Check.IsToggled && thursSumo4Check.IsToggled && thursSumo5Check.IsToggled && thursSumo6Check.IsToggled && thursSumo7Check.IsToggled && thursSumo8Check.IsToggled)
            {
                thursSumoButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                thursSumoButton.BackgroundColor = Color.Black;
            }

        }

        private void thursLegPressCheck_Toggled(object sender, EventArgs eventArgs)
        {

            if (thursLegPress1Check.IsToggled && thursLegPress2Check.IsEnabled && thursLegPress3Check.IsEnabled)
            {
                thursLegPressButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                thursLegPressButton.BackgroundColor = Color.Black;

            }
        }

        private void thursHamCurlCheck_Toggled(object sender, EventArgs eventArgs)
        {

            if (thursHamCurl1Check.IsToggled && thursHamCurl2Check.IsEnabled && thursHamCurl3Check.IsEnabled)
            {
                thursHamCurlButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                thursHamCurlButton.BackgroundColor = Color.Black;

            }
        }
    }
}
