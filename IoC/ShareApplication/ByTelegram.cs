using System;
namespace IoC.ShareApplication
{
    /// <summary>
    /// Реализует отправку сообщений в Telegram
    /// </summary>
    public class ByTelegram : IShareApplication
    {
        /// <summary>
        /// Отправляет сообщение пользователю
        /// </summary>
        public void Share()
        {
            Console.WriteLine("Sended by Telegram");
        }
    }
}
