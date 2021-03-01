using System;

namespace Второрое_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, t, k = 0;
            byte m;
            bool isItNumber = false;



            do
            {
                bool b = true;
                for (int j = 0; j < 4; j++)
                {

                    isItNumber = byte.TryParse(Console.ReadLine(), out m);
                    if ((m == 2) || (m == 3))
                    {
                        b = false;
                    }
                }

                if (b)
                {
                    k++;
                }
            } while (isItNumber);
            Console.WriteLine(k + " учеников без 3 и 2");
            Console.ReadKey();
        }

    }   

}
























































/*

ЗАПУСКАЕМ
░ГУСЯ░▄▀▀▀▄░РАБОТЯГИ░░
▄███▀░◐░░░▌░░░░░░░
░░░░▌░░░░░▐░░░░░░░
░░░░▐░░░░░▐░░░░░░░
░░░░▌░░░░░▐▄▄░░░░░
░░░░▌░░░░▄▀▒▒▀▀▀▀▄
░░░▐░░░░▐▒▒▒▒▒▒▒▒▀▀▄
░░░▐░░░░▐▄▒▒▒▒▒▒▒▒▒▒▀▄
░░░░▀▄░░░░▀▄▒▒▒▒▒▒▒▒▒▒▀▄
░░░░░░▀▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▀▄
░░░░░░░░░░░▌▌░▌▌░░░░░
░░░░░░░░░░░▌▌░▌▌░░░░░
░░░░░░░░░▄▄▌▌▄▌▌░░░░░

*/





