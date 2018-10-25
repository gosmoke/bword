using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWord.Model
{
    public class Response<T>
    {
        public T Content { get; set; }
        public List<ServiceMessage> Messages { get; set; } = new List<ServiceMessage>();
    }
}
