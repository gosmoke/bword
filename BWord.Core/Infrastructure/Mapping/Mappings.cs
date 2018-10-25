using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWord.Core
{
    public class Mappings
    {
        private IMapperService mapper;

        public Mappings(IMapperService mapper)
        {
            this.mapper = mapper;
        }

        public void Setup()
        {
            // Setup all mappings


            mapper.Create();
        }
    }
}
