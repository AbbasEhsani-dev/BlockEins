using System;
internal class Program
{
    private static void Main(string[] args)
    {

        // Block 1 
         Console.WriteLine("Please Enter Your name");
       string? name = Console.ReadLine();
         Console.WriteLine($"Hello,{name} schön, dass du da bist!");
         Console.WriteLine("Enter the first number");
         int eins = int.Parse(Console.ReadLine()?? "0");
         Console.WriteLine("Enter the second Number");
         int zwei = int.Parse(Console.ReadLine()?? "0");
         int result = eins + zwei;
         Console.WriteLine("The summe ist:" + result);


         Console.WriteLine("Gib deinen Namen in Grossbuchstaben ");
         string? NAME = Console.ReadLine();
         Console.WriteLine("Ihre Name in Kleinbuchstaben: " + " " + NAME?.ToLower());
         Console.WriteLine("Enter deinen Name in kleinen Buschstaben");
         string? uppercasename = Console.ReadLine();
         Console.WriteLine("Ihre Name in Grossenbuchstaben:" + " " + uppercasename?.ToUpper());

         int type1 = 12;
         double typee2 = 12.34;
         string text = " text";
         Console.WriteLine(type1.GetType());
         Console.WriteLine(typee2.GetType());
         Console.WriteLine(text.GetType());

         eins++;
         Console.WriteLine(eins);
         eins += 2;
         Console.WriteLine(eins);
         Console.WriteLine("Enter the first number");
         int a = int.Parse(Console.ReadLine()?? "0");
         Console.WriteLine("Enter the seocnd number");
         int b = int.Parse(Console.ReadLine()?? "0");

         if (a > b)
         {
             Console.WriteLine($"{a} ist grosser als {b}");

         }
         else
         {
             Console.WriteLine($"{b} is grosser als {a}");

         }
         //Logische Operaten 


         Console.WriteLine("Enter die  Zahl zum vergliechen");
         int first = int.Parse(Console.ReadLine()?? "0");

         if (first > 10 && first < 20)
         {
             Console.WriteLine("Die Zahl ist zwischen 10 und 20");
         }
         if (first < 0 || first > 100)
         {
             Console.WriteLine($"Die Zahl {first} liegt ausserhalb 0-100 ");
         }

         else
         {
             Console.WriteLine($"Dia Zahl {first} liegt innerhalb 0-100");
         }


         //pswd checker 
         Console.WriteLine("Please Enter the password");
         string? pswd = Console.ReadLine();


         if (!string.IsNullOrEmpty(pswd) && pswd.Length > 8)
         {
             Console.WriteLine($"The {pswd} is langer than 8 characters");
         }
         else
         {
             Console.WriteLine($"The {pswd} is not longer than 8 characters");
         } 
        //////Unterwegs


        Console.WriteLine("Wie schnell fährt Ihre Auto (km/h)");
        double geschwindigkeit = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Wie hoch ist der Verbrauch Ihres Autos (Liter pro 100km)");
        double verbrauchPro10k = double.Parse(Console.ReadLine()?? "0");

        Console.WriteLine("Wie weit möchten sie fahren (km)");
        double distanz = double.Parse(Console.ReadLine()?? "0");
        double fahrzeitstunden = distanz / geschwindigkeit;// speed in hour 
        double benizinfordintance = distanz / 100;

        Console.WriteLine($"Ihre fahrzeitstunden ist {fahrzeitstunden} Stunde.");
        Console.WriteLine($"sie brauchen {benizinfordintance} Liter Benzin  für Ihre Reise.");

        //Body mass index
        ///Around the clock
        /*  double stunde = double.Parse(Console.ReadLine());
         int hour = (int)stunde ;

         Console.WriteLine(hour/100);
         double min = stunde - hour;
         Console.WriteLine(min); */

        Console.WriteLine("Bitte geben Sie die Stunde ein");
        int stunde1 = int.Parse(Console.ReadLine()?? "0");
        Console.WriteLine("Bitte geben Sie die Minute ein ");
        int minute = int.Parse(Console.ReadLine()?? "0");
        Console.WriteLine("Bitte geben Sie die Sekunde ein ");
        int sekunde = int.Parse(Console.ReadLine()?? "0");
        double dezimalStunden = stunde1 + (minute / 60.0) + (sekunde / 3600.0);

        // Ausgabe
        Console.WriteLine($"Ergebnis: {dezimalStunden} Stunden");
    }


}