using Software1_IIPA24.Dtos;
using Software1_IIPA24.Utilities;
using System.Data.SqlClient;

namespace Software1_IIPA24.Repositories
{
    public class UserReposiyoty
    {
        public bool CreateUser(UserDto user)
        {
            //int comando = 0;
            //DBContextUtility Connection = new DBContextUtility();
            //Connection.Connect();
            ////consulta SQL
            //string SQL = "INSERT INTO TEST.dbo.[USER] (id_role,id_state,name,username,password) "
            //            + "VALUES (" + user.IdRole + "," + user.IdState + ",'" + user.Name +
            //            "','" + user.Username + "','" + user.Password + "');";
            //using (SqlCommand command = new SqlCommand(SQL, Connection.CONN()))
            //{
            //    comando = command.ExecuteNonQuery();
            //}
            //Connection.Disconnect();

            //return comando;
            UserDto respuesta = new UserDto();
            try
            {
                using(CRACKEDEntities1) db = new CRACKEDEntities1())
                {
                    USER tUser = new USER
                    {
                        id_role = user.idRol,
                        id_state = user.idEstado,
                        name = user.nombre,
                        apellido = user.apellido,
                        numero = user.numeroContacto,
                        correo = user.correoElectronico,
                        password = user.contraseña

                    };
                    db.USUARIOs.Add(tUser);
                    db.SaveChanges();

                    return true;
                    //respuesta.Response=1:
                    //    respuesta.Message ="Usuario Creado Exitosamente"
                }
            }
            catch (Exception ex)
            {
                //respuesta.Response = 0:
                //respuesta.Message = "Usuario Creado Exitosamente"
                return false;
            }
        }

        public bool BuscarUsuario(string username)
        {
            bool result = false;
            string SQL = "SELECT name,username,password,id_user,id_role,id_state " +
                "FROM TEST.dbo.[USER] " +
                "WHERE username = '" + username + "';";
            DBContextUtility Connection = new DBContextUtility();
            Connection.Connect();
            using (SqlCommand command = new SqlCommand(SQL, Connection.CONN()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = true;
                    }
                }
            }
            Connection.Disconnect();

            return result;
        }

        public UserDto Login(UserDto user)
        {
            UserDto userResult = new UserDto();

            //Consulta SQL
            string SQL = "SELECT name,username,password,id_user,id_role,id_state " +
                "FROM TEST.dbo.[USER] " +
                "WHERE username = '" + user.Username + "' AND password = '" + user.Password + "';";
            DBContextUtility Connection = new DBContextUtility();
            Connection.Connect();
            using (SqlCommand command = new SqlCommand(SQL, Connection.CONN()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userResult.IdUser = reader.GetInt32(3);
                        userResult.IdRole = reader.GetInt32(4);
                        userResult.IdState = reader.GetInt32(5);
                        userResult.Name = reader.GetString(0);
                        userResult.Username = reader.GetString(1);
                        userResult.Password = reader.GetString(2);
                    }
                }
            }
            Connection.Disconnect();

            return userResult;
        }
    }
}