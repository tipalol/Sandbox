using IoC.Gallery;
using IoC.ShareApplication;

namespace IoC
{
    class Program
    {
        static void Main(string[] args)
        {
            //В качестве способа отправки выбираем отправку по SMS
            var shareApplication = new BySMS();
            //Производим Dependency Injection (DI)
            var gallery = new GalleryApplication( shareApplication );
            
            gallery.Share();
        }
    }
}
