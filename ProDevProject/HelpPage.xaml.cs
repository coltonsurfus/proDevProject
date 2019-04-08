using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ProDevProject
{
    public partial class HelpPage : ContentPage
    {
        public HelpPage()
        {
            InitializeComponent();
            Database db = new Database();
            this.BackgroundColor = Color.LightSlateGray;
            testLabel.Text = db.getBench() + "";

        }
    }
}
