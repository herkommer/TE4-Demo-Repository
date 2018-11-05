using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TE4_Demo_Repository.DomainModel.Abstract;

namespace TE4_Demo_Repository.DomainModel.Concrete
{
    class Repository : IRepository
    {
        //borde kopplas till en DB eller liknande
        //men vi fejkar det tillsvidare

        private List<Car> cars;

        public Repository()
        {
            cars = new List<Car>();
            cars.Add(new Car() { Make = "Volvo", Model = "V70", Color = "Red", Milage = 12900 });
            cars.Add(new Car() { Make = "Volvo", Model = "V40", Color = "Blue", Milage = 1900 });
            cars.Add(new Car() { Make = "Volvo", Model = "V60", Color = "Red", Milage = 54900 });
            cars.Add(new Car() { Make = "Audi", Model = "A3", Color = "Red", Milage = 1250 });
            cars.Add(new Car() { Make = "Volvo", Model = "XC90", Color = "Black", Milage = 2900 });
            cars.Add(new Car() { Make = "Volvo", Model = "V70", Color = "Red", Milage = 900 });
        }

        public IEnumerable<Car> Cars
        {
            get { return cars; }
        }

        public void Add(Car c)
        {
            cars.Add(c);
        }
    }
}
