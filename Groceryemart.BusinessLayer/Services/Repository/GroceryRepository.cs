using GroceryEmart.DataLayer;
using GroceryEmart.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryEmart.BusinessLayer.Services.Repository
{
    public class GroceryRepository : IGroceryRepository
    {
        /// <summary>
        /// Creating referance Variable of DbContext
        /// </summary>
        private readonly GroceryemartDbContext _groceryemartDbContext;
        public GroceryRepository(GroceryemartDbContext groceryemartDbContext)
        {
            _groceryemartDbContext = groceryemartDbContext;
        }
        /// <summary>
        /// Get All Poduct from Product table
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get Product from Product table by Product Id
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public async Task<Product> GetProductById(int ProductId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get List of Category from Category table
        /// </summary>
        /// <returns></returns>
        public IList<Category> CategoryList()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Place Order and verify registred user
        /// </summary>
        /// <param name="ProductId"></param>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public async Task<bool> PlaceOrder(int ProductId, int UserId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get product by name from Product table
        /// </summary>
        /// <param name="ProductName"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> ProductByName(string ProductName)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get product by categoryId from Product table
        /// </summary>
        /// <param name="CatId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetProductByCategory(int CatId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
