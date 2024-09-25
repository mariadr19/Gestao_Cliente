using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Gestão
{
    public class Cliente : Pessoa
    {
        public string email;
        public string telefone;

        public string EmailPessoa { get =>  email; set => email = value; }
        public string TelefonePessoa { get => telefone; set => telefone = value; }

        public Cliente(string nome, string endereço, string email, string telefone)
        {
            base.EndereçoPessoa = endereço;
            base.NomePessoa = nome;
            this.TelefonePessoa = telefone;
            this.EmailPessoa = email;

        }

        public override string MostrarDados()
        {
            return base.MostrarDados() + $",\nEmail: {EmailPessoa},\nTelefone: {TelefonePessoa}";
        }
    }
}
