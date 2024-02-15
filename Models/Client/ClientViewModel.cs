using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistOtica.Models.Client
{
    public class ClientViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [DisplayName("Rg")]
        public string Rg { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateOnly BornDate { get; set; }

        [DisplayName("Nome do Pai")]
        public string FatherName { get; set; }

        [DisplayName("Nome da Mãe")]
        public string MotherName { get; set; }

        [DisplayName("Nome do Conjuge")]
        public string SpouseName { get; set; }

        [DisplayName("Email")]
        public string EmailAddress { get; set; }

        [DisplayName("Empresa")]
        public string Company { get; set; }

        [DisplayName("Ocupação")]
        public string Ocupation { get; set; }

        [DisplayName("Rua")]
        public string Street { get; set; }

        [DisplayName("Bairro")]
        public string Neighborhood { get; set; }

        [DisplayName("Cidade")]
        public string City { get; set; }

        [DisplayName("Estado")]
        public string Uf { get; set; }
        [DisplayName("Cep")]
        public string Cep { get; set; }

        [DisplayName("Complemento")]
        public string AddressComplement { get; set; }

        [DisplayName("Negativado?")]
        public bool Negativated { get; set; }

        [DisplayName("Observação")]
        public string Observation { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Telefone")]
        [NotMapped]
        public List<string> PhoneNumber { get; set; }

        [DisplayName("Nome")]
        [NotMapped]
        public List<string> ReferenceName { get; set;}

        [DisplayName("Telefone")]
        [NotMapped]
        public List<string> ReferencePhone { get; set; }

    }
}
