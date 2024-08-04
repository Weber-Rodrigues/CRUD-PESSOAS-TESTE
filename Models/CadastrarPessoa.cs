using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudPessoaFisica.Models
{
    public class CadastrarPessoa
    {

        public List<PessoaFisica> Pessoas { get; set; }

        public void AdicionarPessoa(PessoaFisica pessoa)
        {
            Pessoas.Add(pessoa);
            Console.WriteLine("Pessoa Cadastrada com sucesso!");

        }

        public void ListarPessoas()
        {
            foreach (PessoaFisica item in Pessoas)
            {

            }
        }



    }
}