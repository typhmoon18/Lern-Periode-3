namespace rndnmgtest
{
    internal class Program
    {
            class Pointsystem
            {
            private int points;

            public Pointsystem()
            {
                points = 0;
            }

            public void PointsAdd(int pointsplus)
            {
                points += pointsplus;
            }

            public void PointsDeduct(int pointsminus)
            {
                points -= pointsminus;

            
            }

            public int GetCurrentPoints()
            {
                return points;
            }
         }

        class Programm
        {
            static void Main()
            {
                Pointsystem pointssystem = new Pointsystem();


                Console.WriteLine("Pick a random number between 1 and 10");

                Random rnd = new Random();
                int number = rnd.Next(1, 10);

                int userinput = Convert.ToInt32(Console.ReadLine());
                bool wile = true;
                while (wile == true) {

                    if (userinput == number)
                    {
                        Console.WriteLine("Hell yeah, you're right");
                        pointssystem.PointsAdd(100);
                        Console.WriteLine("Your points are:" + pointssystem.GetCurrentPoints);
                        Console.WriteLine("Do you want to continue the game?");
                        string continuegame = Console.ReadLine();
                        if (continuegame == "no")
                        {
                            wile = false;
                        }
                        if (continuegame == "yes") 
                        { 
                        wile =true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You're not quite right");
                        Console.WriteLine("I am now going to give you a few hints:");
                    }

                    while (true)
                    {
                        if (userinput < number)
                        {
                            Console.WriteLine("The number is higher");
                        }
                        if (userinput > number)
                        {
                            Console.WriteLine("The number is lower");
                        }

                        Console.WriteLine("Now try to guess the Number again");
                        userinput = Convert.ToInt32(Console.ReadLine());

                        if (userinput == number)
                        {
                            Console.WriteLine("Very good, you won.");
                            pointssystem.PointsAdd(100); 
                            Console.WriteLine("Your points are:" + pointssystem.GetCurrentPoints);
                            Console.WriteLine("Do you want to continue the game?");
                            string yesorno = Console.ReadLine();
                            if (yesorno == "no")
                            {
                                wile = false;
                            }
                            if (yesorno == "yes")
                            {
                                wile = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Let's try again");
                            pointssystem.PointsDeduct(10); 
                        }
                    }
                }
                Console.WriteLine("Final score: " + pointssystem.GetCurrentPoints());
            }
        }
    
    }
}