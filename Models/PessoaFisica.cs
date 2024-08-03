using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CrudPessoaFisica.Models
{
    public class PessoaFisica
    {
        // public PessoaFisica(string Nome, string CPF, string DataNascimento)
        // {

        //     this.Nome = Nome;
        //     this.CPF = CPF;
        //     this.DataNascimento = DataNascimento;


        // }
        private static int id = 1;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }



    }



}