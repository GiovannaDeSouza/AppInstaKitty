using AppInstaKitty.Model;
using SQLite;

namespace AppInstaKitty.Data
{
    public class SQLiteData
    {
        readonly SQLiteAsyncConnection _conexaoDb;

        public UserData UserDataTable { get; set; } 
        public SQLiteData(string path)
        {
            _conexaoDb = new SQLiteAsyncConnection(path);
            _conexaoDb.CreateTableAsync<Usuario>().Wait();

            UserDataTable = new UserData(_conexaoDb);
        }
    }
}
