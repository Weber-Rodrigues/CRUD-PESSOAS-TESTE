using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CrudPessoaFisica.Models
{
    public class PessoaFisica
    {
        private string _nome;
        private int _idade;
        private string _cpf;
        private string _sexo;
        public int Id { get; set; }
        public string Nome
        {
            get => _nome;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O campo nome não pode ser vazio!");
                }
                _nome = value;
            }
        }
        public string Cpf { get; set; }
        public string Sexo { get; set; }
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Numero inválido para o campo idade! ");
                }
                _idade = value;
            }
        }
        public string DataNascimento { get; set; }
    }



}