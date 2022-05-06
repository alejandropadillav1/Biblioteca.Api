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


        public BibliotecaController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("IdLibro,Titulo,Editorial,Autor,Pagina,Descripcion")] Libro libro)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Titulo,Editorial,Autor,Pagina,Descripcion")] Libro libro)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            return Ok();
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            return Ok();
        }

        
    }
}
