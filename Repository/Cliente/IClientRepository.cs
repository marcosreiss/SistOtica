using SistOtica.Models.Client;

namespace SistOtica.Repository.Cliente
{
    public interface IClientRepository
    {
        List<ClientModel> GetAll();
        ClientModel Create(ClientModel client, ClientContact contact);
    }
}
