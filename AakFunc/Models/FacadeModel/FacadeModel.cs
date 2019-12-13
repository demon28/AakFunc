using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AakFunc.Models.FacadeModel
{
    public class FacadeModel<T>
    {
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "成功！";

        public T Data { get; set; }
    }
}
