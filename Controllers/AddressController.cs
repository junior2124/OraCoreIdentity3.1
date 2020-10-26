using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OraCoreIdentity3._1.Data;
using OraCoreIdentity3.Models;

namespace OraCoreIdentity3._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private ApplicationDbContext _context;
        private IConfiguration _configuration;

        public AddressController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [Route(template:"List")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        
        public List<COMPANYADDRESS> GetList()
        {
            var addresses = _context.COMPANYADDRESS.ToList();

            return addresses;
        }
    }
}
