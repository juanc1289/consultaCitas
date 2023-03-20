using Npgsql;
using System.Data;

namespace consultaCitas.Clases
{
    public class CConnection
    {

        private const string TABLE_NAME = "agenda";

        String cadenaConexion = "Server=192.168.2.2;Port=5433;Database=sihos_comuneros;User Id=postgres;Password=POSTGRES";
        NpgsqlConnection vCon;
        NpgsqlCommand vCmd;

        public void conex()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = cadenaConexion;
            if (vCon.State == ConnectionState.Closed)
            {
                vCon.Open();
            }

        }

        public string GetDatata(string sql)
        {

            conex();
            vCmd = new NpgsqlCommand();
            vCmd.Connection = vCon;
            vCmd.CommandText = sql;
            string a = "Por favor seleccione una de las siguietnes opciones: \x0A";
            int b = 0;

            NpgsqlDataReader reader = vCmd.ExecuteReader();
            while (reader.Read())
            {

                b++;
                a = a + b.ToString() + ". " + reader.GetDateTime(1) + " \x0A";
            }
            return a;

        }

    }
}
