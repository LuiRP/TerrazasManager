using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerrazasManager.Db.Models;

namespace TerrazasManager.Db
{
    public class LocalDbService
    {
        private const string DB_NAME = "terrazas_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Casa>();
        }

        public async Task<List<Casa>> GetCasas()
        {
            return await _connection.Table<Casa>().ToListAsync();
        }

        public async Task<Casa> GetCasaById(int id)
        {
            return await _connection.Table<Casa>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateCasa(Casa casa)
        {
            await _connection.InsertAsync(casa);
        }

        public async Task UpdateCasa(Casa casa)
        {
            await _connection.UpdateAsync(casa);
        }

        public async Task DeleteCasa(Casa casa)
        {
            await _connection.DeleteAsync(casa);
        }
    }
}
