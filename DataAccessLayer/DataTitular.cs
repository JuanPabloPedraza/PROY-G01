using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataTitular : DataAccess
    {
        public int SaveTitular(Titular _titular)
        {
            int resultado = -1;

            string query = @"insert into Titular (Apellido,
                                                  Nombre,
                                                  CUIL,
                                                  DNI,
                                                  Contacto,
                                                  ContactoAlternativo,
                                                  Correo,
                                                  Adicional) values (@Apellido,
                                                  @Nombre,
                                                  @CUIL,
                                                  @DNI,
                                                  @Contacto,
                                                  @contactoAlternativo,
                                                  @correo,
                                                  @Adicional)"
            ;

            SqlParameter apellido = new SqlParameter("@Apellido", _titular.Apellido);
            SqlParameter nombre = new SqlParameter("@Nombre", _titular.Nombre);
            SqlParameter cUIL = new SqlParameter("@CUIL", _titular.CUIL);
            SqlParameter dNI = new SqlParameter("@DNI", _titular.DNI);
            SqlParameter contacto = new SqlParameter("@Contacto", _titular.Contacto);
            SqlParameter contactoAlternativo = new SqlParameter("@contactoAlternativo", _titular.ContactoAlternativo);
            SqlParameter correo = new SqlParameter("@correo", _titular.Correo);
            SqlParameter adicional = new SqlParameter("@Adicional", _titular.Adicional);

            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.Add(apellido);
            cmd.Parameters.Add(nombre);
            cmd.Parameters.Add(cUIL);
            cmd.Parameters.Add(dNI);
            cmd.Parameters.Add(contacto);
            cmd.Parameters.Add(contactoAlternativo);
            cmd.Parameters.Add(correo);
            cmd.Parameters.Add(adicional);

            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return resultado;
        }
    }
}