using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp
{
    public class CategoriesRepository

    {
        

        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        public List<Category> Getall()
        {
            return _context.Category.ToList();
        }
        
    }
}
