using System;
using System.Collections.Generic;
using System.Text;
using WebCar.Business.Interface;
using WebCar.Domain.Entity;
using WebCar.Service.Interface;

namespace WebCar.Service
{
    public class CarService : ICarService
    {
        private readonly ICarBusiness _carBusiness;

        public CarService(ICarBusiness carBusiness)
        {
            _carBusiness = carBusiness;
        }
            
        
        public bool Insert(Car car)
        {
            return _carBusiness.Insert(car);   
        }

        public List<Car> List()
        {
            return _carBusiness.List();
        }

        public List<Car> ListarPorMarca(string marca)
        {
            return _carBusiness.ListarPorMarca(marca);
        }
    }
}
