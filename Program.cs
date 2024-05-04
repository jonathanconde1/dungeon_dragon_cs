namespace dungeon_dragon_cs;
using System;
using Npgsql;

class Program
{
    static void Main(string[] args){
        Console.WriteLine("hola mundo");
         string connectionString = "Host=localhost;Port=5432;Database=dnd;Username=dnd;Password=dungeon;";

        using var connection = new NpgsqlConnection(connectionString);
        connection.Open();

        Console.WriteLine("Conexión exitosa a PostgreSQL");

        // Realiza aquí tus operaciones en la base de datos

        connection.Close();

    }
}
