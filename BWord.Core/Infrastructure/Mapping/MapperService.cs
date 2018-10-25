using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Configuration;

namespace BWord.Core
{
    public class MapperService : IMapperService
    {
        private IMapper mapper { get; set; }
        private MapperConfigurationExpression baseMappings { get; set; }
        private MapperConfiguration configuration { get; set; }

        public MapperService()
        {
            baseMappings = new MapperConfigurationExpression();

            configuration = new MapperConfiguration(baseMappings);
            mapper = new Mapper(configuration);

            mapper = configuration.CreateMapper();

            Mappings mappings = new Mappings(this);
            mappings.Setup();
        }

        public IMappingExpression<TSource, TDestination> AddMap<TSource, TDestination>()
        {
            return baseMappings.CreateMap<TSource, TDestination>();
        }

        public void Create()
        {
            configuration = new MapperConfiguration(baseMappings);
            mapper = configuration.CreateMapper();
        }

        public TDestination Map<TSource, TDestination>(TSource model)
        {
            return mapper.Map<TSource, TDestination>(model);
        }
    }
}
