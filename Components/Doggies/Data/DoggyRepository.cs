using CommunityToolkit.Maui.Core.Extensions;
using MyDoggyDetails.Components.Base;
using MyDoggyDetails.Models;
using SQLite;
using System.Collections.ObjectModel;

namespace MyDoggyDetails.Data
{
    public class DoggyRepository
    {
        private readonly SQLiteConnection conn;
        public static string dbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Constants.DatabaseFileName);
        public DoggyRepository()
        {
            conn = new SQLiteConnection(dbPath);
            //conn.CreateTable<DoggyTableModel>();
        }

        public ObservableCollection<DoggyTableModel> SelectAll()
        {
            var results = conn.Table<DoggyTableModel>().ToObservableCollection();
            //var results = conn.Query<DoggyTableModel>("select * from MyDoggies").ToObservableCollection();

            return results;
        }

    }
}
