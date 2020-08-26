
    $.ajax({
        type: "POST",
        url: "/Querys/ListarProductos",
        success: function (resultado) {
            console.log(resultado);
            var plantilla = '';

            resultado.forEach(valor => {

                plantilla += ` 
         <div class="col-3 mb-4">
            <div class="card border-0 shadow">
                <img src="https://image.freepik.com/free-photo/close-up-body-butter-recipient_23-2148543042.jpg" class="card-img-top" alt="...">
                <div class="card-body">
                    <div class="row">
                        <div class="col-7">
                            <h6 class="card-title">${valor.NOMBRE}</h6>
                        </div>
                        <div class="col-5">
                            <h5 class="text-right" style="color: lightseagreen">$${valor.PRECIO}</h5>
                        </div>
                    </div>
                    <p class="card-text">${valor.DESCRIPCION}</p>
                    <button type="button" class="btn btn-primary btn-block add-cart" onClick="AddToCart(this)" codigo="${valor.COD_PRODUCTO}">Agregar al carrito</button>
                </div>
            </div>
        </div>
                `
            });

            $("#contenedor-productos").html(plantilla);

        },
        error: function (xhr) {

            console.log(xhr.responseText);
            alert("Error has occurred..");
        }
    });

function AddToCart(e) {

    var id = e.getAttribute("codigo");



}
