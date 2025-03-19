using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


    public class ConexionMySql
    {

        public MySqlConnection Connection;

        private String cadenaConexion;
        public ConexionMySql()
        {

            cadenaConexion = "Database=tiendabicis; Datasource=localhost; User Id=root;Password=";
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if (Connection.State != System.Data.ConnectionState.Open)
                {
                    Connection.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Connection;
        }
    }

