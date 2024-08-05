using CrudPessoaFisica.Models;



class Program
{
    private static List<PessoaFisica> Pessoas = [];
    private static int nextId = 1;

    static void Main()
    {
        bool exibirConsole = true;
        string option;
        while (exibirConsole)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Listar todas as pessoas");
            Console.WriteLine("2. Inserir nova pessoa");
            Console.WriteLine("3. Atualizar pessoa");
            Console.WriteLine("4. Deletar pessoa");
            Console.WriteLine("5. Sair");


            switch (Console.ReadLine())
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

                case "5":
                    exibirConsole = false;
                    break;

            }
        }
    }

    static void AdicionarPessoa()
    {
        Console.WriteLine("Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("CPF: ");
        string cpf = Console.ReadLine();
        Console.WriteLine("Idade: ");
        string idade = Console.ReadLine();
        Console.WriteLine("Data de Nascimento: ");
        string dataNascimento = Console.ReadLine();
        Console.WriteLine("Sexo: ");
        string sexo = Console.ReadLine();
        Console.WriteLine("Pessoa adicionada com sucesso!");

        PessoaFisica pessoa = new()
        {
            Id = nextId++,
            Nome = nome,
            Cpf = cpf,
            Idade = Convert.ToInt32(idade),
            DataNascimento = dataNascimento,
            Sexo = sexo
        };

        Pessoas.Add(pessoa);
    }

    static void ListarPessoas()
    {
        foreach (PessoaFisica pessoa in Pessoas)
        {
            Console.WriteLine($"ID: {pessoa.Id}, Nome: {pessoa.Nome}, CPF: {pessoa.Cpf}, Idade: {pessoa.Idade}, Data de Nascimento: {pessoa.DataNascimento}, Sexo: {pessoa.Sexo} ");
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
            Console.Write("Nova Idade: ");
            pessoa.Idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Novo CPF: ");
            pessoa.Cpf = Console.ReadLine();
            Console.Write("Nova Data de Nascimento: ");
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
