using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStudent.Shared.Dtos
{
    public class ResultDto
    {
        public bool isSuccess { get; set; }
        public string? message { get; set; } 
    }
    public class ResultDto<T>: ResultDto
    {
        public T? Value { get; set; } 
        public List<T>? Values { get; set; } = null;

    }

}
