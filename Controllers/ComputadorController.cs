using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiendaGamer.Servicios;

using Microsoft.AspNetCore.Mvc;
using TiendaGamer.Productos;

// Controlador de Computadores
[ApiController]
[Route("api/[controller]")]
public class ComputersController : ControllerBase
{
    private readonly IComputadorService _computerService;

    // Usar inyección de dependencias para el servicio
    public ComputersController(IComputadorService computerService)
    {
        _computerService = computerService;
    }

    [HttpPost("add/dell/desktop")]
    public IActionResult AddDellDesktop([FromBody] ComputerDTO dto)
    {
        _computerService.AddDellDesktop(dto.Processor, dto.RAM, dto.Storage);
        return StatusCode(StatusCodes.Status201Created, "Dell Desktop added successfully.");
    }

    [HttpPost("add/dell/laptop")]
    public IActionResult AddDellLaptop([FromBody] ComputerDTO dto)
    {
        _computerService.AddDellLaptop(dto.Processor, dto.RAM, dto.Storage);
        return StatusCode(StatusCodes.Status201Created, "Dell Laptop added successfully.");
    }

    [HttpPost("add/hp/desktop")]
    public IActionResult AddHPDesktop([FromBody] ComputerDTO dto)
    {
        _computerService.AddHPDesktop(dto.Processor, dto.RAM, dto.Storage);
        return StatusCode(StatusCodes.Status201Created, "HP Desktop added successfully.");
    }

    [HttpPost("add/hp/laptop")]
    public IActionResult AddHPLaptop([FromBody] ComputerDTO dto)
    {
        _computerService.AddHPLaptop(dto.Processor, dto.RAM, dto.Storage);
        return StatusCode(StatusCodes.Status201Created, "HP Laptop added successfully.");
    }

    [HttpGet("desktops")]
    public IActionResult GetDesktops()
    {
        var desktops = _computerService.GetAllDesktops();
        return Ok(desktops);
    }

    [HttpGet("laptops")]
    public IActionResult GetLaptops()
    {
        var laptops = _computerService.GetAllLaptops();
        return Ok(laptops);
    }

    [HttpDelete("desktop")]
    public IActionResult DeleteDesktop([FromBody] IEscritorio desktop)
    {
        _computerService.RemoveDesktop(desktop);
        return NoContent();
    }

    [HttpDelete("laptop")]
    public IActionResult DeleteLaptop([FromBody] IPortatil laptop)
    {
        _computerService.RemoveLaptop(laptop);
        return NoContent();
    }
}

// DTO para recibir especificaciones de computadores
public class ComputerDTO
{
    public string Processor { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }
}
