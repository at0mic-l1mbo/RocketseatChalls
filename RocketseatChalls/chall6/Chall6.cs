using System.Globalization;

namespace RocketseatChalls.chall6;

public class Chall6
{
    public static void Main()
    {
        int op;
        DateTime today = DateTime.Now;
        op = Menu();
        switch (op)
        {
            case 1:
                Console.WriteLine("Data completa: " + today.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"));
                break;

            case 2:
                Console.WriteLine($"Hoje é: {today.ToString("dd/MM/yyyy")}");
                break;

            case 3:
                Console.WriteLine($"Agora são: {today.ToString("HH:mm:ss")}");
                break;

            case 4:
                Console.WriteLine($"Hoje é: {today.ToString("dd 'de' MMMM yyyy")}");
                break;

            case 0:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Saindo do programa...");
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(0);
                break;
        }
    }

    public static int Menu()
    {
        string option;
        int code;
        do
        {


            Console.WriteLine("================================================");
            Console.WriteLine("[1] - Formato completo (dia da semana, mês, ano, hora, min, segs)");
            Console.WriteLine("[2] - Apenas data (dd/MM/YYYY)");
            Console.WriteLine("[3] - Apenas a hora (HH:mm:ss)");
            Console.WriteLine("[4] - Data com mês por extenso");
            Console.WriteLine("[0] - Sair");
            Console.WriteLine("================================================");
            Console.WriteLine("Digite uma opção: ");
            option = Console.ReadLine();
            code = Int32.Parse(option);
            if(code < 0 || code > 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[-] Opção inválida, tente novamente...");
                Console.ForegroundColor = ConsoleColor.White;
            }

        } while (code < 0 || code > 4);   

        return code;
    }
}
