using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Avalara.CommsPlatform.Api.Models.Swagger
{
    /// <summary>
    /// Allow File Upload for Swagger
    /// </summary>
    public class GeoBatchSwaggerFileUpload : IOperationFilter
    {
        /// <summary>
        /// Only apply to Geo Batch Upload Endpoint
        /// </summary>
        public void Apply(Operation operation, OperationFilterContext context)
        {
            if (operation.OperationId.ToLower() == "apiv2geobatchuploadpost")
            {
                operation.Parameters.Clear();
                operation.Parameters.Add(new NonBodyParameter
                {
                    Name = "GeoBatchFile",
                    In = "formData",
                    Description = "Upload .csv file for Geo Batch processing",
                    Required = true,
                    Type = "file"
                });
                operation.Consumes.Add("multipart/form-data");
            }
        }
    }
}
