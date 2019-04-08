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



        /*
        readonly SQLiteAsyncConnection database;
        
        public Database(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
            setup();
           
        }

        public Task<List<User>> getUsers()
        {
            return database.Table<User>().ToListAsync();
        }
        /*
        public Task<int> saveUser(User user)
        {
            
            if (user.Squat != 0) // If user is not new, it will be 0
            {
                return database.UpdateAsync(user); // Inserts user
            }
            else // If User is new
            {
                return database.InsertAsync(user); // Inserts user
            }
        }


        // Uncomment 
        public Task <int> updateUser(User user)
        {
            return database.UpdateAsync(user);
        }

        public Task<int> DeleteUser(User user)
        {
            return database.DeleteAsync(user);
        }

      

        public async Task<List<int>> getSquat()
        {
            var use = await database.QueryAsync<int>("SELECT Squat FROM User");
            return use;
    
        }

        public List<int> GSquat()
        {
            var use = database.QueryAsync<int>("SELECT Squat From User").Result;
            return use;

        }



        public void setup()
        {
            var setUser = new User
            {
                Bench = 0,
                Squat = 0,
                Deadlift = 0,
                Press = 0,

            };
            database.InsertAsync(setUser);
            Debug.WriteLine(database.QueryAsync<int>("SELECT squat FROM User"));
        }





        //private SQLiteConnection db;
        /* 
         *SQLiteConnection.CreateFile("MyDatabase.sqlite");
        SQLiteConnection m_dbConnection;
        m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
        m_dbConnection.Open();
        // Create the table

        String sql = "create table max (name varchar(20), weight int)";
        SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
        command.ExecuteNonQuery();

        //Squat
        sql = "insert into max (name, weight) values ('Squat', 0)";
        command = new SQLiteCommand(sql, m_dbConnection);
        command.ExecuteNonQuery();

        //Bench
        sql = "insert into max (name, weight) values ('Bench', 0)";
        command = new SQLiteCommand(sql, m_dbConnection);
        command.ExecuteNonQuery();

        //Deadlift
        sql = "insert into max(name, weight) values ('Deadlift', 0)";
        command = new SQLiteCommand(sql, m_dbConnection);
        command.ExecuteNonQuery();

        //Press
        sql = "insert into max (name, weight) values ('Press', 0)";
        command = new SQLiteCommand(sql, m_dbConnection);
        command.ExecuteNonQuery();
        m_dbConnection.Close();


        command = new SQLiteCommand(sql, m_dbConnection);
        SQLiteDataReader reader = command.ExecuteReader();
        while (reader.Read())
            Console.WriteLine(reader["name"] + "" + reader["weight"]);
    }







    public void setupFirstTime()
    {
        var setPerson = new User
        {
            squatMax = 0,
            benchMax = 0,
            deadliftMax = 0,
            pressMax = 0

        };
        db.Insert(setPerson);
    }








    // Gets users data
    public int getSquatMax()
    {
        var us = db.Query<User>("SELECT * FROM Person");
        return us[0].squatMax;
    }

    public int getBenchMax()
    {
        var us = db.Query<User>("SELECT * FROM Person");
        return us[0].benchMax;
    }

    public int getDeadliftMax()
    {
        var us = db.Query<User>("SELECT * FROM Person");
        return us[0].deadLiftMax;
    }
    public int getPressMax()
    {
        var us = db.Query<User>("SELECT * FROM Person");
        return us[0].pressMax;
    }
    // End of Gets users data

    */


    }
}
