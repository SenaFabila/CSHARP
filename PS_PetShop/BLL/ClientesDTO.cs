using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientesDTO
    {
        //Digitar prop e teclar TAB 2 vezes
        public int codigo { get; set; }
        public string nome { get; set; }
        public string cep { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string telefone { get; set; }
        public string Complemento { get; set; }
        public string sexo { get; set; }
    }
}
