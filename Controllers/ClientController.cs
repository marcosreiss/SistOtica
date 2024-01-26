using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using SistOtica.Data;
using SistOtica.Models.Client;
using SistOtica.Repository.Cliente;

namespace SistOtica.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        private readonly AppDbContext _context;
        public ClientController(IClientRepository clientRepository, AppDbContext appDbContext)
        {
            this._clientRepository = clientRepository;
            this._context = appDbContext;
        }

        public IActionResult Index()
        {
            var clients = _clientRepository.GetAll();

            return View(clients);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ClientViewModel clientView) 
        {
            if(ModelState.IsValid)
            {
                ClientModel client = new ClientModel();
                ClientContact contact = new ClientContact();

                client.Id = clientView.Id;
                client.Name = clientView.Name;
                client.Cpf = clientView.Cpf;
                client.Rg = clientView.Rg;
                client.BornDate = clientView.BornDate;
                client.MotherName = clientView.MotherName;
                client.FatherName = clientView.FatherName;
                client.SpouseName = clientView.SpouseName;
                client.EmailAddress = clientView.EmailAddress;
                client.Company = clientView.Company;
                client.Ocupation = clientView.Ocupation;
                client.Street = clientView.Street;
                client.City = clientView.City;
                client.Neighborhood = clientView.Neighborhood;
                client.Uf = clientView.Uf;
                client.Cep = clientView.Cep;
                client.AddressComplement = clientView.AddressComplement;
                client.Negativated = clientView.Negativated;
                client.Observation = clientView.Observation;

                contact.PhoneNumber = clientView.PhoneNumber;

                _clientRepository.Create(client, contact);
                return RedirectToAction("Index");
            }

            return View(clientView);
        }
    }
}
