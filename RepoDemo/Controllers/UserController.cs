using Microsoft.AspNetCore.Mvc;
using RepositoryDemo.business.Entities;
using RepositoryDemo.business.Interfaces;
using RepositoryDemo.business.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RepoDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            try
            {
                return await userService.GetAllAsync();
            }
            catch
            {
                return new List<User>();
            }
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<User> Get(int id)
        {
            return await userService.GetByIdAsync(id);
        }

        [HttpPost()]
        public async void Insert(User user)
        {
            await userService.AddAsync(user);
        }

        // POST api/<UserController>
        [HttpPost("edit")]
        public async void edit(User user)
        {
            await userService.UpdateAsync(user);
        }

        // DELETE api/<UserController>/5
        [HttpPost("delete/{id}")]
        public async void Delete(int id)
        {
            await userService.DeleteAsync(id);
        }
    }
}
