using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TE4_Demo_Repository.DomainModel.Concrete;

namespace TE4_Demo_Repository.DomainModel.Abstract
{
    interface IRepository
    {
        //CRUD: CREATE READ UPDATE DELETE

        IEnumerable<Car> Cars {get;}

        void Add(Car c);
    }
}
