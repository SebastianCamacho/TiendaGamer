using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaGamer.Servicios;

using Microsoft.AspNetCore.Mvc;
using TiendaGamer.Productos;

// Controlador de Computadores
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ComputadorController : ControllerBase
{
    private readonly IComputadorService _computadorService;

    public ComputadorController(IComputadorService computadorService)
    {
        _computadorService = computadorService;
    }

    // GET para crear un escritorio por marca
    [HttpGet("escritorio/{marca}")]
    public IActionResult CrearEscritorio(string marca)
    {
        try
        {
            var escritorio = _computadorService.CrearEscritorio(marca);
            return Ok(new { message = $"Escritorio creado Especificaciones: { escritorio }"});
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // GET para crear un portátil por marca
    [HttpGet("portatil/{marca}")]
    public IActionResult CrearPortatil(string marca)
    {
        try
        {
            var portatil = _computadorService.CrearPortatil(marca);
            return Ok(new { message = $"Portátil creado Especificaciones: { portatil }" });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // POST para personalizar un escritorio
    [HttpPost("personalizar/escritorio")]
    public IActionResult PersonalizarEscritorio([FromBody] PersonalizacionComputadorDto personalizacion)
    {
        try
        {
            var escritorio = _computadorService.PersonalizarEscritorio(
                personalizacion.Marca,
                personalizacion.Procesador,
                personalizacion.Ram,
                personalizacion.Almacenamiento
            );
            return Ok(new { message = $"Escritorio personalizado creado Especificaciones: { escritorio }" });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // POST para personalizar un portátil
    [HttpPost("personalizar/portatil")]
    public IActionResult PersonalizarPortatil([FromBody] PersonalizacionComputadorDto personalizacion)
    {
        try
        {
            var portatil = _computadorService.PersonalizarPortatil(
                personalizacion.Marca,
                personalizacion.Procesador,
                personalizacion.Ram,
                personalizacion.Almacenamiento
            );
            return Ok(new { message = $"Portátil personalizado creado Especificaciones: { portatil }" });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // GET para obtener la lista de escritorios
    [HttpGet("escritorios")]
    public IActionResult ObtenerEscritorios()
    {
        var escritorios = _computadorService.ObtenerEscritorios();
        return Ok(escritorios);
    }

    // GET para obtener la lista de portátiles
    [HttpGet("portatiles")]
    public IActionResult ObtenerPortatiles()
    {
        var portatiles = _computadorService.ObtenerPortatiles();
        return Ok(portatiles);
    }
}

// DTO para la personalización de computadores
public class PersonalizacionComputadorDto
{
    public string Marca { get; set; }
    public string Procesador { get; set; }
    public int Ram { get; set; }
    public int Almacenamiento { get; set; }
}