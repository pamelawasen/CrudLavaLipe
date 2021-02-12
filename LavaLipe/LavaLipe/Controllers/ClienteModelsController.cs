using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LavaLipe.Data;
using LavaLipe.Models;
using LavaLipe.Services;
using System.Net.Http;
using System.Net;

namespace LavaLipe.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClienteModelsController : Controller
    {
        private readonly ClientesServices _context;


        public ClienteModelsController(ClientesServices context)
        {
            _context = context;
        }

        // GET: ClienteModels
        [HttpGet]
        [Route("")]
        public IActionResult FindAllClientes()
        {
            // acessar externo
            try
            {
                List<ClienteModel> lista = _context.OnGetClientes();
                return Json(lista);
            }
            catch (Exception)
            {
                return Content("Não foi possivel retornar a lista de clientes");
            }


        }
        // POST: ClienteModels/Create
        [HttpPost]
        [Route("create")]
        public IActionResult Create(ClienteModel clienteModel)
        {
            try
            {
                _context.AddCliente(clienteModel);
                return Json("Cliente adicionado");
            }
            catch (Exception)
            {

                return BadRequest();
            }



        }
        // POST: ClienteModels/Delete/5
        [HttpPost]
        [Route("delete/{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            try
            {

                _context.DeleteCliente(id);
                return Json($"cadastro {id} deletado");
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }


        // put: ClienteModels/Edit/5
        [HttpPut]
        [Route("edit")]
        public IActionResult Edit(ClienteModel clienteModel)
        {
            if (clienteModel == null)
            {
                return NotFound();
            }
            try
            {
                _context.EditCliente(clienteModel);
                return Json("Cliente atualizado");
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }


    }


}

