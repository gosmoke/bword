using BWord.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BWord.Core
{
    public class BWordService : IBWordService
    {
        private BWordDataRepository DataRepository { get; set; }
        private MapperService MapperService { get; set; }
        private LoggerService LoggerService { get; set; }

        public BWordService(BWordDataRepository dataRepository, MapperService mapper, LoggerService logger)
        {
            DataRepository = dataRepository;
            MapperService = mapper;
            LoggerService = logger;
        }


    }
}
