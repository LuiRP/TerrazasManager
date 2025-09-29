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
            _connection.CreateTableAsync<Operativo>();
        }

        //Casa DB methods

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

        //Operativos DB methods

        public async Task<List<Operativo>> GetOperativos()
        {
            return await _connection.Table<Operativo>().ToListAsync();
        }

        public async Task<Operativo> GetOperativoById(int id)
        {
            return await _connection.Table<Operativo>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateOperativo(Operativo operativo)
        {
            await _connection.InsertAsync(operativo);
        }

        public async Task UpdateOperativo(Operativo operativo)
        {
            await _connection.UpdateAsync(operativo);
        }

        public async Task DeleteOperativo(Operativo operativo)
        {
            await _connection.DeleteAsync(operativo);
        }

        //OperativosElementos DB methods

        public async Task<List<OperativoElementos>> GetOperativoElementos()
        {
            return await _connection.Table<OperativoElementos>().ToListAsync();
        }

        public async Task<OperativoElementos> GetOperativoElementosById(int id)
        {
            return await _connection.Table<OperativoElementos>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateOperativoElementos(OperativoElementos operativoelementos)
        {
            await _connection.InsertAsync(operativoelementos);
        }

        public async Task DeleteOperativoElementos(OperativoElementos operativoelementos)
        {
            await _connection.DeleteAsync(operativoelementos);
        }

    }
}
