using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace BWord.Core
{
    public class BasicHeaderParameters : IOperationFilter
    {
        //public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        //{
        //    if (operation.parameters == null)
        //        operation.parameters = new List<Parameter>();

        //    operation.parameters.Add(CreateParameter(operation.operationId));
        //}

        //private Parameter CreateParameter(string operationId)
        //{
        //    Parameter parameter = new Parameter()
        //    {
        //        type = "string",
        //        required = true,
        //        name = "Authorization",
        //        description = "Some Description"
        //    };
        //    parameter.@in = "header";

        //    return parameter;
        //}
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            throw new NotImplementedException();
        }
    }
}
