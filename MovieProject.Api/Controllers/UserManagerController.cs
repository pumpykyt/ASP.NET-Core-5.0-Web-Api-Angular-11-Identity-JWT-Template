using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieProject.DAL;
using MovieProject.DAL.Entities;
using MovieProject.DTO.Models;
using MovieProject.DTO.Models.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagerController : ControllerBase
    {
        private readonly EFContext _context;
        private readonly UserManager<User> _userManager;

        public UserManagerController(EFContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public IEnumerable<UserDTO> getUsers()
        {
            List<UserDTO> data = new List<UserDTO>();
            var dataFromDB = _context.Users.Where(t => t.Email != "admin@gmail.com").ToList();
            foreach (var item in dataFromDB)
            {
                UserDTO temp = new UserDTO();
                temp.Email = item.Email;
                temp.Id = item.Id;
                data.Add(temp);
            }
            return data;
        }


        //localhost:12312/api/UserManager/RemoveUser/89as7d89a7a8d09a8sd

        [HttpPost("RemoveUser/{id}")]
        public ResultDTO RemoveUser([FromRoute] string id)
        {
            try
            {
                var user = _context.Users.SingleOrDefault(t => t.Id == id);
                _context.Users.Remove(user);
                return new ResultDTO
                {
                    Status = 200,
                    Message = "OK"
                };
            }
            catch (Exception e)
            {
                List<string> temp = new List<string>();
                temp.Add(e.Message);
                return new ResultErrorDTO
                {
                    Status = 500,
                    Message = "ERROR",
                    Errors = temp
                };
            }
        }

        //localhost:12312/api/UserManager/98d789a789asd7a98sd
        [HttpGet("{id}")]
        public UserDTO GetUser([FromRoute] string id)
        {
            var user = _context.Users.SingleOrDefault(t => t.Id == id);
            UserDTO model = new UserDTO();
            model.Id = user.Id;
            model.Email = user.Email;
            return model;
        }

        [HttpPost("editUser/{id}")]
        public ResultDTO EditUser([FromRoute] string id, [FromBody] UserDTO model)
        {
            var user = _context.Users.SingleOrDefault(t => t.Id == id);
            user.Email = model.Email;
            _context.SaveChanges();
            return new ResultDTO
            {
                Status = 200,
                Message = "OK"
            };
        }
    }
}
