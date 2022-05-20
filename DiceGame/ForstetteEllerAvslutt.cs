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
            jaEllerNei = Convert.ToChar(Console.ReadLine());
            if (jaEllerNei == 'N' || jaEllerNei == 'n')
            {
                status = false;
            }
            else if(jaEllerNei == 'J' || jaEllerNei == 'j')
            {
                status = true;
            }


        }
        public bool setStatus()
        {
           return status;
        }
    }
}
