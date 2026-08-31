class Carro
{
    private string? marca;

    private string? cor;

    private int? ano;

    private double? valor;

    public string? Marca
    {
        get{return marca;}
        set{marca = value;}
    }


    public string? Cor
    {
        get{return cor;}
        set{cor = value;}

    }

    public int? Ano
    {
        get{return ano;}
        set
        {
            if(value < 0)
            {
                Console.WriteLine($"CAMPO INVÁLIDO!! O ano deve ser maior que zero.");
                return;
            }
            ano = value;
        }
    }

    public double? Valor
    {
        get{return valor;}
        set
        {
            if(value < 0)
            {
                Console.WriteLine($"CAMPO INVÁLIDO!! O valor deve ser maior que zero.");
                return;
            }
            valor = value;
        }
    }

    public void CarInfo()
    {
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Valor: R${Valor}M");
    }
}