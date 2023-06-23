
/*Ex 5
Se citesc doua numere de la tastatura, x, y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
• Exemplu: citim ,9,0 Afisam : 0 9*/

class Lab1Ex5 {
    static void Main()
    {
        int primulNumar;
        int alDoileaNumar;


        Console.WriteLine("Introdu primul numar:");
        primulNumar = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu al doilea numar:");
        alDoileaNumar = int.Parse(Console.ReadLine());

        if (primulNumar > alDoileaNumar) {
            Console.WriteLine("Ordinea ta este:");
            Console.WriteLine(alDoileaNumar);
            Console.WriteLine(primulNumar);
        }
        else {
            Console.WriteLine("Ordinea ta este:");
            Console.WriteLine(primulNumar);
            Console.WriteLine(alDoileaNumar);
        }
    }
}