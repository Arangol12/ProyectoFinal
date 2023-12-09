using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {

        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string tipoDocumento { get; set; }
        public string correoElectronico { get; set; }

        public Usuario(int idUsuario, string nombreUsuario, string contraseña, string nombre, string apellido, int dni, string tipoDocumento, string correoElectronico)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.tipoDocumento = tipoDocumento;
            this.correoElectronico = correoElectronico;
        }

        public Usuario()
        {
        }

        public Usuario(string nombreUsuario, string contraseña, string nombre, string apellido, int dni, string tipoDocumento, string correoElectronico)
        {
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.tipoDocumento = tipoDocumento;
            this.correoElectronico = correoElectronico;
        }
    }

}

    