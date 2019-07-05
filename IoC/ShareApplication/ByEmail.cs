using System;
namespace IoC.ShareApplication
{
    /// <summary>
    /// Класс реализует отправку сообщений по Email
    /// </summary>
    public class ByEmail : IShareApplication
    {
        /// <summary>
        /// Отправляет сообщение пользователю
        /// </summary>
        public void Share()
        {
            Console.WriteLine("Sended by Email");
        }
    }
}
