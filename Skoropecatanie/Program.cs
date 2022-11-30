using Newtonsoft.Json;
using Skoropecatanie;
using System.Data;
using System.Diagnostics;
internal class Program
{
    static void Main(string[] args)
    {
        Kod();
    }
    static void Kod()
    { 
        Thread thread = new Thread(x =>
{
    int q = 1;
    while (q != 61)
    {
        Console.SetCursorPosition(0, 15);
        Console.WriteLine("  ");
        Console.WriteLine(q);
        Thread.Sleep(1000);
        q++;
    }
});
        Thread thread2 = new Thread(x =>
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(60000);
            stopWatch.Stop();
        });
        Console.WriteLine("Введи ваше имя");
        Info user = new Info();
        user.Name = Console.ReadLine();
        string nam = user.Name;
        Console.Clear();
        Console.WriteLine("Напечатайте текст, когда будете готовы нажмите enter:");
        ConsoleKeyInfo clavisha = Console.ReadKey();
        if (clavisha.Key == ConsoleKey.Enter)
        {
            thread.Start();
            thread2.Start();
            Console.SetCursorPosition(0, 1);
            string text = ("Игрокам нужно будет выбрать подходящего крестьянина для торговли. В Майнкрафте жители деревни могут иметь разные должности, например библиотекаря, фермера и так далее. И они могут обменивать изумруды на несколько предметов. Это очень важно, потому что некоторые из них могут обменивать изумруды на предметы, которые действительно легко фармить. Следовательно, лучше всего найти сельского жителя с наиболее простой торговлей, такой как бумага, палки чтобы торговать изумрудами, они скоро заметят, что торговля не так уж и дешева. Жители обычно обменивают только один изумруд на большое количество предметов взамен. Из-за этого игрокам придется фармить тонны этого конкретного предмета, чтобы получить пригоршню изумрудов. Но это можно оптимизировать.");
            Console.WriteLine(text);
            int i = 0;
            while (thread2.IsAlive)
            {
                char c = Console.ReadKey(true).KeyChar;
                if (c == text[i])
                {
                    Console.SetCursorPosition(i, 1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(c);
                    Console.ResetColor();
                    i++;
                }
            }
            user.Min = i;
            user.Sec = i / 60;
            Console.SetCursorPosition(0, 13);
            Console.WriteLine($"Введено символов {i}, введено символов в минуту {user.Min}, введено символов в секунду {user.Sec}");
            Console.ReadKey();

            Tabl men = new Tabl();
            men.exel(user);
            Console.ReadKey();
            Kod();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Программа завершена");
        }
    }
}
