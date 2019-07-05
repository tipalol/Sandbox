﻿using System;
namespace IoC.ShareApplication
{
    /// <summary>
    /// Класс реализует отправку сообщений через СМС
    /// </summary>
    public class BySMS : IShareApplication
    {
        /// <summary>
        /// Отправляет сообщение пользователю
        /// </summary>
        public void Share()
        {
            Console.WriteLine("Sended by SMS");
        }
    }
}
