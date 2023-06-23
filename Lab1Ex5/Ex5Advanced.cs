/*Ex 5
Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
• Exemplu: citim ,9,0 Afisam : 0 9 */

internal class Ex5Advanced
{

    private static void Main()
    {
        double primulNumar;
        double alDoileaNumar;


        Console.WriteLine("Introdu primul numar:");
        primulNumar = double.Parse(Console.ReadLine());

        Console.WriteLine("Introdu al doilea numar:");
        alDoileaNumar = double.Parse(Console.ReadLine());

        double[] doubleArray = new double[] { primulNumar, alDoileaNumar };
        Array.Sort(doubleArray);
        Console.WriteLine("Aceasta este ordinea sirului tau:");

        foreach (double i in doubleArray)
        {
            Console.WriteLine(i + " ");
        }

    }

}
