using System;
namespace IoC.ShareApplication
{
    /// <summary>
    /// Реализует интерфейс отправки сообщений пользователю
    /// </summary>
    public interface IShareApplication
    {
        /// <summary>
        /// Отправляет сообщение пользователю
        /// </summary>
        void Share();
    }
}
