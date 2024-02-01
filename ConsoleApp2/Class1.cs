using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal static class Utente
    {
        private static string _password;
        private static string _confermapassword;
        private static string _username;

        public static string Username { get { return _username; } }
        public static string Password { get { return _password; } }
        public static string ConfermaPassword { get { return _confermapassword; } set { _confermapassword = value; } }
    
    public static void Login ()
    {
        Console.WriteLine("Inserisci il tuo nome utente");
        _username = Console.ReadLine();
        Console.WriteLine("Inserisci la tua password");
        _password = Console.ReadLine();
        Console.WriteLine("Conferma la tua password");
        _confermapassword = Console.ReadLine();
            if (_username != null || _password == _confermapassword)
            {
                Console.WriteLine("Login eseguito con successo");
            }
            else
            {
                Console.WriteLine("Login Fallito");
            }
    }
        public static void Logout()
        { 
            if (_username != null && _password !=null)
            {
                _username = null; _password = null; _confermapassword = null;
                Console.WriteLine("Logout eseguito con successo");
            } else
            {
                Console.WriteLine("Vuoi fare il logout? Scimunitu i guerra");
            }
        }

    }

    
}
