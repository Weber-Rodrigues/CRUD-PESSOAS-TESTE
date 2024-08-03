using System;
using System.Collections.Generic;
using System.Linq;
using CrudPessoaFisica.Models;

class Program
{
    private static List<PessoaFisica> Pessoas = new List<PessoaFisica>();
    private static int nextId = 1;

    static void Main()
    {
        string option;
        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Listar todas as pessoas");
            Console.WriteLine("2. Inserir nova pessoa");
            Console.WriteLine("3. Atualizar pessoa");
            Console.WriteLine("4. Deletar pessoa");
            Console.WriteLine("5. Sair");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ListarPessoas();
                    break;
                case "2":
                    AdicionarPessoa();
                    break;
                case "3":
                    AtualizarPessoa();
                    break;
                case "4":
                    DeletarPessoa();
                    break;
            }
        } while (option != "5");
    }

    static void AdicionarPessoa()
    {
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("CPF: ");
        string cpf = Console.ReadLine();
        Console.WriteLine("Data de Nascimento (aaaa-mm-dd): ");
        string dataNascimento = Console.ReadLine();
        Console.WriteLine("Pessoa adicionada com sucesso!");

        PessoaFisica pessoa = new PessoaFisica
        {
            Id = nextId++,
            Nome = nome,
            CPF = cpf,
            DataNascimento = dataNascimento
        };

        Pessoas.Add(pessoa);
    }

    static void ListarPessoas()
    {
        foreach (PessoaFisica pessoa in Pessoas)
        {
            Console.WriteLine($"ID: {pessoa.Id}, Nome: {pessoa.Nome}, CPF: {pessoa.CPF}");
        }
    }

    static void AtualizarPessoa()
    {
        Console.Write("ID da Pessoa a atualizar: ");
        int id = int.Parse(Console.ReadLine());
        PessoaFisica pessoa = Pessoas.FirstOrDefault(p => p.Id == id);
        if (pessoa != null)
        {
            Console.Write("Novo Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Novo CPF: ");
            pessoa.CPF = Console.ReadLine();
            Console.Write("Nova Data de Nascimento (aaaa-mm-dd): ");
            pessoa.DataNascimento = Console.ReadLine();
            Console.WriteLine("Pessoa atualizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada!");
        }
    }

    static void DeletarPessoa()
    {
        Console.Write("ID da Pessoa a deletar: ");
        int id = int.Parse(Console.ReadLine());
        PessoaFisica pessoa = Pessoas.FirstOrDefault(p => p.Id == id);
        if (pessoa != null)
        {
            Pessoas.Remove(pessoa);
            Console.WriteLine("Pessoa deletada com sucesso!");
        }
        else
        {
            Console.WriteLine("Pessoa não encontrada!");
        }
    }
}
