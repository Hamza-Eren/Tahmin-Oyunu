using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace kelime_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 harfli ve büyük harf olacak şekilde kelime eklenebilir.
            string[] words = { "KALEM", "MASAL", "ÇATAL", "MESAJ", "BIÇAK", "DADAŞ", "CAMİA", "HABER", "JETON", "JOKER", "JOKEY", "RADAR", "NABIZ", "JİLET", "SABAH", "SABIR", "ÜÇGEN", "ZAFER" };
            Random random = new Random();
            string secim, word2;

            do
            {
                string word = words[random.Next(words.Length)];

                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("5 harfli bir kelime yazın: ");
                    word2 = Console.ReadLine().ToUpper();

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == word2[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(word2[i]);
                        }
                        else if (word.Contains(word2[i]))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(word2[i]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(word2[i]);
                        }
                    }
                    Console.WriteLine();
                } while (word != word2);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nTEBRİKLER BULDUNUZ !\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Tekrar oynamak ister misiniz (e/h): ");
                secim = Console.ReadLine();
            } while (secim == "e" || secim == "E");
        }
    }
}

