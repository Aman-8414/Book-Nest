using EcommProject_1144.DataAccess.Data;
using EcommProject_1144.DataAccess.Repository.IRepository;
using EcommProject_1144.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommProject_1144.DataAccess.Repository
{
   public class ShoppingCartRepository:Repository<ShoppingCart>,IShoppingCartRepository
    {
        private readonly ApplicationDbContext _context;
        public ShoppingCartRepository(ApplicationDbContext context):base(context)
        {
            _context = context;  
        }
    }
}
