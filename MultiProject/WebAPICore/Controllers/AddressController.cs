using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.Data;
using WebAPICore.Models;

namespace WebAPICore.Controllers
{
    [ApiController]
    [Route("api/address")] //use [controller] if dynamic
    public class AddressController : ControllerBase
    {
        private readonly IAddressRepo _addressRepo;
        //public AddressController()
        //{
        //    _addressRepo = new MockAddressRepo();
        //}rea
        public AddressController(IAddressRepo repository)
        {
            _addressRepo = repository;
        }

        // GET: AddressController
        [HttpGet]
        public async Task<IEnumerable<Address>> Get()
        {
            //List<Address> addresses = (List<Address>)_addressRepo.GetAll();
            //var addressItems = await _addressRepo.GetAll();
            return await _addressRepo.GetAll(); //(IEnumerable<Address>)Ok(addressItems); //why this?

        }

        /// <summary>
        /// Shows the Details of an Address
        /// </summary>
        /// <response code="200">Returns details about an address</response>   
        /// <response code="401">User is not authorized to make this request</response>
        /// <response code="404">Address was not found</response>   
        /// <response code="500">Internal server error</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        // GET: AddressController/Get/5
        [HttpGet("{id}")]
        public async Task<Address> GetById(string id)
        {
             return await _addressRepo.GetById(id);
        }

        ///// <summary>
        ///// Creates a new Address Item for empty View
        ///// </summary>
        //// GET: AddressController/Create
        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View();
        //}

        /// <summary>
        /// POST: AddressController/Create from form 
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(Address address)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return NoContent();
            }
        }

        //// GET: AddressController/Edit/5
        //[HttpGet]
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: AddressController/Edit/5
        //[HttpPost]
        ////[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        /// <summary>
        /// Delete1 - Work around for Swagger
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //GET: AddressController/Delete/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            return NoContent();
        }

        // POST: AddressController/Delete/5
        //[HttpDelete("{id}")]
        ////[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
