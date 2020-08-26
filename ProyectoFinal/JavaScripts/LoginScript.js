
function IniciarSesion() {

    var Usuario = document.getElementById("usuario").value;
    var Contrasena = document.getElementById("contrasena").value;

    $.ajax({

        type: "POST",
        url: "/Login/Autenticar",
        data:
        {
            Usuario: Usuario,
            Contrasena: Contrasena
        },
        cache: false,
        success: function (data) {
            if(data=="Si")
                window.location.href = "/Principal/PantallaPrincipal";
            else
                swal("¡Error!", "¡Usuario o contraseña incorrectos!", "error");
        },
        error: function (data) {
            if (data == "Si")
                window.location.href = "/Principal/PantallaPrincipal";
            else
                swal("¡Error!", "¡Usuario o contraseña incorrectos!", "error");
            
        }

    });

}