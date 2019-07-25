using System;
using System.Collections.Generic;
using System.Text;
using WebCar.Domain.Entity;

namespace WebCar.Repository
{
    public class Repository
    {
        private IList<Car> ListCar;

        public Repository()
        {
            ListCar = new List<Car>();
        }




    }
}
