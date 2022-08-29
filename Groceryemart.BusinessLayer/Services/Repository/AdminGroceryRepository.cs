using GroceryEmart.DataLayer;
using GroceryEmart.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace GroceryEmart.BusinessLayer.Services.Repository
{
    public class AdminGroceryRepository : IAdminGroceryRepository
    {
        /// <summary>
        /// Creating referance Variable of DbContext
        /// </summary>
        private readonly GroceryemartDbContext _groceryemartDbContext;
        /// <summary>
        /// Injecting Referance variable in AdminGroceryRepository class Constructor
        /// </summary>
        /// <param name="context"></param>
        public AdminGroceryRepository(GroceryemartDbContext groceryemartDbContext)
        {
            _groceryemartDbContext = groceryemartDbContext;
        }
        /// <summary>
        /// Add New Category in Sql database table
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public async Task<Category> AddCategory(Category category)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add New Product In sql product table
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Product> AddProduct(Product product)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get All order from ProductOrder table
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ProductOrder>> AllOrder()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get all Product from product table
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> AllProduct()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get all User from ApplicationUser table
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ApplicationUser>> GetAllUser()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get category by CategoryId
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Category> GetCategoryById(int Id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get ordere by Order Id
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns></returns>
        public async Task<ProductOrder> GetOrderById(int OrderId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get product by Id from Product tbale
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public async Task<Product> GetProductById(int ProductId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Remove category from Category tbale
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<bool> RemoveCategory(int Id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove Product from Product table
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public async Task<bool> RemoveProduct(int ProductId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Upadet category in sql Category table
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public async Task<Category> UpdateCategory(int Id, Category category)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Upadet Product in Sql Product table
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Product> UpdateProduct(int Id, Product product)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
