using LavaLipe.Data;
using LavaLipe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace LavaLipe.Services
{
    public class ClientesServices
    {
        public ClientesServices()
        {

        }
        private readonly LavaLipeContext _context;
        public ClientesServices(LavaLipeContext context)
        {
            _context = context;
        }

        public List<ClienteModel> OnGetClientes()
        {
          return  _context.ClienteModel.Where(c =>c.Excluido !=1).ToList();
        } 

        public void AddCliente(ClienteModel cliente)
        {
            _context.ClienteModel.Add(cliente);
            _context.SaveChanges();
        }
        public void DeleteCliente(int id)
        {
            var clienteModel = _context.ClienteModel.Where(c => c.Id == id).FirstOrDefault();

            clienteModel.Excluido = 1;

            _context.Entry(clienteModel).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }
        public void EditCliente(ClienteModel cliente)
        {
            var clienteModel = _context.ClienteModel.Where(c => c.Id == cliente.Id).FirstOrDefault();

            clienteModel.Name = cliente.Name;
            clienteModel.CPFCNPJ = cliente.CPFCNPJ;
            clienteModel.Phone = cliente.Phone;

            _context.Entry(clienteModel).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }
    }
}
