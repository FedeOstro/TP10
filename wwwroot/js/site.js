function MostrarActores(IdSerie, Nombre){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/ListaActores',
            data: {IdSerie: IdSerie},
            success:
              function(response){
                $("#NombreSerie").html(Nombre)
                console.log(response)
                let resul = ""
                response.forEach(n => {
                  resul += "<li>" + n.nombre + "</li>"
                });
                $("#resultados").html(resul);
            }
        }
    )
}

function MostrarTemporadas(IdSerie, Nombre){
  $.ajax(
      {
          type: 'POST',
          dataType: 'JSON',
          url: '/Home/ListaTemp',
          data: {IdSerie: IdSerie},
          success:
            function(response){
              $("#NombreSerie").html(Nombre)
              console.log(response)
              let resul = ""
              response.forEach(n => {
                resul += "<li>" + n.tituloTemporada + "</li>"
              });
              $("#resultados").html(resul);
            }
      }
  )
}

function MostrarSinopsis(IdSerie, Nombre){
  $.ajax(
    {
      type: 'POST',
      dataType: 'JSON',
      url: '/Home/SacarSinopsis',
      data: {IdSerie: IdSerie},
      success:
        function(response){
          console.log(response)
          $("#NombreSerie").html(Nombre)
          $("#Sinopsis").html(response)
        }
    }
  )
}