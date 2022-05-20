using System;

namespace DiceGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ForstetteEllerAvslutt objFortsettEllerAvslutt = new ForstetteEllerAvslutt();
            Random rnd = new Random();
            bool status = true;
           // bool hvaErStatusen = true;
            //char jaEllerNei = 'J';
            char leggeTilEllerFjerne = '+';
            bool leggeTilEllerFjerneStatus = true;
            int yourTotalSum = 0;
            int motstanderSum = 0;

            Console.WriteLine("Dice Game!");
            Console.WriteLine("Første som treffer 21, vinner!");
            Console.WriteLine("NB!! Følg med på taksten, det kommer mer når du når 15 poeng!");

            while (status)
            {
                
                

                if (yourTotalSum >= 15 && yourTotalSum < 21)
                {
                    while (leggeTilEllerFjerneStatus)
                    {
                        Console.WriteLine("!!NB!! Ønsker du å trekke i fra eller legge til på neste kast?. Trykk + for å legge til, eller - for å trekke i fra");
                        leggeTilEllerFjerne = Console.ReadLine()[0];

                        if (leggeTilEllerFjerne != '+' && leggeTilEllerFjerne != '-')
                        {
                            Console.WriteLine("Ugyldig symbol, Prøv + eller -");
                            leggeTilEllerFjerneStatus = true;
                        }
                        else
                        {
                            leggeTilEllerFjerneStatus = false;
                        }
                    }

                }

                int diceNumber = rnd.Next(1, 7);
                int otherDiceNumber = rnd.Next(1, 7);
                int otherDicePlusOrMinus = rnd.Next(1, 3);

                Console.WriteLine("Rist hånda og kast terningen! Hvilket nr håper du på?");
                int shakeHand = Convert.ToInt32(Console.ReadLine());
                int nummer = shakeHand;

                if (motstanderSum < 15)
                {
                    motstanderSum = motstanderSum + otherDiceNumber;
                }

                else if (motstanderSum >= 15)
                {
                    if (otherDicePlusOrMinus == 1)
                    {
                        motstanderSum = motstanderSum + otherDiceNumber;
                    }
                    else if (otherDicePlusOrMinus == 2)
                    {
                        motstanderSum = motstanderSum - otherDiceNumber;
                    }
                }


                if (yourTotalSum < 15)
                {
                    leggeTilEllerFjerne = '+';
                }
                if (leggeTilEllerFjerne == '+')
                {
                    yourTotalSum = yourTotalSum + diceNumber;
                }
                if (leggeTilEllerFjerne == '-')
                {
                    yourTotalSum = yourTotalSum - diceNumber;

                }


                leggeTilEllerFjerneStatus = true;
                Console.WriteLine("Du håpet på: " + nummer + " og fikk: " + diceNumber);
                Console.WriteLine("Motstanderen din fikk: " + otherDiceNumber);
                Console.WriteLine("Din totale sum er: " + yourTotalSum);
                Console.WriteLine("Motstanderen sin sum er: " + motstanderSum);

               if (yourTotalSum > 21 || motstanderSum == 21)
               {
                    Console.WriteLine("Du tapte!");
                    objFortsettEllerAvslutt.FortsettAvslutt();
                    status = objFortsettEllerAvslutt.hvaErStatusen;
                    if(status == true)
                    {
                        yourTotalSum = 0;
                        motstanderSum = 0;
                    }
                    
                }
                else if (yourTotalSum == 21 || motstanderSum > 21)
                {
                    Console.WriteLine("Du vant!");
                    objFortsettEllerAvslutt.FortsettAvslutt();
                    status = objFortsettEllerAvslutt.hvaErStatusen;
                    if (status == true)
                    {
                        yourTotalSum = 0;
                        motstanderSum = 0;
                    }

                    // Console.WriteLine("vil du fortsette? Trykk \'J\' for JA
                    // og \'N\' for NEI");
                    // jaEllerNei = Console.ReadLine()[0];
                    // if (jaEllerNei == 'N') status = false;
                    // if (jaEllerNei == 'J')
                    // {
                    //  yourTotalSum = 0;
                    //    motstanderSum = 0;
                    //  }
                }
                Console.WriteLine(status);
                if (status == false)
                {
                    //status = false;
                    Console.WriteLine("Du har valgt å avslutte");
                }


            }
        }
    }
}
