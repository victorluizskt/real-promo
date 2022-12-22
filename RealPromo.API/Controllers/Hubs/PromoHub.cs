using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace RealPromo.API.Models.Hubs
{
    // all hubs inherit from class Hub
    public class PromoHub : Hub
    {
        // all functions in class, js access
        /*
         * Client - JS/C#/Java
         * RPC
         * Client -> Hub
         * Hub -> Client
         */

        public async Task CadastrarPromocao(Promocao promocao)
        {
            /* 
             * Banco
             * Queue/Scheluder...
             * Notificar usuário (SignalR)
             */


        }
    }
}
