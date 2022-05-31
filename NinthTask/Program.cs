using System;

namespace NinthTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            int maximumInterest = 50;
            Console.Write("Введите кол-во пиздюлей:");
            string pizdyuliInput = Console.ReadLine();
            decimal pizdyuli = Convert.ToDecimal(pizdyuliInput);
            // если значение меньше нолика, то переменной присваивается нолик 
            if (pizdyuli < 0)
            {
                Console.Write("Вы не можете получить меньше пиздюлей чем 0 никогда, так будет до конца жизни, вообще не получить тоже не выйдет");
                Console.WriteLine();
            }
            else
            {
                Console.Write("Bвeдитe процентную ставку пиздюлей : ");
                string interestInput = Console.ReadLine();
                decimal interest = Convert.ToDecimal(interestInput);
                if (interest < 0 || interest > maximumInterest)
                {
                    Console.WriteLine( "Процентная ставка не может быть отрицательнойили превышать " + maximumInterest);
                    interest = 0;
                }
                else
                {
                    Console.Write("Bвeдитe кол-во лет : ");
                    string durationInput = Console.ReadLine();
                    int duration = Convert.ToInt32(durationInput);
                    Console.WriteLine();
                    Console.WriteLine(); //буду пропускать сколько хочу нахуй
                    Console.WriteLine("Вложено пиздюлей:" + pizdyuli);
                    Console.WriteLine("Пpoцeнты по пиздюлям = " + interest + "%");
                    Console.WriteLine("Срок =" + duration + "лет");
                    Console.WriteLine();

                    int god1k = 1;
                    while (god1k <= duration)
                    {
                        decimal interestPaid;
                        interestPaid = pizdyuli * (interest / 100);
                        pizdyuli = pizdyuli + interestPaid;
                        pizdyuli = decimal.Round(pizdyuli, 2);
                        Console.WriteLine(god1k + "-" + pizdyuli);
                        god1k = god1k + 1;
                    }
                }

            }

            Console.WriteLine("Haжмитe <Enter> и разминайте ебучку бля. . .");

            Console.Read();
        }
    }
}

