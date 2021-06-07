using MySql.Data.MySqlClient;

using Read_Libros_Bot.Funciones;
using System;
using System.IO;
using System.Threading.Tasks;
using Telegram.Bot;




namespace Read_Libros_Bot
{
    class Program
    {
        // public static async Task Main()
        public static async Task Main(string[] args)
        {
             await new Escuchar().IniciarTelegram();

           

        }

    }
}
