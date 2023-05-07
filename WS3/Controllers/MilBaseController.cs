using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelClasses;
using Mocks;

namespace WS3.Controllers
{
    [Route("get/[controller]")]
    [ApiController]
    public class MilBaseController : ControllerBase
    {
        [HttpGet("all", Name = "GetAllBases")]
        public List<MilitaryBase> Get()
        {
            return DatabaseMock.GetAllBases();
        }
        [HttpGet("id", Name = "GetBaseByID")]
        public MilitaryBase Get(int id)
        {
            return DatabaseMock.GetBaseByID(id);
        }
        [HttpGet("cptname", Name = "GetBaseByCPTName")]
        public MilitaryBase Get(string name)
        {
            return DatabaseMock.GetBaseByCPTName(name);
        }
    }
}
