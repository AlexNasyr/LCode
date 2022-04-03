using LCode.Model;
using Microsoft.AspNetCore.Mvc;

namespace LCode.Controllers {
    [ApiController]
    public class apiController : ControllerBase {
        private ILcRepository _repository;
        public apiController(ILcRepository repository) { 
            _repository = repository;
        }

        [HttpGet]
        [Route("[controller]/getQueries")]
        public async Task<LcResponce[]> GetQueries() {
            var responce = await _repository.GetQueries();
            return responce;
        }

    }
}
