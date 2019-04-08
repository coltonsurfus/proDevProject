using System;
using SQLite;

namespace ProDevProject
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        // General Info
        public int ID { get; set; }

        //Settings
        public string firstTime { get; set; }

        // Weights
        public int Bench { get; set; }
        public int Squat { get; set; }
        public int Deadlift { get; set; }
        public int Press { get; set; }

    }



}

   


    



