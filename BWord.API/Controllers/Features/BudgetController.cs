using BWord.Core;
using BWord.Model;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BWord.API.Controllers.Features
{
    [RoutePrefix("v1/budget")]
    public class BudgetController : ApiController
    {
        private IBWordService bwordService;
        private ILoggerService loggerService;

        public BudgetController(IBWordService bwordService, ILoggerService loggerService)
        {
            this.bwordService = bwordService;
            this.loggerService = loggerService;
        }

        [Route]
        [HttpGet]
        //[SwaggerOperationFilter(typeof(BasicHeaderParameters))]
        [SwaggerResponse(HttpStatusCode.OK, "OK", typeof(Response<List<TransactionTypeModel>>))]
        public IHttpActionResult GetTransactionTypes()
        {
            Response<List<TransactionTypeModel>> response = new Response<List<TransactionTypeModel>>();

            try
            {

            }
            catch (Exception ex)
            {

                
            }
        }
    }
}