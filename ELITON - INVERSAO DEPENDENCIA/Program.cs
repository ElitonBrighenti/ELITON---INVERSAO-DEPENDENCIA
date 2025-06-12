using ELITON___INVERSAO_DEPENDENCIA;
using System;

class Program
{
    static void Main()
    {
        IDevice lamp = new Lamp(State.Off);
        Switch mySwitch = new Switch(lamp);

        Console.WriteLine("=== Interruptor de Luz ===");
        Console.WriteLine("Digite 1 para alternar o estado da luz.");
        Console.WriteLine("Digite 0 para sair.");

        while (true)
        {
            Console.Write("\nSua escolha: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                mySwitch.Press();
            }
            else if (input == "0")
            {
                Console.WriteLine("Encerrando o programa...");
                break;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite 1 para alternar ou 0 para sair.");
            }
        }
    }
}