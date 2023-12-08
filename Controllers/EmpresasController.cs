using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CNPJApi.Models;
using CNPJApi.Data;

namespace CNPJApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class EmpresasController : Controller
    {
        private readonly DataContext _context;

        public EmpresasController(DataContext context)
        {
            _context = context;
        }

        private async Task<bool> NomeEmUso(string nome)
        {
            if (await _context.TB_EMPRESAS.AnyAsync(x => x.Nome.ToLower() == nome.ToLower()))
            {
                return true;
            }
            return false;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Empresa> lista = await _context.TB_EMPRESAS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("BuscarId/{id}")]
        public async Task<IActionResult> GetSingleId(int id)
        {
            try
            {
                Empresa? busca = await _context.TB_EMPRESAS.FirstOrDefaultAsync(x => x.Id == id);
                return Ok(busca);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("BuscarNome/{nome}")]
        public async Task<IActionResult> GetSingleName(string nome)
        {
            try
            {
                List<Empresa> busca = await _context.TB_EMPRESAS
                    .Where(x => x.Nome.ToLower().Contains(nome.ToLower())).ToListAsync();
                return Ok(busca);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("BuscarCNPJ")]

        public async Task<IActionResult> GetSingleCNPJ(string cnpj)
        {
            try
            {
                Empresa? busca = await _context.TB_EMPRESAS.FirstAsync(x => x.CNPJ == cnpj);
                return Ok(busca);
            }
            catch (SystemException ex)
            {
                return BadRequest(ex.Message);
            }
        }

         [HttpPost("Adicionar")]
        public async Task<IActionResult> Add(Empresa novaEmpresa)
        {
            try
            {
              
            if (await NomeEmUso(novaEmpresa.Nome))
                throw new Exception("Empresa com mesmo nome já cadastrada");

            await _context.TB_EMPRESAS.AddAsync(novaEmpresa);
            await _context.SaveChangesAsync();

                return Ok("Eempresa cadastrada com sucesso! ");
            }
            catch (SystemException ex)
            {
                return BadRequest(ex.Message);
            }
        
        }

    }
}
