using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnCreateAccount_Click(object sender, EventArgs e)
        {


        }

        public void btnSubmitRegistration_Click(object sender, EventArgs e)
        {
            UsuarioBL usuarioBL = new UsuarioBL();
            if (int.TryParse(txtDocumento.Text, out int numeroDocumento))
            {
                // Obtener el valor seleccionado del ComboBox
                string documentoSeleccionado = cboDocumento.SelectedItem != null ? cboDocumento.SelectedItem.Value : "";

                string mensaje = usuarioBL.agregarUsuario(new Usuario(
                    txtNomUsuario.Text,
                    txtContranseña.Text,
                    txtNombre.Text,
                    txtApellido.Text,
                    numeroDocumento, // Usar el número entero convertido
                    documentoSeleccionado, // Utilizar el valor seleccionado del ComboBox
                    txtCorreo.Text
                ));

                Response.Write("<script language=javascript>alert('" + mensaje + "');</script>");
                Response.Write("<script language=javascript>document.location.href = 'LoginParaAcceder.aspx';</script>");
            }
            else
            {
                // Manejar el escenario donde el texto no es un número entero válido
                Response.Write("<script language=javascript>alert('El documento debe ser un número entero.');</script>");
            }
        }
    }
}


    
