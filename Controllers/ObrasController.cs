using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;

namespace Biblioteca.Controllers;

[ApiController]
[Route("[controller]")]
public class ObrasController : ControllerBase
{
    public ObrasController() {}

    [HttpGet]
    public ActionResult<List<Obras>> GetAll()
    {
        ObrasRepository obrasRepository = ObrasRepository.Instance;
        return obrasRepository.GetAll();
    }
    
    [HttpPost]
    public IActionResult Add(Obras obra)
    {
        ObrasRepository obrasRepository = ObrasRepository.Instance;
        obrasRepository.Add(obra);
        return CreatedAtAction( null, new { id = obra.Id }, obra);
    }
}