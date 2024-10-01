
@Code
    ViewData("Title") = "DatosGenerales"
End Code

<h2>Ingresa tus datos</h2>
<form class="row g-3">
    <div class="col-md-6">
        <label for="inputEmail4" class="form-label">Email</label>
        <input type="email" class="form-control" id="inputEmail4">
    </div>
    <div class="col-12">
        <label for="inputAddress" class="form-label">Nombre</label>
        <input type="text" class="form-control" id="txtNombre" placeholder="Escriba su nombre completo">
    </div>
    <div class="col-12">
        <label for="inputAddress2" class="form-label">Apellido</label>
        <input type="text" class="form-control" id="inputAddress2" placeholder="Apartment, studio, or floor">
    </div>
    <div class="col-md-6">
        <label for="inputCity" class="form-label">Celular</label>
        <input type="text" class="form-control" id="inputCity">
    </div>
    <div class="col-12">
        <div class="form-check">
            <input class="form-check-input" type="checkbox" id="gridCheck">
            <label class="form-check-label" for="gridCheck">
             Acepto el tratamiento de datos
            </label>
        </div>
    </div>
    <div class="col-12">
        <button type="submit" class="btn btn-primary">Registrarme</button>
    </div>
</form>


