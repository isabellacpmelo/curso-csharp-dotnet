using static System.Console;
public class Program
{
    static void Demo6()
    {
       int[] numeros = new int[] {0,2,4,6,8};
       WriteLine($"Digite aqui o número que gostaria de encontrar");
       var numero = int.Parse(ReadLine());
       var idxEncontrado = EncontrarNumero(numeros, numero);

       if (idxEncontrado >= 0) 
       {
            WriteLine($"O número encontrado está na posição {idxEncontrado}");
       }
       else 
       {
           WriteLine("O número digitado não foi encontrado.");
       }
    }

    static void Demo5()
    {
        int[] pares = new int[]{0,2,4,6,8};

        MudarParaImpar(pares);
        WriteLine($"Os impares {string.Join(",", pares)}");
    }
    static void Demo4()
    {
        string nome = "Isabella";

        TrocarNome(nome, "Isinha");

        WriteLine($"O nome é {nome}");
    }

    static void Demo3()
    {
         StrucPessoa p1 = new StrucPessoa()
        {
            Documento = "123",
            Idade = 26,
            Nome = "Isabella"
        };

        var p2 = p1;

        p1 = TrocarNome(p1, "João");

        WriteLine($@"
        Nome do p1 {p1.Nome}
        nome do p2 {p2.Nome}
        ");
    }
    static void Demo2()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Isabella";
        p1.Idade = 26;
        p1.Documento = "123";

        Pessoa p2 = p1.Clone();

        TrocarNome (p1, "Jose");

        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p2.Nome}
        ");
    }
    static void Demo()
    {
        int a = 2;
        a = Adicionar20(a);
        WriteLine($"O valor da variável a é {a}");
    }
    static int Adicionar20(int x)
    {
       return x + 20;
    }
    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }

    static StrucPessoa TrocarNome(StrucPessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
        return p1;
    }

    static void TrocarNome(string nome, string nomeNovo)
    {
        nome = nomeNovo;
    }

    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i <pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }

    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numero)
              return i; 
        }
        return - 1;
    }

    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
        foreach (var item in pessoas)
        {
            if(item.Nome == pessoa.Nome)
            {
                return true;
            }
        }
        return false;
    }
    public static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Isabella"},
            new Pessoa(){Nome = "Pitty"},
            new Pessoa(){Nome = "Romeu"},
            new Pessoa(){Nome = "Julieta"},
            new Pessoa(){Nome = "Baratinha"},
        };

        WriteLine("Digite a pessoa que gostaria de localizar: ");

        var nome = ReadLine();
        var pessoa = new Pessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);

        if(encontrado)
        {
            WriteLine("Pessoa Localizada");
        }
        else
        {
            WriteLine("Pessoa não localizada");
        }
    }
}
