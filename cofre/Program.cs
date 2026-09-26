using System;

public class Program
{
    public static void Main(string[] args)
    {
        int num = 0;
        string resp, letra = "", nvsenha, senha, dica = "";
        int cont = 0;
        char rp;

        Console.WriteLine("Entre com uma nova senha para seu cofre:\n");
        nvsenha = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Deseja colocar uma dica? (s/n)");
        rp = char.Parse(Console.ReadLine());
        
        if (rp == 's')
        {
            Console.WriteLine("Qual a dica dessa senha?\n");
            dica = Console.ReadLine();
        } 
        Console.WriteLine();
        Console.WriteLine("Deseja guardar letras ou números no cofre?\n");
        resp = Console.ReadLine();

        if (resp == "letras")
        {
            Console.WriteLine();
            Console.WriteLine("Guarde suas letras:\n");
            letra = Console.ReadLine();
        }
        else if (resp == "números" || resp == "numeros")
        {
            Console.WriteLine();
            Console.WriteLine("Guarde seus números(inteiros e todos juntos):\n");
            num = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Entre com sua senha para ver o conteúdo do cofre:\n");
        senha = Console.ReadLine();

        while (senha != nvsenha)
        {
            cont++;

            Console.WriteLine("Senha errada");
            
            if (rp == 's' && cont == 3)
                {
                    Console.WriteLine("A dica da senha é:");
                    Console.WriteLine(dica);
                }
                Console.WriteLine("Entre com sua senha para ver o conteúdo do cofre:\n");
                senha = Console.ReadLine();
        }
            Console.WriteLine("Senha Correta!");
            Console.WriteLine("O conteúdo do cofre é:");
            if (resp == "letras")
            {
                Console.WriteLine();
                Console.WriteLine(letra);
            }
            else if (resp == "números" || resp == "numeros")
            {
                Console.WriteLine();
                Console.WriteLine(num);
            }
    }
}