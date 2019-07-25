using WebCar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using WebCar.Business.Interface;
using WebCar.Repository.Interfaces;

namespace WebCar.Business
{
    public class CarBusiness : ICarBusiness
    {

        private readonly ICarRepository _carRepository;

        //Injecao de dependencia
        public CarBusiness(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }


        public bool Insert(Car car)
        {
            return _carRepository.Insert(car);
        }

        public List<Car> List()
        {
            return _carRepository.List();
        }

        public List<Car> ListarPorMarca(string marca)
        {
            return _carRepository.ListarPorMarca(marca);
        }
    }
}
