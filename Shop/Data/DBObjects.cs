using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initital(AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value)); //выбираем все объекты, берем значения и записываем как отдельные объекты

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model S",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Красивый, быстрый и очень тихий автомобиль",
                        img = "https://3dnews.ru/assets/external/illustrations/2021/01/28/1031233/model_s.jpg",
                        price = 45000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Ford Fiesta",
                        shortDesc = "Тихий и спокойный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://www.gpas-cache.ford.com/guid/e1e17b95-3b03-38e0-ba44-eb8f45cacd18.png",
                        price = 11000,
                        isFavorite = false,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://www.bmw.cz/content/dam/bmw/common/all-models/m-series/m3-sedan/2020/overview/bmw-3-series-sedan-m-automobiles-gallery-impressions-m3-competition-02-desktop.jpg.asset.1597910081373.jpg",
                        price = 65000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Mercedes C class",
                        shortDesc = "Уютный и большой",
                        longDesc = "Уютный автомобиль для городской жизни",
                        img = "https://www.la.mercedes-benz.com/en/passengercars/mercedes-benz-cars/models/c-class/coupe-c205/design/design-packages/nightpackage/_jcr_content/par/productinfotextimage/media2/slides/videoimageslide/image.MQ6.12.20190926215938.jpeg",
                        price = 40000,
                        isFavorite = false,
                        available = false,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Nissan Leaf",
                        shortDesc = "Бесшумный и экономный",
                        longDesc = "Удобный автомобиль для городской жизни",
                        img = "https://www-europe.nissan-cdn.net/content/dam/Nissan/nissan_europe/vehicles/2019_LEAF_Full_PES/Overview/2019-nissan-leaf-19tdieulhdpace107.jpg.ximg.l_6_m.smart.jpg",
                        price = 14000,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    }
                    );
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null) // проверяем, заполнена ли переменная. Если есть - возвращаем. Если пустая - создаем новый список категорий
                {
                    var list = new Category[]
                    {
                        new Category{categoryName = "Электромобили", desc = "Современный вид транспорта"},
                        new Category{categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                    };


                    category = new Dictionary<string, Category>();//выделение памяди под нужн. переменные
                    foreach (Category el in list)//перебираем все элементы внутри списка
                        category.Add(el.categoryName, el);//добавл все элементы внутрь списка category (ключ - имя категории, значение - сам объект)
                }
                return category;
            }


        }
    }

}
