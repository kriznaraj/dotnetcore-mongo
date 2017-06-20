using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using test.Models;
using test.Repository;

namespace test.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;   
        }

        [HttpGet("")]
        public async Task<IList<User>> GetAsync()
        {
            return await _userRepository.GetUsersAsync();
        }

        [HttpPost("")]
        public async Task PostAsync(User user)
        {
            await _userRepository.AddUser(user);
        }
    }
}
