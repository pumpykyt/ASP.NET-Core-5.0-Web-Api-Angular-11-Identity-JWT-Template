using MovieProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject.Auth.Interfaces
{
    public interface IJWTService
    {
        string CreateToken(User user);
    }
}
