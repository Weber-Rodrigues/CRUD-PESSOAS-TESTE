using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudPessoaFisica.Models
{
    public class PessoaFisica
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        private List<string> Pessoas = [];

        public void AdicionarPessoa()
        {
            Console.WriteLine("Nome: ");
            Nome = Console.ReadLine();
            Pessoas.Add(Nome);
            Console.WriteLine("CPF: ");
            CPF = Console.ReadLine();
            Pessoas.Add(CPF);
            Console.WriteLine("Data de Nascimento: ");
            DataNascimento = Console.ReadLine();
            Pessoas.Add(DataNascimento);
            Console.WriteLine("Pessoa adicionada com sucesso!");

        }
    }



}