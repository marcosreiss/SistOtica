using Microsoft.EntityFrameworkCore;
using SistOtica.Data;
using SistOtica.Models.Client;

namespace SistOtica.Repository.Cliente
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _appContext;
         
        public ClientRepository(AppDbContext appDbContext)
        {
            this._appContext = appDbContext;
        }

        public List<ClientModel> GetAll()
        {
           return _appContext.Clients.Include(c => c.PhoneNumber).ToList();
        }

        public ClientModel Create(ClientModel client, ClientContact contact)
        {
            //persistir no banco
            _appContext.Clients.Add(client);
            _appContext.SaveChanges();

            contact.ClientId = client.Id;
            _appContext.Contacts.Add(contact);
            

            _appContext.SaveChanges();
            return client;
        }

        
    }
}
