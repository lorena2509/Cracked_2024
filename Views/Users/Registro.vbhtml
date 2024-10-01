@Code
    ViewData("Title") = "Registro"
End Code

<h2>Registro</h2>
<form>
    <div class="form-group">
        <label for="txtUsuario">Usuario</label>
        <input type="text" class="form-control" id="txtUsuario" placeholder="Nombre de usuario o correo electronico">
        <i class="bi bi-eye-slash-fill"></i>
    </div>
    <div class="form-group">
        <label for="txtcontraseña">Contraseña</label>
        <input type="password" class="form-control" id="txtcontraseña" placeholder="contraseña">
    </div>
    <div class="form-group">
        <label for="txtcontraseña">Confirmar contraseña</label>
        <input type="password" class="form-control" id="txtConfirmarcontraseña" placeholder="Por favor confirma tu contraseña">
    </div>
    <button type="button" class="btn btn-secondary" onclick="window.location='@Url.Action("DatosGenerales", "Users")'">CONTINUAR</button>
</form>
