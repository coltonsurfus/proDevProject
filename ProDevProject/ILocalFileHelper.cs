using System;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using SQLite;

namespace ProDevProject
{
    public interface ILocalFileHelper
    {
        SQLiteConnection GetConnection();
    }
}
