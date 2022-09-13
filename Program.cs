using System;

namespace changer
{
    class Program
    { 
        static void Main(string[] args)
        {
            var money = 0.0;
            var curs = 60;
            Console.WriteLine("Курс: "+curs);
            Console.WriteLine("Введите деньги которые нужно перевести в доллары ");
           money= Convert.ToDouble(Console.ReadLine());
            if (money < 500)
            {
                money -= 8;
            } 
                 else
            {
                money*=0.37;
                Console.WriteLine(money);
            }    
            
            
            
            money *= curs;
            Console.WriteLine("Вы получите: "+money);
        }
    }
}