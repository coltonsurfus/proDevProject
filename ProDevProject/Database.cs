using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SQLite;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProDevProject
{
    class Database
    {
        private SQLiteConnection db;

        // Creates the database
        public Database()
        {
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            String path = Path.Combine(folder, "myworkout.db");

            db = new SQLiteConnection(path);

            //TABLES
            db.CreateTable<User>();
        }

        public void setupFirstTime()
        {
            var setUser = new User
            {
                //ID = 0,
                firstTime = "Yes",
                Squat = 0,
                Bench = 0,
                Deadlift = 0,
                Press = 0
            };
            db.Insert(setUser);
        }

        public void updateFirstTime()
        {
            db.Execute("UPDATE User SET firstTime = ?", "No");
            System.Diagnostics.Debug.WriteLine("Updated First Time");
        }
        //Get Methods
        public string getFirstTime()
        {
            var user = db.Query<User>("SELECT * from User");
            return user[0].firstTime;
        }

        public int getSquat()
        {
            var user = db.Query<User>("SELECT * from User");
            return user[0].Squat;
        }

        public int getBench()
        {
            var user = db.Query<User>("SELECT * from User");
            return user[0].Bench;
        }
        public int getDeadlift()
        {
            var user = db.Query<User>("SELECT * from User");
            return user[0].Deadlift;
        }
        public int getPress()
        {
            var user = db.Query<User>("SELECT * from User");
            return user[0].Press;
        }

        public void InsertCalculations(int SquatMax, int BenchMax, int DeadliftMax, int PressMax)
        {
            db.Execute("UPDATE User SET Squat = ?, Bench = ?, Deadlift = ?, Press = ?", SquatMax, BenchMax, DeadliftMax, PressMax);
        }



    }
}
