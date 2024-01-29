using Microsoft.EntityFrameworkCore;
using SistOtica.Data;
using SistOtica.Models.Client;

namespace SistOtica.Repository.Cliente
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;
         
        public ClientRepository(AppDbContext appDbContext)
        {
            this._context = appDbContext;
        }

        public List<ClientModel> GetAll()
        {
           return _context.Clients.Include(c => c.PhoneNumber).ToList();
        }

        public ClientModel Create(ClientModel client)
        {
            //persistir no banco
            _context.Clients.Add(client);
            _context.SaveChanges();
            return client;
        }

        //public ClientContact CreateContact(ClientContact contact)
        //{
        //    _context.Contacts.Add(contact);
        //    _context.SaveChanges();
        //    return contact;
        //}
    }
}
