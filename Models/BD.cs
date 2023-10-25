using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic; 
public static class BD{
    private static string _connectionString = @"SERVER=FEDE-GAMMER\SQLEXPRESS;DataBase=BDSeries;Trusted_Connection=True;";
    public static List<Series> ListarSeries(){
        List<Series> ListaSeries = new List<Series>();
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series";
            ListaSeries = db.Query<Series>(sql).ToList();
        }
        return ListaSeries;
    }   

    public static List<Actores> ListarActores(int IdSerie){
        List<Actores> ListaActores = new List<Actores>();
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Actores WHERE IdSerie = @cIdSerie";
            ListaActores = db.Query<Actores>(sql, new{cIdSerie = IdSerie}).ToList();
        }
        return ListaActores;
    }   

    public static List<Temporadas> ListarTemp(int IdSerie){
        List<Temporadas> ListaTemp = new List<Temporadas>();
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Temporadas WHERE IdSerie = @cIdSerie";
            ListaTemp = db.Query<Temporadas>(sql, new{cIdSerie = IdSerie}).ToList();
        }
        return ListaTemp;
    }   

    public static Series DataSerie(int IdSerie){
    Series s = null;
    using (SqlConnection db = new SqlConnection(_connectionString)){
        string sql = "SELECT * FROM Series WHERE IdSerie = @cIdSerie";
        s = db.QueryFirstOrDefault<Series>(sql, new { cIdSerie = IdSerie });
        return s;
    }
}  
}