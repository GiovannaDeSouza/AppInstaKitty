using AppInstaKitty.Model;
using SQLite;

namespace AppInstaKitty.Data
{
    public class UserData
    {
        private SQLiteAsyncConnection _conexaoDb;

        public UserData(SQLiteAsyncConnection conexaoDb)
        {
            _conexaoDb = conexaoDb;
        }

        public Task<List<Usuario>> GetUsuariosAsync()
        {
            var Lista = _conexaoDb
                .Table<Usuario>()
                .ToListAsync();
            return Lista;
        }

        public Task<Usuario> GetUsuarioAsync(string email, string senha)
        {
            var usuario = _conexaoDb.Table<Usuario>().Where(u => u.Email == email && u.Senha == senha).FirstOrDefaultAsync();
            return usuario;
        }

        public Task<Usuario> GetUserId(Guid id)
        {
            var usuario = _conexaoDb.Table<Usuario>().Where(u => u.Id == id).FirstOrDefaultAsync();
            return usuario;
        }

        public async Task<int> SalvarUsuario(Usuario usuario)
        {
            var novoUsuario = await GetUserId(usuario.Id);
            if (novoUsuario == null)
            {
                return await _conexaoDb.InsertAsync(usuario);
            }
            else
            {
                return await _conexaoDb.UpdateAsync(usuario);
            }
        }

        public async Task<int> DeletarUser(Usuario usuario)
        {
            var novoUsuario = await GetUserId(usuario.Id);
            if (novoUsuario == null)
            {
                throw new Exception("Usuário não pode ser encontrado");
            }
            else
            {
                return await _conexaoDb.DeleteAsync(usuario);
            }
        }
    }
}