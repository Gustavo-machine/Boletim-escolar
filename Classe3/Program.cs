using System;
using System.Globalization;

namespace Classe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Nota N = new Nota();
            int i;

            Console.WriteLine("Nome do Aluno:");
            N.Nome = Console.ReadLine();
            Console.WriteLine("Deigite as três notas do aluno:");
            N.x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N.y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N.z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Nota Final = " + N.Media().ToString("F2",CultureInfo.InvariantCulture));
            if (N.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltam =" + N.Restante().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
