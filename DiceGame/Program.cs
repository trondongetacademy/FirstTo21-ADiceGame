using System;

namespace DiceGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool status = true;
            char jaEllerNei = 'J';
            char leggeTilEllerFjerne = '+';
            Console.WriteLine("Dice Game!");
            Console.WriteLine("Første som treffer 21, vinner!");

            int yourTotalSum = 0;
            int motstanderSum = 0;

            while (status)
            {
                if (jaEllerNei == 'N')
                {
                    status = false;
                    Console.WriteLine("Du har valgt å avslutte");
                }

                int diceNumber = rnd.Next(1, 7);
                int otherDiceNumber = rnd.Next(1, 7);
                int otherDicePlusOrMinus = rnd.Next(1, 3);

                Console.WriteLine("Rist hånda og kast terningen! Hvilket nr håper du på?");
                int shakeHand = Convert.ToInt32(Console.ReadLine());


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


                int nummer = shakeHand;
                switch (nummer)
                {
                    case 1:
                        Console.WriteLine("Du håpet på: " + nummer + " og fikk: " + diceNumber);
                        Console.WriteLine("Motstanderen din fikk: " + otherDiceNumber);
                        Console.WriteLine("Din totale sum er: " + yourTotalSum);
                        Console.WriteLine("Motstanderen sin sum er: " + motstanderSum);
                        if (yourTotalSum >= 15 && yourTotalSum < 22)
                        {
                            Console.WriteLine("!!NB!! Ønsker du å trekke i fra eller legge til på neste kast?. Trykk + for å legge til, eller - for å trekke i fra");
                            leggeTilEllerFjerne = Console.ReadLine()[0];
                        }
                        break;

                    case 2:
                        Console.WriteLine("Du håpet på: " + nummer + " og fikk: " + diceNumber);
                        Console.WriteLine("Motstanderen din fikk: " + otherDiceNumber);
                        Console.WriteLine("Din totale sum er: " + yourTotalSum);
                        Console.WriteLine("Motstanderen sin sum er: " + motstanderSum);
                        if (yourTotalSum >= 15 && yourTotalSum < 22)
                        {
                            Console.WriteLine("!!NB!! Ønsker du å trekke i fra eller legge til på neste kast?. Trykk + for å legge til, eller - for å trekke i fra");
                            leggeTilEllerFjerne = Console.ReadLine()[0];
                        }
                        break;

                    case 3:
                        Console.WriteLine("Du håpet på: " + nummer + " og fikk: " + diceNumber);
                        Console.WriteLine("Motstanderen din fikk: " + otherDiceNumber);
                        Console.WriteLine("Din totale sum er: " + yourTotalSum);
                        Console.WriteLine("Motstanderen sin sum er: " + motstanderSum);
                        if (yourTotalSum >= 15 && yourTotalSum < 22)
                        {
                            Console.WriteLine("!!NB!! Ønsker du å trekke i fra eller legge til på neste kast?. Trykk + for å legge til, eller - for å trekke i fra");
                            leggeTilEllerFjerne = Console.ReadLine()[0];
                        }
                        break;

                    case 4:
                        Console.WriteLine("Du håpet på: " + nummer + " og fikk: " + diceNumber);
                        Console.WriteLine("Motstanderen din fikk: " + otherDiceNumber);
                        Console.WriteLine("Din totale sum er: " + yourTotalSum);
                        Console.WriteLine("Motstanderen sin sum er: " + motstanderSum);
                        if (yourTotalSum >= 15 && yourTotalSum < 22)
                        {
                            Console.WriteLine("!!NB!! Ønsker du å trekke i fra eller legge til på neste kast?. Trykk + for å legge til, eller - for å trekke i fra");
                            leggeTilEllerFjerne = Console.ReadLine()[0];
                        }
                        break;

                    case 5:
                        Console.WriteLine("Du håpet på: " + nummer + " og fikk: " + diceNumber);
                        Console.WriteLine("Motstanderen din fikk: " + otherDiceNumber);
                        Console.WriteLine("Din totale sum er: " + yourTotalSum);
                        Console.WriteLine("Motstanderen sin sum er: " + motstanderSum);
                        if (yourTotalSum >= 15 && yourTotalSum < 22)
                        {
                            Console.WriteLine("!!NB!! Ønsker du å trekke i fra eller legge til på neste kast?. Trykk + for å legge til, eller - for å trekke i fra");
                            leggeTilEllerFjerne = Console.ReadLine()[0];
                        }
                        break;

                    case 6:
                        Console.WriteLine("Du håpet på: " + nummer + " og fikk: " + diceNumber);
                        Console.WriteLine("Motstanderen din fikk: " + otherDiceNumber);
                        Console.WriteLine("Din totale sum er: " + yourTotalSum);
                        Console.WriteLine("Motstanderen sin sum er: " + motstanderSum);
                        if (yourTotalSum >= 15 && yourTotalSum < 22)
                        {
                            Console.WriteLine("!!NB!! Ønsker du å trekke i fra eller legge til på neste kast?. Trykk + for å legge til, eller - for å trekke i fra");
                            leggeTilEllerFjerne = Console.ReadLine()[0];
                        }

                        break;
                    default:
                        Console.WriteLine("Ugyldig tall");
                        break;

                }





                if (yourTotalSum > 21)
                {
                    Console.WriteLine("Du tapte!");
                    Console.WriteLine("vil du fortsette? Trykk \'J\' for JA og \'N\' for NEI");
                    jaEllerNei = Console.ReadLine()[0];
                    if (jaEllerNei == 'N') status = false;
                    if (jaEllerNei == 'J')
                    {
                        yourTotalSum = 0;
                        motstanderSum = 0;
                    }
                }
                if (yourTotalSum == 21)
                {
                    Console.WriteLine("Du vant!");
                    Console.WriteLine("vil du fortsette? Trykk \'J\' for JA og \'N\' for NEI");
                    jaEllerNei = Console.ReadLine()[0];
                    if (jaEllerNei == 'N') status = false;
                    if (jaEllerNei == 'J')
                    {
                        yourTotalSum = 0;
                        motstanderSum = 0;
                    }
                }
                if (motstanderSum > 21)
                {
                    Console.WriteLine("Du vant!");
                    Console.WriteLine("vil du fortsette? Trykk \'J\' for JA og \'N\' for NEI");
                    jaEllerNei = Console.ReadLine()[0];
                    if (jaEllerNei == 'N') status = false;
                    if (jaEllerNei == 'J')
                    {
                        yourTotalSum = 0;
                        motstanderSum = 0;
                    }
                }
                if (motstanderSum == 21)
                {
                    Console.WriteLine("Du tapte!");
                    Console.WriteLine("vil du fortsette? Trykk \'J\' for JA og \'N\' for NEI");
                    jaEllerNei = Console.ReadLine()[0];
                    if (jaEllerNei == 'N') status = false;
                    if (jaEllerNei == 'J')
                    {
                        yourTotalSum = 0;
                        motstanderSum = 0;
                    }
                }




                    
                




                
            }
            
        }
    }
}
