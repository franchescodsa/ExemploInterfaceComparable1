using ExemploInterfaceComparable.Entitites;

namespace ExemploInterfaceComparable
{
    internal class Program
    {
        static void Main(string[] args)

        {

            /* Problema motivador
Faça um programa para ler um arquivo contendo nomes de pessoas (um nome por 
linha), armazenando-os em uma lista. Depois, ordenar os dados dessa lista e mostra-los 
ordenadamente na tela. Nota: o caminho do arquivo pode ser informado "hardcode".
             */
            string path = @"f:\in2.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    //Colocar em orden
                    list.Sort();
                    //Invereter a orden
                    list.Reverse();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
