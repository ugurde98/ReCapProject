using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach (var item in carManager.GetAll())
            //{
            //    Console.WriteLine(item.Description);
            //}
            Console.WriteLine("------------CarDetails------------");
            Cars();
            Console.WriteLine("------------Brands------------");
            Brands();
            Console.WriteLine("------------Colors------------");
            Colors();

        }

        private static void Colors()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetColors())
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Brands()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetBrands())
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void Cars()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.CarName + "-" + item.ColorName + "-" + item.BrandName + "-" + item.DailyPrice);
            }
        }
    }
}