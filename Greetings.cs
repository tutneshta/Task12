﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Channels;

namespace Task12
{
    internal static class Greetings
    {
        public static void GreetingsUser()
        {
            Console.WriteLine("Приветствую!!!, введите Логин");
            var login = Console.ReadLine();
            Console.WriteLine("Введите Имя");
            var name = Console.ReadLine();
            var user = new User(login, name);


            if (login != null && user.IsPremium == false)
            {
                ShowAds();
            }
        }

        private static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}