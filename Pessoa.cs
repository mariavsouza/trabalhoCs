class Pessoa
{
    private string? nome;

    private int? idade;

    private string? endereco;

    public string? Nome
    {
        get { return nome;}
        set { nome = value;}
    }

    public int? Idade
    {
        get { return idade;}
        set { idade = value;}
    }

    public string? Endereco
    {
        get { return endereco;}
        set { endereco = value;}
    }

    public void ExibirInfor()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"Endereço: {Endereco}");
    }

    public void Saudar()
    {
        if(Nome is not null)
        {
            Console.WriteLine($"Olá {Nome}, tudo bem?");
            return;
        }
        Console.WriteLine($"O campo 'nome' não pode estar vazio!");
    }
}