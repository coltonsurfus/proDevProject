using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProDevProject
{
    public partial class MainPage : ContentPage
    {



        void Profile_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("CLICKED!!!");
            Navigation.PushAsync(new ProfilePage());
        }

        void Monday_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("CLICKED!!!");
            Navigation.PushAsync(new MondayPage());
        }

        void Tuesday_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("CLICKED!!!");
            Navigation.PushAsync(new TuesdayPage());
        }

        void Wednesday_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("CLICKED!!!");
            Navigation.PushAsync(new WednesdayPage());
        }

        void Thursday_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("CLICKED!!!");
            Navigation.PushAsync(new ThursdayPage());
        }

        void Friday_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("CLICKED!!!");
            Navigation.PushAsync(new FridayPage());
        }

        void Saturday_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("CLICKED!!!");
            Navigation.PushAsync(new SaturdayPage());
        }
        void Help_Clicked(object sender, System.EventArgs e)
        {
                Navigation.PushAsync(new HelpPage());
        }




        public MainPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.LightSlateGray;
        }
    }
}
