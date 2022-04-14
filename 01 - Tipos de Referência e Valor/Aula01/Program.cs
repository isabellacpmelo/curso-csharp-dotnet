using static System.Console;
public class Program
{
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
    public static void Main()
    {
       string nome = "Isabella";

       TrocarNome(nome, "Isinha");

        WriteLine($"O nome é {nome}");
    }
}
