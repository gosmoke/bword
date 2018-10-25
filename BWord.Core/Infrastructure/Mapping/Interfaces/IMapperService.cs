using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWord.Core
{
    public interface IMapperService
    {
        IMappingExpression<TSource, TDestination> AddMap<TSource, TDestination>();
        void Create();
        TDestination Map<TSource, TDestination>(TSource model);
    }
}
