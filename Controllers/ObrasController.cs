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
    [HttpGet("{id}")]
    public ActionResult<Obras> Get(int id)
    {
        ObrasRepository obrasRepository = ObrasRepository.Instance;
        Obras? obra = obrasRepository.Get(id);
        if(obra == null)
            return NotFound();
        return obra;
    }
    
    [HttpPost]
    public IActionResult Add(Obras obra)
    {
        ObrasRepository obrasRepository = ObrasRepository.Instance;
        obrasRepository.Add(obra);
        return CreatedAtAction( nameof(Get), new { id = obra.Id }, obra);
    }
    [HttpPut("{id}")]
    public IActionResult Update(int id, Obras obra)
    {
        if(id != obra.Id)
            return BadRequest();
        ObrasRepository obrasRepository = ObrasRepository.Instance;
        Obras? existeObj = obrasRepository.Update(obra);
        if(existeObj == null)
            return NotFound();
        return NoContent();
    }
}