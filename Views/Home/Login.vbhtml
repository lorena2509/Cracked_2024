@Code
    ViewData("Title") = "Login"
End Code

<h2>Iniciar Sesion</h2>

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
    <button type="submit" class="btn btn-primary">Continuar</button>
    <p class="fst-italic">¿Aún no haces parte de nuestros clientes?</p>
    <p class="fst-italic">¡Registrate Ahora!</p>
    <button type="submit" class="btn btn-primary">REGISTRARSE</button>
</form>