using System;
using System.Collections.Generic;
using System.Text;
using WebCar.Domain.Entity;

namespace WebCar.Repository.Interfaces
{
    public interface ICarRepository
    {
        bool Insert(Car car);

        List<Car> List();

        List<Car> ListarPorMarca(string marca); 
    }
}
