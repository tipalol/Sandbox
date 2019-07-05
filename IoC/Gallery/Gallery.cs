using IoC.ShareApplication;

namespace IoC.Gallery
{
    /// <summary>
    /// Реализует галлерею изображений в проекте
    /// </summary>
    public class GalleryApplication
    {
        /// <summary>
        /// Интерфейс обмена картинками
        /// </summary>
        IShareApplication shareApplication;

        public GalleryApplication(IShareApplication shareApplication)
        {
            this.shareApplication = shareApplication;
        }

        /// <summary>
        /// Отправляет другим пользователям картинку
        /// </summary>
        public void Share()
        {
            shareApplication.Share();
        }
    }
}
