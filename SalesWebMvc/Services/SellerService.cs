using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class SellerService
    {

        private readonly SalesWebMvcContext _context;


        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAssync()
       {
            return await _context.Seller.ToListAsync();
         
        }
    }
}
