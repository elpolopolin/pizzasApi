using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Dapper;
using System;
using Pizzas.API.Models;
using Microsoft.VisualBasic.CompilerServices;
using System.Data;
using System.Dynamic;
namespace Pizzas.Api.Utils;
using System.Net;

public static class BD
{
   

      private static string server = Dns.GetHostName();
        private static string CONNECTION_STRING = @$"Server={server};DataBase=DAI-Pizzas;Trusted_Connection=True;";       
    public static List<Pizza> GetAll()
    {
        string sqlQuery;
        List<Pizza> returnList;

        returnList = new List<Pizza>();
        using (SqlConnection db = new SqlConnection(CONNECTION_STRING)) {
        sqlQuery = "SELECT Id, Nombre, LibreGluten, Importe, Descripcion FROM Pizzas";
        returnList = db.Query<Pizza>(sqlQuery).ToList(); 
        }
        return returnList;
     }

        public static Pizza GetById(int id) {
        string  sqlQuery;
        Pizza   returnEntity = null;
        sqlQuery  = "SELECT Id, Nombre, LibreGluten, Importe, Descripcion FROM Pizzas ";
        sqlQuery += "WHERE Id = @idPizza";
        using (SqlConnection db = new SqlConnection(CONNECTION_STRING)) {
        returnEntity  = db.QueryFirstOrDefault<Pizza>(sqlQuery, new { idPizza = id });
        } 
       return returnEntity; }


       public static int Insert(Pizza pizza) {
        string  sqlQuery;
        int    intRowsAffected = 0;
        sqlQuery  = "INSERT INTO Pizzas (";
        sqlQuery += "   Nombre  , LibreGluten   , Importe   , Descripcion";
        sqlQuery += ") VALUES(";
        sqlQuery += "   @nombre , @libreGluten  , @importe  , @descripcion";
        sqlQuery += ")";   
        using (SqlConnection db = new SqlConnection(CONNECTION_STRING)) {
        intRowsAffected = db.Execute(sqlQuery, new { 
        nombre  = pizza.Nombre, libreGluten = pizza.LibreGluten, importe  = pizza.Importe, descripcion = pizza.Descripcion   });
        } 
         return intRowsAffected;
       }

       public static int UpdateById(Pizza pizza){
        string sqlQuery;
        int intRowsAffected = 0;
        
        sqlQuery = "UPDATE Pizzas SET";
        sqlQuery += " Nombre = @nombre, ";
        sqlQuery += "    LibreGluten    = @libreGluten, ";
        sqlQuery += "    Importe        = @importe, ";
        sqlQuery += "    Descripcion    = @descripcion ";
         sqlQuery += "WHERE Id = @idPizza";
          using (var db = new SqlConnection(CONNECTION_STRING)) {
            intRowsAffected = db.Execute(sqlQuery, new { idPizza = pizza.Id, nombre = pizza.Nombre, libreGluten = pizza.LibreGluten, importe  = pizza.Importe, descripcion = pizza.Descripcion });
          }
          return intRowsAffected;
       }

       public static int DeleteById(int id) {
        string sqlQuery;
        int    intRowsAffected = 0;

        sqlQuery = "DELETE FROM Pizzas WHERE Id = @idPizza";
        using (SqlConnection db = new SqlConnection(CONNECTION_STRING)) {
            intRowsAffected = db.Execute(sqlQuery, new{ idPizza = id});
        }
        return intRowsAffected;
       }



    }

    

    

    
    

