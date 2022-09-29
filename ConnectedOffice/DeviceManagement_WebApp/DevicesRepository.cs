using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp
{
    public class DevicesRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        public List<Device> Getall()
        {
            return _context.Device.ToList();
        }
    }
}
