using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebApplication3.Controllers
{
    /// <summary>
    /// Represents some values.
    /// </summary>
    /// <remarks>
    /// These are extended remarks about this class.
    /// </remarks>
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Get a value
        /// </summary>
        /// <returns>A value</returns>
        [Route("")]
        [ResponseType(typeof(int))]
        public async Task<int> Get()
        {
            return await Task.FromResult(42);
        }
    }
}