namespace zadacha5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            
            switch (product)
            {
                case "coffee":
                    if (city == "Sofia")
                    {
                        Console.WriteLine(quantity * 0.5);
                    }
                    else if (city == "Plovdiv")
                    {
                        Console.WriteLine(quantity * 0.4);
                    }
                    else if (city == "Varna")
                    {
                        Console.WriteLine(quantity *0.45);
                    }
                    break;
                case "water":
                    if (city == "Sofia")
                    {
                        Console.WriteLine(quantity * 0.8);
                    }
                    else if (city == "Plovdiv")
                    {
                        Console.WriteLine(quantity * 0.7);
                    }
                    else if (city == "Varna")
                    {
                        Console.WriteLine(quantity * 0.7);
                    }
                    break;
                case "juice":
                    if (city == "Sofia")
                    {
                        Console.WriteLine(quantity * 1.2);
                    }
                    else if (city == "Plovdiv")
                    {
                        Console.WriteLine(quantity * 1.15);
                    }
                    else if (city == "Varna")
                    {
                        Console.WriteLine(quantity * 1.10);
                    }
                    break;
                case "sweets":
                    if (city == "Sofia")
                    {
                        Console.WriteLine(quantity * 1.45);
                    }
                    else if (city == "Plovdiv")
                    {
                        Console.WriteLine(quantity * 1.30);
                    }
                    else if (city == "Varna")
                    {
                        Console.WriteLine(quantity * 1.35);
                    }
                    break;
                case "peanuts":
                    if (city == "Sofia")
                    {
                        Console.WriteLine(quantity * 1.6);
                    }
                    else if (city == "Plovdiv")
                    {
                        Console.WriteLine(quantity * 1.5);
                    }
                    else if (city == "Varna")
                    {
                        Console.WriteLine(quantity * 1.55);
                    }
                    break;
            }
        }
    }
}