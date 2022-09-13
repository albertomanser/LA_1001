namespace RNG_GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool neustart = true;
            while (neustart == true)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                bool Variable = false;
                while (Variable == false)
                {

                    try
                    {
                        Console.Write("in welcher Zahlenrange wollen sie spielen? (nur das maximum angeben) ");
                        int Range = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("geben sie bitte eine Zahl zwischen 1 und {0}", Range);
                        int Zahleingabe = System.Convert.ToInt32(Console.ReadLine());
                        Random rnd = new Random();
                        int RNG = rnd.Next(1, 13);

                    if (Zahleingabe >= 1 && Zahleingabe <= (Range))
                    {

                        while (Zahleingabe != RNG)
                        {
                            if (Zahleingabe > RNG)
                            {
                                Console.WriteLine("Ihre Zahl ist zu gross");
                                Variable = true;
                            }
                            else
                            {
                                Console.WriteLine("Ihre Zahl ist zu klein");
                                Variable = true;
                            }

                            Console.Write("geben sie bitte noch eine Zahl ein: ");
                            Zahleingabe = Convert.ToInt32(Console.ReadLine());
                        }
                        if (Zahleingabe == RNG)
                        {
                            Console.WriteLine("Glückwunsch sie habe die richtige Zahl erraten!");

                        }

                    }
                    else
                    {
                            throw new Exception();

                    }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Falsche eingabe, geben sie bitte eine korrekte Zahl ein");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }
                neustart = false;

                while (neustart == false)
                {
                    try
                    {
                        Console.WriteLine("Wollen sie nochmal spielen? [true/false] ");
                        neustart = Convert.ToBoolean(Console.ReadLine());
                        if (neustart == true)
                        {
                            Console.Clear();
                        }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Falsche eingabe, geben sie bitte true oder false ein.");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }
            }
        }
    }
}