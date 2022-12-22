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
         * - Client(JS) -> Hub(C#) (Funcionário) -> (C# - CadastrarPromocao)
         * - Hub(C#) -> Client(JS) (JS - ReceberPromocao)
         */

        public async Task CadastrarPromocao(Promocao promocao)
        {
            /* 
             * Banco
             * Queue/Scheluder...
             * Notificar usuário (SignalR)
             */

            await Clients.Caller.SendAsync("CadastradoSucesso"); // Notificar Caller -> Cadastro realizado com sucesso!
            await Clients.Others.SendAsync("ReceberPromocao", promocao); // Notificar que a promoçao chegou
        }
    }
}
