using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WebCar.Domain.Entity;
using WebCar.Repository.Interfaces;

namespace WebCar.Repository
{
    public class CarRepository : ICarRepository
    {               
        private IList<Car> ListCar;
        public CarRepository()
        {
            ListCar = new List<Car>();
        }

        public bool Insert(Car car)
        {
            try
            {
               ListCar.Add(car);
                return true;
            }catch(Exception ex ){
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Car> List()
        {
            return ListCar.ToList();
        }

        public List<Car> ListarPorMarca(string marca)
        {
            return ListCar.Where(x => x.Marca == marca).ToList();
        }
    
    }
}
