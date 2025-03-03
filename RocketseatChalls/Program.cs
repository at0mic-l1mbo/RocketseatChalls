namespace RocketseatChalls;

class Program
{
    public static void Main()
    {
        string name;
        do {
            Console.WriteLine("Digite aqui o seu nome: ");
            name = Console.ReadLine();  
            if(name == String.Empty)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[-] O campo nome não pode ser vazio, tente novamente...\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        
        } while (name == String.Empty);

        Console.WriteLine($"Olá {name}! Seja muito bem-vindo!");
    }
}