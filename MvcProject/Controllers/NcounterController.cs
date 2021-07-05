using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcProject.Data;
using MvcProject.Models;
using Microsoft.Extensions.Logging;

namespace MvcProject.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NcounterController : ControllerBase
    {
        private readonly TestDBContext _context;

        public NcounterController(TestDBContext context)
        {
            _context = context;
        }
    //Path param
    /*
        // GET: Ncounter/
        [HttpGet] 
        public async Task<ActionResult<Ncounter>> GetAll()
        {
            var ncounter = await _context.Ncounters.ToListAsync();
            if (ncounter == null)
            {
                return NotFound();
            }
            return Ok(ncounter);
        }

        // GET: Ncounter/{keyname}
        [HttpGet("{keyname}")] 
        public async Task<ActionResult<Ncounter>> Details(string keyname)
        {
            if (keyname == null)
            {
                return NotFound();
            }

            var ncounter = await _context.Ncounters
                .FirstOrDefaultAsync(m => m.Keyname == keyname);
            if (ncounter == null)
            {
                return NotFound();
            }

            return Ok(ncounter);
        }

        //POST: Ncounter
        [HttpPost]
        public async Task<ActionResult<Ncounter>> Create([Bind("Serialkey,Whseid,Keyname,Keycount,Adddate,Addwho,Editdate,Editwho")] Ncounter ncounter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ncounter);
                await _context.SaveChangesAsync();
            }
            return Ok(ncounter);
        }


        //PUT: Ncounter/{keyname}
        [HttpPut("{keyname}")]
        public async Task<ActionResult<Ncounter>> Edit(string keyname, [Bind("Serialkey,Whseid,Keyname,Keycount,Adddate,Addwho,Editdate,Editwho")] Ncounter ncounter)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ncounter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NcounterExists(ncounter.Keyname))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return Ok(ncounter);
        }
        // POST: Ncounter/{keyname}
        [HttpDelete("{keyname}")]
        public async Task<ActionResult<Ncounter>> DeleteConfirmed(string keyname)
        {
            var ncounter = await _context.Ncounters.FirstOrDefaultAsync(m => m.Keyname == keyname);
            if (ncounter == null)
            {
                return NotFound();
            }   
            _context.Ncounters.Remove(ncounter);
            await _context.SaveChangesAsync();
            return Ok(ncounter);
        }

        private bool NcounterExists(string keyname)
        {
            return _context.Ncounters.Any(e => e.Keyname == keyname);
        }
    */    
     
    //Query param 

        // GET: Ncounter/?addwho
        [HttpGet("/getDetails")] 
        public ActionResult<Ncounter> GetDetails([FromQuery]string colname,[FromQuery]string colvalue)
        {
            //var ncounter = _context.Ncounters.Where( n=> n.Addwho == addwho).FirstOrDefault();
            //var ncounter = _context.Ncounters.FromSqlRaw($"select * from wmwhse1.NCOUNTER where ADDWHO='{addwho}'").FirstOrDefault();
            /*
            SELECT column_name as 'Column Name', data_type as 'Data Type' FROM information_schema.columns WHERE table_name = 'NCOUNTER'    
            var properties =  typeof(Ncounter).GetProperties();
            foreach (var item in properties)
            {
                Console.WriteLine(item.Name);
            }
            var entityType = dbContext.Model.FindEntityType(clrEntityType);

            // Table info 
            var tableName = entityType.GetTableName();
            var tableSchema = entityType.GetSchema();

            // Column info 
            foreach (var property in entityType.GetProperties())
            {
                var columnName = property.GetColumnName();
                var columnType = property.GetColumnType();
            };

            var names = typeof(Ncounter).GetProperties()
                        .Select(property => property.Name)
                        .ToArray();
            */
            //var col="ADDWHO";
            /*
                Dictionary={
                    "ADDWHO":(AddWho,string),
                    "EDITDATE":(Editdate,datetime)
                }
            IQueryable<Ncounter> ncounter = from nc in _context.Ncounters
            // where nc.colname== colvalue
            select nc;        
            */
            var properties = typeof(Ncounter).GetProperties().Select(property => property.Name).ToArray();
            Console.WriteLine(colname,colvalue);
            foreach(var prop in properties)
            {
                Console.Write(prop," ");
            }
            //var ncounter = _context.Ncounters.FromSqlRaw($"select * from wmwhse1.NCOUNTER where WHSEID = '{colvalue}'").ToList();
            var ncounter = _context.Ncounters.FromSqlRaw($"select * from wmwhse1.NCOUNTER where '{colname}' = '{colvalue}'").ToList();
            if (ncounter == null)
            {
                return NotFound();
            }
            return Ok(ncounter);
        }
    }
}