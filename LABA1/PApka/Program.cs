using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace laba1
{
    //Омельченко Артем ІК-13 в-20
    class Program
    {

        static void Main(string[] args)
        {

            //1

            //string text = File.ReadAllText("C:\\Users\\artem\\Desktop\\Sample.txt\\"); //Ініціалізуємо строку, дані в яку записано з файлу на компютері
            string text = "The vote takes place as Johnson and his governing Conservatives are surrounded by scandals and crises so bad that members of his own party have publicly called for his resignation. Indeed, the most pressing of these scandals, which saw Johnson fined by police for breaching his own Covid rules during the 2020 lockdown, might have led to his ousting from office under normal circumstances.";
            var Texts = new List<string>();//створюємо колекцію
            Texts.AddRange(text.Split(" ")) ;//додаємо слова у колецію зі строки text, ділячи її по " "
            foreach (var Text in Texts)//виводимо елементи колекції за допомогою циклу foreach
            {
                Console.Write(Text + " ");
            }
            int CountText = Texts.Count;//за допомогоюоператора підраховуємо кількість елемннтів колекції
            Console.WriteLine();
            Console.WriteLine($"Кiлькiсть елементiв колекцiї {CountText}"); //підрахунки

            Console.WriteLine("Виберiть напрям друку елементiв з словника: 1(вперед) або 2(назад)");
        pack://місце повернення у разі помилки вводу
            int Vubir = Int32.Parse(Console.ReadLine());// ввід ззмінно для вибору напрямку руху
            if (Vubir == 1)// у разі правди виконується преший цикл
            {
                Console.WriteLine("Виберiть номер початкового елементу");

                for (int i = Int32.Parse(Console.ReadLine()); i < Texts.Count; i++)// цикл виводу з вибраного числа у звичайному напрямку
                {
                    Console.WriteLine(Texts[i]);//вивід елементів
                }

            }
            else if (Vubir == 2)// у разі правди виконується другий цикл
            {
                Console.WriteLine("Виберiть номер початкового елементу");

                for (int i = Int32.Parse(Console.ReadLine()) - 1; i >= 0; i--)// цикл виводу з вибраного числа у зворотньому напрямку 
                {

                    Console.WriteLine(Texts[i]);//вивід елементів
                }

            }
            else // у разі не правди повертаємося до вводу
            {
                Console.WriteLine("Не парвильно");
                goto pack;// поверненнядо початку вводу через оператор goto
            }

            //2
            List<Dictionary<int, string>> ARRDICT = new List<Dictionary<int, string>>
            {
               new Dictionary<int, string>
               {
                    [1] = "Tom",
                    [2] = "Sam",
                    [3] = "Bob"
               },
               new Dictionary<int, string>
               {
                    [1] = "Artem",
                    [2] = "Kaly",
                    [3] = "Din"
               },
                new Dictionary<int, string>
               {
                    [1] = "Alla",
                    [2] = "Olga",
                    [3] = "Aleksandr"
               },
               new Dictionary<int, string>
               {
                    [1] = "Sam",
                    [2] = "Kara",
                    [3] = "Katia"
               }

             };
            foreach (Dictionary<int, string> dict in ARRDICT)
            {
                foreach(KeyValuePair<int,String> i in dict)
                {
                    Console.WriteLine($"key: {i.Key}  value: {i.Value}");
                }
                
            }
            Console.WriteLine("Хочете знайти елемент словника за ключем");//пошук елемента за ключем
            int k = Int32.Parse(Console.ReadLine());
            foreach (Dictionary<int, string> dict in ARRDICT)
            {
                Console.WriteLine("Name "+ dict[k]);
            }

            Console.WriteLine("Вивiд json");
            string json = JsonConvert.SerializeObject(ARRDICT);//запис словника в json
            Console.WriteLine(json + " "); //виід json

            if (File.Exists("JsonLaba1.json"))// перевірка на існування файлу (якщо не існує, то виконати)
            {
                File.Create("JsonLaba1.json");//створити файл
                File.WriteAllText("JsonLaba1.json", json);//записати дані
            }

            //3

            Console.WriteLine("Число:");
            int line = Int32.Parse(Console.ReadLine());// ініціалізація змінноюта надання їй значення

            Random rand = new Random();
            int[] value = new int[25]; //створення масиву рандомних чисел
            
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = rand.Next(10, 100);//надання значення елементам масиву
                Console.Write(value[i] + "  ");//вивід елементів
            }
            
            var result =        //пошук чисел з масиву рандомних меншого за вибране число
               ( from n in value
                where n %10== line
                select n).FirstOrDefault();
            Console.WriteLine();
            Console.WriteLine("Потрiбне");//вивід чисел з result
            Console.WriteLine(result);
            
            var result2 = value.FirstOrDefault(n => n % 10 == line);
            Console.WriteLine(result2);

            /////////
            ///

            Console.WriteLine("Hello, Peater");
            Console.WriteLine("Hello, Peater");
            Console.WriteLine("Hello, Peater");

            Console.WriteLine("Hello, Peater");

            Console.WriteLine("Hello, Peater");

            Console.WriteLine("Hello, Peater");









        }
    }
}