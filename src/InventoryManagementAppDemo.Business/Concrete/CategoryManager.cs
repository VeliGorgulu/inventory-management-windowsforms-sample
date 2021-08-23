using InventoryManagementAppDemo.Business.Abstract;
using InventoryManagementAppDemo.DataAccess.Abstract;
using InventoryManagementAppDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementAppDemo.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
