using System;
using System.IO;
using Xamarin.Forms;
using ProDevProject;
using SQLite;

[assembly: Dependency(typeof(LocalFileHelper))]
namespace ProDevProject
{
    public class LocalFileHelper : ILocalFileHelper
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "mydatabase.sqlite";
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbName, dbPath);
            var conn = new SQLiteConnection(path);
            return conn;
        }


        /*
       public string GetLocalFilePath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, fileName);
        }
        */
    }
}
