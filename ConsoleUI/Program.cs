using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           // CarTest();

            //ColorTest();

            //BrandTest();

        }

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    var result = brandManager.GetAll();
        //    foreach (var brand in result.Data)
        //    {
        //        Console.WriteLine(brand.Name);
        //    }
        //}

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    var result = colorManager.GetAll();
        //    foreach (var color in result.Data)
        //    {
        //        Console.WriteLine(color.Name);
        //    }
        //}

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal(),new BrandManager(new EfBrandDal()));

        //    var result = carManager.GetCarDetails();
        //    if (result.Success == true)
        //    {
        //        foreach (var car in result.Data)
        //        {
        //            Console.WriteLine(car.ModelName + " - " + car.BrandName + " - " + car.ColorName);

        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }

        //}
    }
}
