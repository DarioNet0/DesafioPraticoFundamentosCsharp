using System.Runtime.CompilerServices;
using System.Text;

namespace DesafioPratico;

public class Program
{
    public static string printaBoasVindas()
    {
        Console.WriteLine("Qual o seu nome ?");
        string nome = Console.ReadLine();
        return $"Bem vindo {nome}";
    }
    public static string concatenaNomeSobrenome()
    {
        Console.WriteLine("Qual o seu nome ?");
        string nome = Console.ReadLine();
        Console.WriteLine("Qual o seu sobrenome ?");
        string sobrenome = Console.ReadLine();
        return $"seu nome é {nome} {sobrenome}";
    }
    public static (double, double, double, double, double) operacoes(double num1, double num2)
    {
        double soma = num1 + num2;
        double subtracao = num1 - num2;
        double multiplicacao = num1 * num2;
        double divisao = 0;
        if (num2 == 0)
        {
            divisao = 0;
        }
        double media = soma / 2;
        return (soma, subtracao, multiplicacao, divisao, media);
    }
    public static int contaCaracteres()
    {
        Console.WriteLine("Escreva uma frase ou palavra:");
        string str = Console.ReadLine();
        int contagem = 0;
        for (int x = 0; x < str.Length; x++)
        {
            if (!char.IsWhiteSpace(str[x]))
            {
                contagem++;
            }
        }
        return contagem;
    }
    public static bool validaPlaca(string placa)
    {
        //verificando tamanho da string
        int caracteres = 0;
        for (int x = 0; x < placa.Length; x++)
        {
            if (!char.IsWhiteSpace(placa[x]) || !char.IsLetterOrDigit(placa[x]))
            {
                caracteres++;
            }
        }
        //verificando os 3 primeiros caracteres
        int tresCaracteresMaiusculos = 0;
        for (int x = 0; x <2; x++)
        {
            if (char.IsUpper(placa[x])) {
                tresCaracteresMaiusculos++;
            }
        }
        //verificando os 3 últimos dígitos
        int quatroUltimosNumeros = 0;
        for (int x = placa.Length - 4; x < placa.Length; x++)
        {
            if (char.IsDigit(placa[x]))
            {
                quatroUltimosNumeros++;
            }
        }
        //verificando as 3 condições
        if (caracteres == 7 || tresCaracteresMaiusculos == 3 || quatroUltimosNumeros == 4)
        {
            return true;
        }
        else { return false; }
    }
    public static (string, string, string, string) FormataData()
    {
        DateTime dataCompleta = DateTime.Now;

        DateOnly dataComBarra = DateOnly.FromDateTime(DateTime.Now);

        int Hora = dataCompleta.Hour;

        int mes = dataCompleta.Month;

        return (dataCompleta.ToString(),  dataComBarra.ToString(), Hora.ToString(), mes.ToString());
    }
    public static void Main()
    {
        Console.WriteLine(printaBoasVindas());
        Console.WriteLine(concatenaNomeSobrenome());
        Console.WriteLine(operacoes(22, 10));
        Console.WriteLine(contaCaracteres());
        Console.WriteLine(validaPlaca("ABC8787"));
        Console.WriteLine(FormataData());
    }
}