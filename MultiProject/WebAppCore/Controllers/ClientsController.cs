using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppCore.DAL;
using CleanUp.Data.SqlServer;
using CleanUp.Data.SqlServer.Interfaces;
using CleanUp.Entities;
using static WebAppCore.Helper;
using Microsoft.Extensions.Logging;

namespace WebAppCore.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IClientRepository _clientRepository;
        private readonly ILogger<ClientsController> _logger;
        
        public ClientsController(
            IClientRepository clientRepository,
            ILogger<ClientsController> logger
            )
        {
            _clientRepository = clientRepository;
            _logger = logger;

        }

        // GET: Clients/AddOrEdit(Insert)
        // GET: Clients/AddOrEdit/5(Update)
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if(id == 0)
                return View(new Client());
            else
            {
                var clientModel = await _clientRepository.GetClientByIDAsync(id);
                if(clientModel == null)
                {
                    return NotFound();
                }                
                return View(clientModel);
            }
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, Client client)
        {
            if (ModelState.IsValid)
            {
                //Insert
                if (id == 0)
                {
                    //transactionModel.Date = DateTime.Now;
                    _clientRepository.InsertClient(client);
                   await  _clientRepository.SaveAsync();
                }
                //Update
                else
                {
                    try
                    {
                        _clientRepository.UpdateClient(client);
                        await _clientRepository.SaveAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ClientModelExists(client.ClientId))
                        { return NotFound(); }
                        else
                        { throw; }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _clientRepository.GetClients()) });
                //return RedirectToAction(nameof(Index));
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", client) });
            //return View(client);
        }

        private bool ClientModelExists(int id)
        {
            return _context.Clients.Any(e => e.ClientId == id);
        }

        // GET: Clients
        public IActionResult Index()
        {
            //return View(await _context.Clients.ToListAsync());
            return View(_clientRepository.GetClients());
        }

        // GET: Clients/Details/5
        //public async Task<IActionResult> Details(int? id)
        public IActionResult Details(int id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var client = await _context.Clients
            var client = _clientRepository.GetClientByID(id);
            //.FirstOrDefaultAsync(m => m.ClientId == id);
            //if (client == null)
            //{
            //    return NotFound();
            //}

            return View(client);
        }


        public IActionResult Delete(int id)
        {
            var client = _clientRepository.GetClientByID(id);
            return View(client);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            _clientRepository.DeleteClient(id);
            _clientRepository.Save();
            //return RedirectToAction(nameof(Index));
            await _clientRepository.SaveAsync();
            return Json(new { html = Helper.RenderRazorViewToString(this, "_ViewAll", _clientRepository.GetClients()) });
        }

    }
}
