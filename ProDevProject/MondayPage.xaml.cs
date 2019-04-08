using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProDevProject
{
    public partial class MondayPage : ContentPage
    {
        public MondayPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.LightSlateGray;

            mondayBp9Check.Toggled += mondayBenchCheck_Toggled;
            mondayP8Check.Toggled += mondayPressCheck_Toggled;
            mondayDb3Check.Toggled += mondayDbBenchCheck_Toggled;
            mondayDbrow3Check.Toggled += mondayDbRowCheck_Toggled;


        }

        private void mondayBenchCheck_Toggled(Object sender, EventArgs eventArgs)
        {
            if (mondayBp1Check.IsToggled && mondayBp2Check.IsToggled && mondayBp3Check.IsToggled && mondayBp4Check.IsToggled && mondayBp5Check.IsToggled && mondayBp6Check.IsToggled && mondayBp7Check.IsToggled && mondayBp8Check.IsToggled && mondayBp9Check.IsToggled)
            {
                mondayBenchButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                mondayBenchButton.BackgroundColor = Color.Black;
            }

        }


        private void mondayPressCheck_Toggled(Object sender, EventArgs eventArgs)
        {
            if (mondayP1Check.IsToggled && mondayP2Check.IsToggled && mondayP3Check.IsToggled && mondayP4Check.IsToggled && mondayP5Check.IsToggled && mondayP6Check.IsToggled && mondayP7Check.IsToggled && mondayP8Check.IsToggled)
            {
                mondayPressButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                mondayPressButton.BackgroundColor = Color.Black;
            }

        }

        private void mondayDbBenchCheck_Toggled(object sender, EventArgs eventArgs)
        {

            if (mondayDb1Check.IsToggled && mondayDb2Check.IsEnabled && mondayDb3Check.IsEnabled)
            {
                mondayDbBenchButton.BackgroundColor = Color.DarkBlue;
            }

            else
            {
                mondayDbBenchButton.BackgroundColor = Color.Black;

            }
        }

            private void mondayDbRowCheck_Toggled(object sender, EventArgs eventArgs)
            {

                if (mondayDbRow1Check.IsToggled && mondayDbRow2Check.IsEnabled && mondayDbrow3Check.IsEnabled)
                {
                    mondayDbRowButton.BackgroundColor = Color.DarkBlue;
                }

                else
                {
                    mondayDbRowButton.BackgroundColor = Color.Black;

                }
            }

        }
    }
