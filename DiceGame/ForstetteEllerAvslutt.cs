using System; 
namespace DiceGame
{
     class ForstetteEllerAvslutt
    {
        public char jaEllerNei;
        public bool hvaErStatusen;
        public bool status;
        public void FortsettAvslutt()
        {
            Console.WriteLine("vil du fortsette? Trykk \'J\' for JA og \'N\' for NEI");
            jaEllerNei = Console.ReadLine()[0];
            if (jaEllerNei == 'N')
            {
                status = false;
            }
            else if(jaEllerNei == 'J')
            {
                status = true;
            }


        }
        public ForstetteEllerAvslutt()
        {
            hvaErStatusen = status;
        }
    }
}
