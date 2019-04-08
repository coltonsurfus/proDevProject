using System;
using System.Collections.Generic;
//using System.Data.SQLite;
using SQLite;
using Xamarin.Forms;

namespace ProDevProject
{
    public partial class ProfilePage : ContentPage
    {
        private Database db;
        public ProfilePage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.LightSlateGray;
            db = new Database();
            testLabel.Text = db.getBench() + "";

            //db.setupFirstTime();

        }


        public void ConfirmButton_Clicked(object sender, System.EventArgs e)
        {
            db.InsertCalculations(int.Parse(squatMax.Text), int.Parse(benchMax.Text), int.Parse(deadliftMax.Text), int.Parse(pressMax.Text));

            testLabel.Text = db.getBench() + "";


        }

    }
}
