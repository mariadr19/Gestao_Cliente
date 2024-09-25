using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Gestão
{
    public class Pessoa
    {
        public string nome;
        public string endereço;

        public string NomePessoa { get =>  nome; set => nome = value;}
        public string EndereçoPessoa { get => endereço; set => endereço = value;}

      
        public virtual string MostrarDados()
        {
            return $"\nNome: {NomePessoa},\nEndereço: {EndereçoPessoa}";
        }

    }
}
