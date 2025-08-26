using System;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Digite seu nome: ");
        string namePerson = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(namePerson))
        {
            Console.WriteLine("Name cannot be empty");
            return;
        }
        else
        {
            Console.WriteLine("Digite sua idade: ");
            int agePerson = int.Parse(Console.ReadLine());

            if (agePerson >= 18)
            {
                Console.WriteLine("Seja bem vindo ao sistema, \n"
                + "Insira sua senha e conclua seu cadastro.");
            }
            else
            {
                Console.WriteLine("Age must be 18 or older");
                return;
            }
        }


        Console.WriteLine("Digite sua senha: (6 caracteres)");
        string passwordPerson = Console.ReadLine();

        if (passwordPerson.Length == 6)
        {
            Console.WriteLine("Confirme sua senha: (6 caracteres) ");
            string confirmPasswordPerson = Console.ReadLine();

            if (confirmPasswordPerson == passwordPerson)
            {
                Console.WriteLine("Registration completed");
            }
            else
            {
                Console.WriteLine("Passwords do not match");
            }

        }
        else
        {
            Console.WriteLine("Password must be equal to or greater than 6 characters");
        }

    }
}





