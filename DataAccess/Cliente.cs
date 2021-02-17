using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class Cliente
    {
        SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);

        public DataTable Show()
        {
            using (SqlCommand SqlCommand = new SqlCommand("SP_SHOW_CLIENTES", Connection))
            {
                Connection.Open();
                SqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader Reader = SqlCommand.ExecuteReader();

                using (DataTable Table = new DataTable())
                {
                    Table.Load(Reader);
                    Reader.Close();
                    Connection.Close();
                    return Table;
                }
            }
        }

        public DataTable Search(Entities.Cliente Cliente, string Tipo)
        {
            using (SqlCommand SqlCommand = new SqlCommand("SP_SEARCH_CLIENTE", Connection))
            {
                Connection.Open();
                SqlCommand.CommandType = CommandType.StoredProcedure;
                SqlCommand.Parameters.AddWithValue("@tipo", Tipo);
                SqlCommand.Parameters.AddWithValue("@cliente", Cliente.Buscar);

                using (SqlDataAdapter Adapter = new SqlDataAdapter(SqlCommand))
                {
                    using (DataTable Table = new DataTable())
                    {
                        Adapter.Fill(Table);
                        Connection.Close();
                        return Table;
                    }
                }
            }
        }

        public void Add(Entities.Cliente Cliente)
        {
            using (SqlCommand SqlCommand = new SqlCommand("SP_ADD_CLIENTE", Connection))
            {
                Connection.Open();
                SqlCommand.CommandType = CommandType.StoredProcedure;
                SqlCommand.Parameters.AddWithValue("@nombre", Cliente.Nombre);
                SqlCommand.Parameters.AddWithValue("@calle", Cliente.Calle);
                SqlCommand.Parameters.AddWithValue("@numeroCalle", Cliente.NumeroCalle);
                SqlCommand.Parameters.AddWithValue("@colonia", Cliente.Colonia);
                SqlCommand.Parameters.AddWithValue("@ciudadMunicipio", Cliente.CiudadMunicipio);
                SqlCommand.Parameters.AddWithValue("@numContacto", Cliente.NumeroContacto);
                SqlCommand.Parameters.AddWithValue("@RFC", Cliente.RFC);
                SqlCommand.ExecuteNonQuery();
                Connection.Close();
            }
        }

        public void Update(Entities.Cliente Cliente)
        {
            using (SqlCommand SqlCommand = new SqlCommand("SP_UPDATE_CLIENTE", Connection))
            {
                Connection.Open();
                SqlCommand.CommandType = CommandType.StoredProcedure;
                SqlCommand.Parameters.AddWithValue("@id", Cliente.Id);
                SqlCommand.Parameters.AddWithValue("@nombre", Cliente.Nombre);
                SqlCommand.Parameters.AddWithValue("@calle", Cliente.Calle);
                SqlCommand.Parameters.AddWithValue("@numeroCalle", Cliente.NumeroCalle);
                SqlCommand.Parameters.AddWithValue("@colonia", Cliente.Colonia);
                SqlCommand.Parameters.AddWithValue("@ciudadMunicipio", Cliente.CiudadMunicipio);
                SqlCommand.Parameters.AddWithValue("@numContacto", Cliente.NumeroContacto);
                SqlCommand.Parameters.AddWithValue("@RFC", Cliente.RFC);
                SqlCommand.ExecuteNonQuery();
                Connection.Close();
            }
        }

        public void Delete(int Id)
        {
            using (SqlCommand SqlCommand = new SqlCommand("SP_DELETE_CLIENTE", Connection))
            {
                Connection.Open();
                SqlCommand.CommandType = CommandType.StoredProcedure;
                SqlCommand.Parameters.AddWithValue("@id", Id);
                SqlCommand.ExecuteNonQuery();
                Connection.Close();
            }
        }
    }
}
