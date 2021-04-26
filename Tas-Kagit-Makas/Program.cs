using System;

namespace Tas_Kagit_Makas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SMTcoder");
            

            int gamerPoint = 0;
            int robotPoint = 0;
            for (; gamerPoint < 3 && robotPoint < 3;)
            {
                Console.WriteLine("\n Taş = 1 \n Kağıt = 2 \n Makas = 3 ");
                int gamer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You : " + gamer);
                Random random = new Random();
                int robot = random.Next(1, 4);
               Console.WriteLine("Robot : " + robot);

                if (gamer == 1 && robot == 2)
                {
                    Console.WriteLine("-------------------- you lost -------------------- ");
                    robotPoint++;
                    Console.WriteLine("Skor : " + " You Point : " + gamerPoint + " Robot Point : " + robotPoint);
                   
                }
                else if (gamer == 1 && robot == 3)
                {
                    Console.WriteLine("-------------------- you win -------------------- ");
                    gamerPoint++;
                    Console.WriteLine("Skor : " + " You Point : " + gamerPoint + " Robot Point : " + robotPoint);
                }
                if (gamer == 2 && robot == 1)
                {
                    Console.WriteLine("-------------------- you win -------------------- ");
                    gamerPoint++;
                    Console.WriteLine("Skor : " + " You Point : " + gamerPoint + " Robot Point : " + robotPoint);
                }
                else if (gamer == 2 && robot == 3)
                {
                    Console.WriteLine("-------------------- you lost --------------------");
                    robotPoint++;
                    Console.WriteLine("Skor : " + " You Point : " + gamerPoint + " Robot Point : " + robotPoint);
                }
                if (gamer == 3 && robot == 1)
                {
                    Console.WriteLine("-------------------- you win -------------------- ");
                    gamerPoint++;
                    Console.WriteLine( "Skor : " + " You Point : " + gamerPoint + " Robot Point : " + robotPoint);
                }
                else if (gamer == 3 && robot == 2)
                {
                    Console.WriteLine("-------------------- you win  --------------------");
                    gamerPoint++;
                    Console.WriteLine( "Skor : " + " You Point : " + gamerPoint + " Robot Point : " + robotPoint);
                }
                if (gamer ==1 && robot==1 || gamer == 2 && robot == 2 || gamer == 3 && robot == 3)
                {
                    Console.WriteLine("Berabere ( draw )");
                    Console.WriteLine("Skor : " + " You Point : " + gamerPoint + " Robot Point : " + robotPoint);
                }
            }
            Console.WriteLine("");

            if (gamerPoint > robotPoint)
            {
                Console.WriteLine(" ************************** GAME OVER **************************");
                Console.WriteLine("YOU WİN  Wow :)" );
                Console.WriteLine("Skor : " + " You = " + gamerPoint + " Robot =  " + robotPoint );
            }
            else if (gamerPoint < robotPoint)
            {
                Console.WriteLine(" ************************** GAME OVER **************************");
                Console.WriteLine(" YOU LOSE :( ");
                Console.WriteLine("Skor : " + " You = " + gamerPoint + " Robot =  " + robotPoint);
               
            }
            else
            {
                Console.WriteLine(" ************************** GAME OVER **************************");
                Console.WriteLine("Berabere Bitti ( the draw is over )");
            }
        }
    }
}
