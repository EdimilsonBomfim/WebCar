using System;
using System.Collections.Generic;
using System.Text;
using WebCar.Domain.Entity;

namespace WebCar.Business.Interface
{
    public interface ICarBusiness
    {
        bool Insert(Car car);

        List<Car> List();

        List<Car> ListarPorMarca(string marca);

    }
}
