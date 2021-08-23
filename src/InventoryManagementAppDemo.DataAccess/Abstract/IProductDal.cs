using InventoryManagementAppDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementAppDemo.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
