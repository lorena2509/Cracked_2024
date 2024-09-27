using System;

namespace CRACKED_2024.Utilities
{
    public class DBContextUtility
    {
        static string SERVER = "LAPTOP-NP7BDMFC";
        static string DB_NAME = "CRACKED_2024";
        static string DB_USER = "OBTEST";
        static string DB_PASSWORD = "123";

        static string Conn = "server=" + SERVER + ";database=" + DB_NAME + ";user id=" + DB_USER + ";password=" + DB_PASSWORD + ";MultipleActiveResultSets=true";
        //mi conexion:
        SqlConnection Con = new SqlConnection(Conn);

        //procedimiento que abre la conexion sqlsever
        public void Connect()
        {
            try
            {
                Con.Open();
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //procedimiento que cierra la conexion sqlserver
        public void Disconnect()
        {
            Con.Close();
        }

        //funcion que devuelve la conexion sqlserver
        public SqlConnection CONN()
        {
            return Con;
        }
    }
}