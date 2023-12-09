using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
namespace CapaDatos
{
    public class UsuarioDAL
    {
        public string agregarUsuario(Usuario unusuario)
        {
            string r = "";

            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_agregar_Usuario_Docente";
                    cmd.Parameters.AddWithValue("@nombreUsuario", unusuario.nombreUsuario);
                    cmd.Parameters.AddWithValue("@contraseña", unusuario.contraseña);
                    cmd.Parameters.AddWithValue("@nombre", unusuario.nombre);
                    cmd.Parameters.AddWithValue("@apellido", unusuario.apellido);
                    cmd.Parameters.AddWithValue("@dni", unusuario.dni);
                    cmd.Parameters.AddWithValue("@tipoDocumento", unusuario.tipoDocumento);
                    cmd.Parameters.AddWithValue("@correoElectronico", unusuario.correoElectronico);
                    cn.Open();
                    int f = cmd.ExecuteNonQuery();
                    if (f > 0)
                    {
                        r = "registro agregado";
                    }
                    cn.Close();


                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();
                }
                return r;
            }
            
        }
        public List<Usuario> ListarUsurio()
        {
            List<Usuario> ousurio = new List<Usuario>();
            using (SqlConnection cn = new ConexionBD().conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_Listar_Usuario";
                    cn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ousurio.Add(new Usuario(int.Parse(reader[0].ToString()),
                                reader[1].ToString(), reader[2].ToString(), reader[3].ToString()
                                , reader[4].ToString(), int.Parse(reader[5].ToString()), reader[6].ToString(),
                                reader[7].ToString()));
                        }
                    }
                    cn.Close();

                }catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cn.Dispose();

                }
                return ousurio;
            }
        }

    }
}
