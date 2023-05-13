using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class UsersController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context )
        {

         _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> Getusers()
        {

            var Users = await _context.Users.ToListAsync();

            return Users;

        }

        [HttpGet ("{id}") ]
        public async Task<ActionResult<AppUser>> Getuser(int id)
        {

             return await _context.Users.FindAsync(id);

        }

    }
}