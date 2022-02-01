using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCars: IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                    {
                    //new Car
                    //{
                    //    name = "Tesla Model S",
                    //    shortDesc = "Быстрый автомобиль",
                    //    longDesc = "Красивый, быстрый и очень тихий автомобиль",
                    //    img = "https://3dnews.ru/assets/external/illustrations/2021/01/28/1031233/model_s.jpg",
                    //    price = 45000,
                    //    isFavorite = true,
                    //    available = true,
                    //    Category = _categoryCars.AllCategories.First()
                    //},
                    //new Car
                    //{
                    //    name = "Ford Fiesta",
                    //    shortDesc = "Тихий и спокойный",
                    //    longDesc = "Удобный автомобиль для городской жизни",
                    //    img = "https://www.gpas-cache.ford.com/guid/e1e17b95-3b03-38e0-ba44-eb8f45cacd18.png",
                    //    price = 11000,
                    //    isFavorite = false,
                    //    available = true,
                    //    Category = _categoryCars.AllCategories.Last()
                    //},
                    //new Car
                    //{
                    //    name = "BMW M3",
                    //    shortDesc = "Дерзкий и стильный",
                    //    longDesc = "Удобный автомобиль для городской жизни",
                    //    img = "https://www.bmw.cz/content/dam/bmw/common/all-models/m-series/m3-sedan/2020/overview/bmw-3-series-sedan-m-automobiles-gallery-impressions-m3-competition-02-desktop.jpg.asset.1597910081373.jpg",
                    //    price = 65000,
                    //    isFavorite = true,
                    //    available = true,
                    //    Category = _categoryCars.AllCategories.Last()
                    //},
                    //new Car
                    //{
                    //    name = "Mercedes C class",
                    //    shortDesc = "Уютный и большой",
                    //    longDesc = "Уютный автомобиль для городской жизни",
                    //    img = "https://www.la.mercedes-benz.com/en/passengercars/mercedes-benz-cars/models/c-class/coupe-c205/design/design-packages/nightpackage/_jcr_content/par/productinfotextimage/media2/slides/videoimageslide/image.MQ6.12.20190926215938.jpeg",
                    //    price = 40000,
                    //    isFavorite = false,
                    //    available = false,
                    //    Category = _categoryCars.AllCategories.Last()
                    //},
                    //new Car
                    //{
                    //    name = "Nissan Leaf",
                    //    shortDesc = "Бесшумный и экономный",
                    //    longDesc = "Удобный автомобиль для городской жизни",
                    //    img = "https://www-europe.nissan-cdn.net/content/dam/Nissan/nissan_europe/vehicles/2019_LEAF_Full_PES/Overview/2019-nissan-leaf-19tdieulhdpace107.jpg.ximg.l_6_m.smart.jpg",
                    //    price = 14000,
                    //    isFavorite = true,
                    //    available = true,
                    //    Category = _categoryCars.AllCategories.First()
                    //}
                };
            }
        }

        public IEnumerable<Car> getFavCars { get; set; }
        
        public Car getObjectCat(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
