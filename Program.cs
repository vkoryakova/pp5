using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP5_var10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Предложение состоит из слов, между которыми выставлен разделитель 
             * величиной в один пробел, после последнего слова поставлена точка. 
             * Найти длину самого длинного слова в предложении. */
            Console.WriteLine("Введите текст: ");
            string a = Console.ReadLine();
            string[] words = a.Split('.', ',', ' ', '!', '?', ':', ';');
            int max = 0;
            foreach (string word in words)
            {
                if (word.Length > max)
                    max= word.Length;
            }
            Console.WriteLine(max);
        }
    }
}
