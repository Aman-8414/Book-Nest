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
   public class OrderHeaderRepository:Repository<OrderHeader>,IOrderHeaderRepository
    {
        private readonly ApplicationDbContext _context;
        public OrderHeaderRepository(ApplicationDbContext context):base(context)
        {
            _context = context;  
        }
    }
}
