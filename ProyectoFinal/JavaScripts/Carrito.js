var hoy = new Date();
$("#fechaVenta").html(hoy.getDate() + "/" + (hoy.getMonth() + 1) + "/" + hoy.getFullYear());


$.ajax({
    type: "POST",
    url: "/Querys/ListarCarrito",
    success: function (resultado) {
        console.log(resultado);
        var plantilla = '';

        resultado.forEach(valor => {

            plantilla += ` 
                <tr>
                    <th scope="row"><img src="${valor.IMAGEN}" alt="Alternate Text" width="60px" height="70px" /></th>
                    <td><i class="zmdi zmdi-close-circle text-danger" codigo="${valor.COD_PRODUCTO}"></i></td>
                    <td>${valor.NOMBRE}</td>
                    <td>${valor.DESCRIPCION}</td>
                    <td>${valor.PRECIO}</td>
                    <td>
                        1
                    </td>
                </tr>
                `
        });

        $("#cuerpo-carrito").html(plantilla);

    },
    error: function (xhr) {

        console.log(xhr.responseText);
        alert("Error has occurred..");
    }
});