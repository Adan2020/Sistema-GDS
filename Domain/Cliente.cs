using System.Data.SqlClient;
using System.Data;

namespace Domain
{
    public class Cliente
    {
        DataAccess.Cliente ClienteDA = new DataAccess.Cliente();
        Entities.Cliente ClienteE = new Entities.Cliente();

        public DataTable Show()
        {
            return ClienteDA.Show();
        }

        public DataTable Search(string Cliente, string Tipo)
        {
            ClienteE.Buscar = Cliente;
            return ClienteDA.Search(ClienteE, Tipo);
        }

        public void Add(Entities.Cliente Cliente)
        {
            ClienteDA.Add(Cliente);
        }

        public void Update(Entities.Cliente Cliente)
        {
            ClienteDA.Update(Cliente);
        }

        public void Delete(int Id)
        {
            ClienteDA.Delete(Id);
        }
    }
}
