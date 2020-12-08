using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject.DTO.Models.Result
{
    public class ResultErrorDTO : ResultDTO
    {
        public List<string> Errors { get; set; }
    }
}
