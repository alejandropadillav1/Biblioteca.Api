#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Api.Data;
using Biblioteca.Api.Modelo;

namespace Biblioteca.Api.Controllers
{
    [Route("[controller]/[action]")]
    public class BibliotecaController : ControllerBase
    {
        private readonly BibliotecaApiContext _context;

        public BibliotecaController(BibliotecaApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ConsultaLibros()
        {
            return Ok(await _context.Libro.ToListAsync());
        }



        [HttpPost]
        public async Task<IActionResult> Agregar( Libro libro)
        {
            _context.Libro.Add(libro);
            await _context.SaveChangesAsync();
            return Ok(libro);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarLibro(Libro libro)
        {
            _context.Update(libro);
            await _context.SaveChangesAsync();
            return Ok(libro);
        }

        [HttpDelete]
        public async Task<IActionResult> BorrarLibro(Libro libro)
        {
            _context.Remove(libro);
            await _context.SaveChangesAsync();
            return Ok();
        }

        
    }
}
