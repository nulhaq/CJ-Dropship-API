using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJ_Dropship_API.Models
{
    public class CjResponse
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public List<Data> Data { get; set; }
    }
}
