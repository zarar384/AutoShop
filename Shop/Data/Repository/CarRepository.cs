﻿using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c=> c.Category);//метод расширения linq, получаем все объекты

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavorite).Include(c => c.Category);//получаем объекты isFavorite true 

        public Car getObjectCat(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId); //выбираем лишь один объект, у которого id будет равен carId
    }

}
