using System.Collections.Generic;
using System.Threading.Tasks;
using AntDesignBlazor.Servers.ServiceInterfaces;
using AntDesignModels;
using Microsoft.AspNetCore.Mvc;

namespace AntDesignBlazorWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NavigationController : Controller
    {
        private readonly INavigationRepository _navigationRepository;

        public NavigationController(INavigationRepository navigationRepository)
        {
            _navigationRepository = navigationRepository;
        }

        [HttpGet("{findall}")]
        public async Task<ActionResult<IEnumerable<NavigationInfo>>> FindAll()
        {
            return Ok(await _navigationRepository.FindAll());
        }
    }
}