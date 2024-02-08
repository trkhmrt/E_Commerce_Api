using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Api.Concrete;
using E_Commerce_Api.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce_Api.Controllers
{

   


    [Route("[controller]")]
    public class UrunController : Controller
    {
        private readonly Context _context;

        public UrunController(Context context)
        {
            _context = context;
        }





        // GET: api/values
        [HttpGet]
        public IEnumerable<Urun> Get()
        {

            return _context.Uruns.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Urun Get(int id)
        {
            var urun = _context.Uruns.FirstOrDefault(u => u.Urunid == id);
            return urun;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {


        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}

