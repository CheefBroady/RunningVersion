/*
 * Auftragsliste
 *
 * WAWI - Auftragsliste
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WsWawiOrderList.Attributes;
using WsWawiOrderList.Models;

namespace WsWawiOrderList.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class OrderApiController : Controller
    { 
        /// <summary>
        /// returns a list of orders
        /// </summary>
        /// <remarks>returns a list of orders</remarks>
        /// <param name="fromchangetime">date time in ISO 8601 - format example 2007-12-24T18:21Z</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid status value</response>
        /// <response code="500">Internal server error</response>
        [HttpGet]
        [Route("/api/order")]
        [ValidateModelState]
        [SwaggerOperation("GetOrder")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Order>), description: "successful operation")]
        public virtual IActionResult GetOrder([FromQuery]string fromchangetime)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Order>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            string exampleJson = null;
            exampleJson = "[ {\n  \"matchcode\" : \"matchcode\",\n  \"aufnr\" : \"aufnr\",\n  \"status\" : \"status\"\n}, {\n  \"matchcode\" : \"matchcode\",\n  \"aufnr\" : \"aufnr\",\n  \"status\" : \"status\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Order>>(exampleJson)
            : default(List<Order>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
