using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrarServer;
using LocationServer;
using RedirectServer;

namespace ProxyServer
{
    class ProxyServer
    {
        private Location myLocationServ;
        private Redirect myRedirectServ;
        private Registrar myRegistrarServ;

        public static void main(String[] args)
        {
            // Driver of the Server.
            ProxyServer myServer = new ProxyServer();
            // do something
        }

        public ProxyServer()
        {
            // initialize servers
            myLocationServ = new Location();
            myRedirectServ = new Redirect();
            myRegistrarServ = new Registrar();
        }

        private String send(String message1, String message2) 
        {
            // sending SIP messages to the client.
            return "a string";
        }

        private String receive(String[] msgs) 
        {
            // receive SIP messages
            sipProtocol(msgs[0],msgs[1]);
            return "a string";
        }

        private void sipProtocol(String message, String message2)
        {
            // key, value pairs
            // SWITCH CASE STATEMENTS
                // INVITE, REGISTER
                // (OK) CANCEL BYE ACK
            switch (msg)
            {
                case ("REGISTER")
                    // do something
                    // Register.method();
                case ("INVITE")
                    // do something
                    // This.forward(INVITE)
                case ("OK")
                    // do something
                    // OK
                case ("CANCEL")
                    // do something
                    // Cancel transaction
                case ("BYE")
                    // do something
                    // This.connection(BYE);
                case ("ACK")
                    // do something

                default return "error"; // do nothing
            }
        }
    }
}
