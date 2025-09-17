internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please Enter Your name");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello,{name} schön, dass du da bist!");
        Console.WriteLine("Enter the first number");
        int eins = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second Number");
        int zwei = int.Parse(Console.ReadLine());
        int result = eins + zwei;
        Console.WriteLine("The summe ist:" + result);


        Console.WriteLine("Ente deinen Namen in Grossbuchstaben ");
        string? NAME = Console.ReadLine();
        Console.WriteLine("Ihre Name in Kleinbuchstaben: " + " " + NAME.ToLower());
        Console.WriteLine("Enter deinen Name in kleinen Buschstaben");
        string? uppercasename = Console.ReadLine();
        Console.WriteLine("Ihre Name in Grossenbuchstaben:" + " " + uppercasename.ToUpper());

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
    }
}