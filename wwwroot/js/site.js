function MostrarActores(IdSerie, Nombre){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/ListaActores',
            data: {IdSerie: IdSerie},
            succes:
              function(response){
                $("#NombreSerie").html(Nombre)
                
              }
        }
    )
}