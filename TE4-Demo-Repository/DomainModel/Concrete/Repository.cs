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
        public IEnumerable<Car> Cars => throw new NotImplementedException();

        public void Add(Car c)
        {
            throw new NotImplementedException();
        }
    }
}
