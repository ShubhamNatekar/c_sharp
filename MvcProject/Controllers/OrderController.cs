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
    public class OrderController : ControllerBase
    {
        private readonly TestDBContext _context;

        public OrderController(TestDBContext context)
        {
            _context = context;
        }

        // GET: Order
        [HttpGet("/Order/getAllorders")]
        public async Task<ActionResult<Order>> GetAll()
        {
            var order = await _context.Orders.ToListAsync();
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        // GET: Order/{orderkey}
        [HttpGet("/Order/getorder/{orderkey}")] 
        public async Task<ActionResult<Order>> Get(string orderkey)
        {
            if (orderkey == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FirstOrDefaultAsync(m => m.Orderkey == orderkey);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        // GET: Order/Create
        [HttpPost]
        public async Task<ActionResult<Order>> Create([Bind("Serialkey,WhseOrderkey,Orderkey,Storerkey,Externorderkey,Orderdate,Deliverydate,Priority,Consigneekey,CContact1,CContact2,CCompany,CAddress1,CAddress2,CAddress3,CAddress4,CCity,CState,CZip,CCountry,CIsocntrycode,CPhone1,CPhone2,CFax1,CFax2,CVat,Buyerpo,Billtokey,BContact1,BContact2,BCompany,BAddress1,BAddress2,BAddress3,BAddress4,BCity,BState,BZip,BCountry,BIsocntrycode,BPhone1,BPhone2,BFax1,BFax2,BVat,Incoterm,Pmtterm,Door,Sortationlocation,Batchflag,Bulkcartongroup,Route,Stop,Openqty,Status,Dischargeplace,Deliveryplace,Intermodalvehicle,Countryoforigin,Countrydestination,Updatesource,Type,Ordergroup,Effectivedate,Stage,DcOrderkey,WhseOrderkey1,SplitOrders,ApptStatus,Cheppalletindicator,Containertype,Containerqty,Billedcontainerqty,Transportationmode,Transportationservice,Externalorderkey2,CEmail1,CEmail2,Susr1,Susr2,Susr3,Susr4,Susr5,Notes2,ItemNumber,ForteFlag,LoadOrderkey,Shiptogether,Deliverydate2,Requestedshipdate,Actualshipdate,DeliverDate,Ordervalue,Ohtype,ExternalloadOrderkey,DestinationnestOrderkey,Referencenum,Intransitkey,Receiptkey,CaseLabelType,Labelname,Stdsscclabelname,Stdgtinlabelname,RfOrderkeysscclabelname,RfOrderkeygtinlabelname,RfOrderkeyflag,CarrierCode,CarrierName,CarrierAddress1,CarrierAddress2,CarrierCity,CarrierState,CarrierZip,CarrierCountry,CarrierPhone,DriverName,TrailerNumber,TrailerOwner,TrailerType,DepDateTime,Orderbreak,Allocatedonerp,Tradingpartner,Pronumber,Enablepacking,Packinglocation,OrdersOrderkey,Suspendedindicator,PicklistreportOrderkey,PackinglistreportOrderkey,Sourceversion,Referencetype,Referencedocument,Referencelocation,Referenceversion,Freightchargeamount,Freightcostamount,Appointmentkey,AllowOverPick,Totalqty,Totalgrosswgt,Totalcube,Totalorderlines,ReferenceAccountingEntity,Pokey,Apportion,ContainerOrderkey,Promisedshipdate,Plannedshipdate,Scheduledshipdate,Promiseddelvdate,Planneddelvdate,Scheduleddelvdate,Actualdelvdate,Earliestshipdate,Earliestdeliverydate,Carrierroutedocument,Carrierrouteaccountingentity,Carrierroutelocation,Carrierrouteversion,Tmhouseairwaybillnumber,Tmmasterairwaybillnumber,Tmbookingnumber,Tmhouseoceanbolnumber,Tmmasteroceanbolnumber,Tmequipmentnumber,Tmsealnumber,Tmlicenseplatenumber,Tmequipmenttype,Tmequipmentlength,Tmequipmentattribute,Tmairservicelevel,Tmoceanservicelevel,Tmoceantariffservice,Tmportofloading,Tmportofdischarge,Tmroutedvia,Tmserviceattribute,Tmfreightcostcurrency,Tmfreightchargecurrency,Actualarrivaldate,CAddress5,CAddress6,BAddress5,BAddress6,Returntoparty,Trailerkey,Carrierroutestatus,Splitshipmentindicator,Splitshipmentoriginalorderkey,Splitshipmentfinalshipment,Bodapplicationarea,Freightcostbaseamount,Freightchargebaseamount,Packingvaltemplate,Packnotes,Totalroutes,Autodoorassigned,Autostageassigned,Autopackassigned,Autodockassignedhow,Autodockassignedset,Autodockassignedstep,Autodockassigntime,Totalpalletestimate,Requireorderclose,Notes,Spsapistrategykey,Bolnumber,Bolprinted,Shiptogroup,Adddate,Addwho,Editdate,Editwho,Hostprocessrequired,Batchordernumber")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
            }          
            return Ok(order);
        }

        // GET: Order/Edit/5
        [HttpPut("{orderkey}")]
        public async Task<ActionResult<Order>> Edit(string orderkey, [Bind("Serialkey,WhseOrderkey,Orderkey,Storerkey,Externorderkey,Orderdate,Deliverydate,Priority,Consigneekey,CContact1,CContact2,CCompany,CAddress1,CAddress2,CAddress3,CAddress4,CCity,CState,CZip,CCountry,CIsocntrycode,CPhone1,CPhone2,CFax1,CFax2,CVat,Buyerpo,Billtokey,BContact1,BContact2,BCompany,BAddress1,BAddress2,BAddress3,BAddress4,BCity,BState,BZip,BCountry,BIsocntrycode,BPhone1,BPhone2,BFax1,BFax2,BVat,Incoterm,Pmtterm,Door,Sortationlocation,Batchflag,Bulkcartongroup,Route,Stop,Openqty,Status,Dischargeplace,Deliveryplace,Intermodalvehicle,Countryoforigin,Countrydestination,Updatesource,Type,Ordergroup,Effectivedate,Stage,DcOrderkey,WhseOrderkey1,SplitOrders,ApptStatus,Cheppalletindicator,Containertype,Containerqty,Billedcontainerqty,Transportationmode,Transportationservice,Externalorderkey2,CEmail1,CEmail2,Susr1,Susr2,Susr3,Susr4,Susr5,Notes2,ItemNumber,ForteFlag,LoadOrderkey,Shiptogether,Deliverydate2,Requestedshipdate,Actualshipdate,DeliverDate,Ordervalue,Ohtype,ExternalloadOrderkey,DestinationnestOrderkey,Referencenum,Intransitkey,Receiptkey,CaseLabelType,Labelname,Stdsscclabelname,Stdgtinlabelname,RfOrderkeysscclabelname,RfOrderkeygtinlabelname,RfOrderkeyflag,CarrierCode,CarrierName,CarrierAddress1,CarrierAddress2,CarrierCity,CarrierState,CarrierZip,CarrierCountry,CarrierPhone,DriverName,TrailerNumber,TrailerOwner,TrailerType,DepDateTime,Orderbreak,Allocatedonerp,Tradingpartner,Pronumber,Enablepacking,Packinglocation,OrdersOrderkey,Suspendedindicator,PicklistreportOrderkey,PackinglistreportOrderkey,Sourceversion,Referencetype,Referencedocument,Referencelocation,Referenceversion,Freightchargeamount,Freightcostamount,Appointmentkey,AllowOverPick,Totalqty,Totalgrosswgt,Totalcube,Totalorderlines,ReferenceAccountingEntity,Pokey,Apportion,ContainerOrderkey,Promisedshipdate,Plannedshipdate,Scheduledshipdate,Promiseddelvdate,Planneddelvdate,Scheduleddelvdate,Actualdelvdate,Earliestshipdate,Earliestdeliverydate,Carrierroutedocument,Carrierrouteaccountingentity,Carrierroutelocation,Carrierrouteversion,Tmhouseairwaybillnumber,Tmmasterairwaybillnumber,Tmbookingnumber,Tmhouseoceanbolnumber,Tmmasteroceanbolnumber,Tmequipmentnumber,Tmsealnumber,Tmlicenseplatenumber,Tmequipmenttype,Tmequipmentlength,Tmequipmentattribute,Tmairservicelevel,Tmoceanservicelevel,Tmoceantariffservice,Tmportofloading,Tmportofdischarge,Tmroutedvia,Tmserviceattribute,Tmfreightcostcurrency,Tmfreightchargecurrency,Actualarrivaldate,CAddress5,CAddress6,BAddress5,BAddress6,Returntoparty,Trailerkey,Carrierroutestatus,Splitshipmentindicator,Splitshipmentoriginalorderkey,Splitshipmentfinalshipment,Bodapplicationarea,Freightcostbaseamount,Freightchargebaseamount,Packingvaltemplate,Packnotes,Totalroutes,Autodoorassigned,Autostageassigned,Autopackassigned,Autodockassignedhow,Autodockassignedset,Autodockassignedstep,Autodockassigntime,Totalpalletestimate,Requireorderclose,Notes,Spsapistrategykey,Bolnumber,Bolprinted,Shiptogroup,Adddate,Addwho,Editdate,Editwho,Hostprocessrequired,Batchordernumber")] Order order)
        {
            var order2 = await _context.Orders.FirstOrDefaultAsync(m => m.Orderkey == orderkey);
            if (order2 == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.Orderkey))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return Ok(order);
        }

        // GET: Order/{orderkey}
        [HttpDelete("orderkey")]
        public async Task<ActionResult<Order>> DeleteConfirmed(string orderkey)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(m => m.Orderkey == orderkey);
            if (order == null)
            {
                return NotFound();
            }
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return Ok(order);
        }

        private bool OrderExists(string orderkey)
        {
            return _context.Orders.Any(e => e.Orderkey == orderkey);
        }
    }
}
