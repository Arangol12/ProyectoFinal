<%@ Page Title="" Language="C#" MasterPageFile="~/Pagina1.Master" AutoEventWireup="true" CodeBehind="FormularioPrincipal.aspx.cs" Inherits="CapaPresentacion.FormularioPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  
    <style>
        /* Estilos generales */
        .form-container {
            width: 200px;
            margin: 0 auto;
            background-color: aqua;
            border: 2px solid #000000;
            border-radius: 10px;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
    </style>

    <!-- Formulario de cuenta -->
    <div class="form-container">
        <h3>Cuenta</h3>
        
        <div class="form-group">
           
            
        </div>
        <div class="form-group">
            <label for="txtContraseña">Contraseña</label>
            <input type="password" id="txtContraseña" class="form-control" placeholder="Contraseña">
        </div>
        <!-- Agregar botón para enviar el formulario de cuenta -->
        <button id="btnEnviarCuenta" class="btn btn-primary">Enviar</button>
    </div>

    <!-- Formulario de registro de docentes -->
    <div class="form-container">
        <h3>Registro de Docentes</h3>
        <!-- Agregar campos para el formulario de registro de docentes -->
        <!-- Ejemplo: nombre, apellido, tipo de documento, etc. -->
        <div class="form-group">
            <label for="txtNombre">Nombre</label>
            <input type="text" id="txtNombre" class="form-control" placeholder="Nombre">
        </div>
        <div class="form-group">
            <label for="txtApellido">Apellido</label>
            <input type="text" id="txtApellido" class="form-control" placeholder="Apellido">
        </div>
        <!-- Otros campos para el registro de docentes -->
        <!-- ... -->
        <!-- Agregar botón para enviar el formulario de registro de docentes -->
        <button id="btnEnviarRegistroDocentes" class="btn btn-primary">Enviar</button>
    </div>

    <!-- Navbar -->
    <div class="login container-5">
        <div>
            <!-- Navbar existente -->
            <!-- ... -->
        </div>
    </div>


</asp:Content>
