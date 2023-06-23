using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedUnify.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class MedUnifyControllerBase : ControllerBase
    {
    }
}
