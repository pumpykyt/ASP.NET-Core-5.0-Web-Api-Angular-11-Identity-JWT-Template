using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject.DTO.Models.Result
{
    public class ResultSingleDTO<T> : ResultDTO
    {
        public T data { get; set; }
    }
}
