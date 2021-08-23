using InventoryManagementAppDemo.Business.Abstract;
using InventoryManagementAppDemo.Business.Uitilities;
using InventoryManagementAppDemo.Business.ValidationRules.FluentValidation;
using InventoryManagementAppDemo.DataAccess.Abstract;
using InventoryManagementAppDemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementAppDemo.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            Validate(product);
            _productDal.Add(product);
        }
        public void Update(Product product)
        {

            Validate(product);
            _productDal.Update(product);

        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch
            {
                throw new Exception("An error occurred while deleting.");
            }
        }

        public List<Product> GetAll()
        {
            try
            {
                return _productDal.GetAll();
            }
            catch
            {
                throw new Exception("An error occurred while getting products.");
            }

        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            try
            {
                return _productDal.GetAll(p => p.CategoryId == categoryId);
            }
            catch
            {
                throw new Exception("An error occurred while getting product.");
            }
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            try
            {
                if(String.IsNullOrEmpty(productName))
                {
                    return _productDal.GetAll();
                }
                else
                {
                    return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
                }  
            }
            catch
            {
                throw new Exception("An error occurred while getting product.");
            }
        }

        public void Validate(Product product)
        {
            try
            {
                ValidationTool.Validate(new ProductValidator(), product);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }
        
    }
}
