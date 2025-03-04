using System.Drawing;

namespace RocketseatChalls.chall5;

public class Chall5
{
  /*  public static void Main()
    {
        string carLicensePlate, aux, aux2;

        while (true) {
            Console.WriteLine("Digite aqui a placa do carro: ");
            carLicensePlate = Console.ReadLine();
            if (carLicensePlate == String.Empty || carLicensePlate.Length < 7 || carLicensePlate.Length > 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[-] Placa inválida, tente novamente...");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                aux = carLicensePlate[0..3];
                if (CheckAlphabetic(aux))
                {
                    aux2 = carLicensePlate[3..7];
                    if (CheckAlphanumeric(aux2))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("[+] A placa é válida!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[-] Placa inválida! Não contém números...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[-] Placa inválida! Não contém letras...");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
 

        }
    }
  */

    public static bool CheckAlphabetic(string licensePlate)
    {
        bool isValid = licensePlate.All(c => char.IsLetter(c));
        return isValid;
    }

    public static bool CheckAlphanumeric(string licensePlate)
    {
        bool isValid = licensePlate.All(d => char.IsDigit(d));
        return isValid;
    }
}
