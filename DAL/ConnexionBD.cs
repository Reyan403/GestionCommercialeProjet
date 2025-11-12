using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ConnexionBD
    {
        private SqlConnection maConnexion;
        private static ConnexionBD uneConnexionBD;
        private string chaineConnexion;

        public string GetchaineConnexion() => chaineConnexion;
        public void SetchaineConnexion(string ch) => chaineConnexion = ch;

        public static ConnexionBD GetConnexionBD()
        {
            if (uneConnexionBD == null)
                uneConnexionBD = new ConnexionBD();
            return uneConnexionBD;
        }

        private ConnexionBD() { }

        public SqlConnection GetSqlConnexion()
        {
            if (maConnexion == null)
                maConnexion = new SqlConnection();

            maConnexion.ConnectionString = chaineConnexion;

            if (maConnexion.State == System.Data.ConnectionState.Closed)
                maConnexion.Open();

            return maConnexion;
        }

        public void CloseConnexion()
        {
            if (maConnexion != null && maConnexion.State != System.Data.ConnectionState.Closed)
                maConnexion.Close();
        }
    }
}
