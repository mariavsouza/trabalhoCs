using System.Runtime.CompilerServices;

class Ingresso
{
    private string? nomeCirco;

    private int? setor;

    private double? valor;

    public string? NomeCirco
    {
        get{return nomeCirco;}
        set{nomeCirco = value;}
    }

    public int? Setor
    {
        get{return setor;}
        set
        {
            if (Setor.Length > 1)
            {
                Console.WriteLine("CAMPO INVÁLIDO!! O campo 'Setor' deve ter penas um caractér.");
            }
            setor = value;
        }   
    }

    public double? Valor
    {
        get{return valor;}
        set
        {
            if (value < 0)
            {
                Console.WriteLine("CAMPO INVÁLIDO!! O campo 'Valor' deve ser maior que zero.");
            }
            valor = value;
        }   
    }

    public void DadosIngresso()
    {
        Console.WriteLine($"Nome do Circo: {NomeCirco}");
        Console.WriteLine($"Setor: {Setor}");
        Console.WriteLine($"Valor: R${Valor}");
    }
}