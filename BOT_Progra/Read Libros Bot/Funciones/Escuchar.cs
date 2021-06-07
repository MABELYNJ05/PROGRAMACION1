
using Read_Libros_Bot.ContenidoTelegram;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Read_Libros_Bot.BasesDatosuwu;
using Telegram.Bot.Types;
using System.Data;

namespace Read_Libros_Bot.Funciones
{
    class Escuchar
    {
        private static TelegramBotClient Bot;

        private String TokenBot = "1770812733:AAGfq5KhLRkjGodJA9OQaa-wW2FG9eDmOaI";

        string[] todos = Directory.GetFiles(@"C:\Users\alumno\Desktop\Libros");//listar los archivos del directorio

        public async Task IniciarTelegram()
        {
            Bot = new TelegramBotClient(TokenBot);

            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            var me = await Bot.GetMeAsync();
            Console.Title = me.Username;

            Bot.OnMessage += BotCuandoRecibeMensajes;
            Bot.OnMessageEdited += BotCuandoRecibeMensajes;
            Bot.OnReceiveError += BotOnReceiveError;

            Bot.StartReceiving(Array.Empty<UpdateType>());
            Console.WriteLine($"escuchando solicitudes del BOT @{me.Username}");



            Console.ReadLine();
            Bot.StopReceiving();


        }


        private async void BotCuandoRecibeMensajes(object sender, MessageEventArgs messageEventArgumentos)
        {
            var ObjetoMensajeTelegram = messageEventArgumentos;
            var mensajes = ObjetoMensajeTelegram.Message;
            string mensajeEntrante;
            try { mensajeEntrante = mensajes.Text.ToString(); }
            catch
            {
                mensajeEntrante = null;
            }
           
            string Telegram_id_manda_mensaje = mensajes.Chat.Id.ToString();
            string respuesta = " ";



            // si el mensaje viene nulo, lo retorna
            if (mensajes.Text == null)
            {
                return;
            }

            Console.WriteLine($"Recibiendo Mensaje del ID {Telegram_id_manda_mensaje}.");
            Console.WriteLine($"Dice {mensajeEntrante}.");

            clsConexion my = new clsConexion();
            if (mensajeEntrante=="/start")
            {
                
                    respuesta = "Hola te doy la bienvenida a Read Libros Bot"+mdEmojis.saludo+"\n";
                    respuesta += "Para poder empezar a usar este bot debes de escribir un apodo como tu alias y así poder ser parte de nuestro ";
                    respuesta += "grupo de amantes a la lectura"+mdEmojis.libros+"Para ello debes de seguir el siguiente formato: Apodo (Tu apodo)";    
                    await EnviarSticker("https://tlgrm.es/_/stickers/d78/27e/d7827ec3-d2ac-490b-8a72-87980b11b079/192/4.webp", ObjetoMensajeTelegram);

                


            }

            

            else if (mensajeEntrante.Contains("Apodo"))
            {
                string apodo = mensajeEntrante.ToString();
                int parte = apodo.IndexOf(' ');
                string apodoUsu = apodo.Substring(parte,apodo.Length-parte);
                DataTable tb = my.consultaTablaDirecta("insert into db_datos.tb_usutelegram values('" + Telegram_id_manda_mensaje + "','" + apodoUsu + "')");
                respuesta = "¡Felicidades, ya formas parte de nuestro equipo!, para empezar escribe lo siguiente:\n";
                respuesta += "\n/comandos" + " " + mdEmojis.robot;
                await EnviarSticker("https://tlgrm.es/_/stickers/3c5/676/3c5676e7-a0d9-4ca9-a167-228e34731971/96/14.webp", ObjetoMensajeTelegram);

            }


            else if (mensajeEntrante==("/comandos"))
            {
                respuesta = "Seleccione la opcion deseada \n";
                respuesta += "/libros\n";
                respuesta += "/juegos\n";
                respuesta += "/amigos";
                await EnviarSticker("https://tlgrm.es/_/stickers/3c5/676/3c5676e7-a0d9-4ca9-a167-228e34731971/96/14.webp", ObjetoMensajeTelegram);

            }

            if (mensajeEntrante == ("/amigos"))
            {
                respuesta += "LISTADO DE MIEMBROS DE READ LIBROS BOT"+mdEmojis.libros+"\n";
                DataTable tb = my.consultaTablaDirecta("select Nombre from tb_usutelegram;");
                foreach(DataRow x in tb.Rows)
                {
                    int i = 1;
                    respuesta+= (""+i+")    "+x[0].ToString()+"\n");
                    i++;
                }
            }

            else if (mensajeEntrante == ("/juegos"))
            {
                respuesta += "Diviertete jugando"+mdEmojis.sonrisa;
                respuesta = "https://t.me/gamee?game=MotoFX";
            }


             
            if (mensajeEntrante==("/libros"))
            {
                respuesta = "PARA PODER ADQUIRIR UNO DE ESTOS LIBROS SOLO TINES QUE ENVIAR LA PALABRA 'Libro' Y EL NUMERO DEL LIBRO QUE DESEAS\n";
                respuesta += "Ejemplo: Libro1 \n\n";
                try
                {
                    for (int i = 0; i < todos.Length; i++) //arreglo de libros
                    {
                        int indice = todos[i].IndexOf("1");
                        indice += 2;
                        string trozo = todos[i].Substring(indice, todos[i].Length - indice);
                        i++;
                        respuesta += i + ". " + trozo + "\n";
                        i--;
                    }
                }
                catch
                {
                    respuesta = "Ha Habido Un Error En El Analisis De Archivos";
                }
                await EnviarSticker("https://tlgrm.es/_/stickers/d78/27e/d7827ec3-d2ac-490b-8a72-87980b11b079/96/6.webp", ObjetoMensajeTelegram);

            }


            if (mensajeEntrante.Contains("Libro"))
                {
                    string contenedor = mensajeEntrante;
                    string[] trozo = contenedor.Split("Libro");
                try
                {
                    int numero = Int16.Parse(trozo[1]);
                    string libroenviar = todos[numero - 1];

                    await new Escuchar().EnviaPDFAsync(Telegram_id_manda_mensaje, libroenviar, "");
                    respuesta = "Espero disfrutes leyendo"+mdEmojis.libros;
                    }
                    catch
                    {
                        respuesta = "Tienes que Ingresar el dato como se te esta pidiendo, gracias";
                    }
                }

         



            // envia la respuesta del diaglo
            if (!String.IsNullOrEmpty(respuesta))//    
            {
                await Bot.SendTextMessageAsync(
                    chatId: ObjetoMensajeTelegram.Message.Chat,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Default,
                    text: respuesta

            );

            }

        } // fin del metodo de recepcion de mensajes

        private static void BotOnReceiveError(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
        {
            Console.WriteLine("UPS!!! Recibo un error!!!: {0} — {1}",
                receiveErrorEventArgs.ApiRequestException.ErrorCode,
                receiveErrorEventArgs.ApiRequestException.Message
            );
        }

        public async System.Threading.Tasks.Task EnviaPDFAsync(string usuario, String archivo, String titulo)
        {
            ITelegramBotClient botClient2 = new TelegramBotClient(TokenBot);
            var me = botClient2.GetMeAsync().Result;
            Console.WriteLine($"Envio de manual   al usuario {usuario}");

            try
            {
                await botClient2.SendChatActionAsync(usuario, ChatAction.Typing);
                using (var fileStream = new FileStream(archivo, FileMode.Open, FileAccess.Read, FileShare.Read))
                {

                    await botClient2.SendDocumentAsync(
                        chatId: usuario,
                        caption: titulo,
                        document: new InputOnlineFile( /* content: */ fileStream, /* fileName: */ "Libro.pdf")
                        );
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("error al mandar PDF!" + err.Message);
            }
        }

        public async System.Threading.Tasks.Task EnviarSticker(string name, MessageEventArgs messageEventArgumentos)
        {
            var ObjetoMensajeTelegram=messageEventArgumentos;
            await Bot.SendStickerAsync(
                       chatId: ObjetoMensajeTelegram.Message.Chat,
                   sticker: name);
        }


   /*     public async System.Threading.Tasks.Task EnviarGame(string name, MessageEventArgs MessageEventArgumentos)
        {
            var ObjetoMensajeTelegram = MessageEventArgumentos;
            await Bot.SendGameAsync(ObjetoMensajeTelegram.Message.Chat.Id,gameShortName:name);
            
        }
        */
        
                  
            
        












    }
}

    