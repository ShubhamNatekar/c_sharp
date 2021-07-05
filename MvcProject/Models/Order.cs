using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MvcProject.Models
{
    [Table("ORDERS", Schema = "wmwhse1")]
    [Index(nameof(Serialkey), Name = "ORD_172_UNIQUE", IsUnique = true)]
    public partial class Order
    {
        public Order()
        {
            Orderdetails = new HashSet<Orderdetail>();
        }

        [Column("SERIALKEY")]
        public int Serialkey { get; set; }
        [Column("WHSEID")]
        [StringLength(30)]
        public string Whseid { get; set; }
        [Key]
        [Column("ORDERKEY")]
        [StringLength(10)]
        public string Orderkey { get; set; }
        [Required]
        [Column("STORERKEY")]
        [StringLength(15)]
        public string Storerkey { get; set; }
        [Required]
        [Column("EXTERNORDERKEY")]
        [StringLength(32)]
        public string Externorderkey { get; set; }
        [Column("ORDERDATE", TypeName = "datetime")]
        public DateTime Orderdate { get; set; }
        [Column("DELIVERYDATE", TypeName = "datetime")]
        public DateTime? Deliverydate { get; set; }
        [Required]
        [Column("PRIORITY")]
        [StringLength(10)]
        public string Priority { get; set; }
        [Required]
        [Column("CONSIGNEEKEY")]
        [StringLength(15)]
        public string Consigneekey { get; set; }
        [Column("C_CONTACT1")]
        [StringLength(30)]
        public string CContact1 { get; set; }
        [Column("C_CONTACT2")]
        [StringLength(30)]
        public string CContact2 { get; set; }
        [Column("C_COMPANY")]
        [StringLength(45)]
        public string CCompany { get; set; }
        [Column("C_ADDRESS1")]
        [StringLength(45)]
        public string CAddress1 { get; set; }
        [Column("C_ADDRESS2")]
        [StringLength(45)]
        public string CAddress2 { get; set; }
        [Column("C_ADDRESS3")]
        [StringLength(45)]
        public string CAddress3 { get; set; }
        [Column("C_ADDRESS4")]
        [StringLength(45)]
        public string CAddress4 { get; set; }
        [Column("C_CITY")]
        [StringLength(45)]
        public string CCity { get; set; }
        [Column("C_STATE")]
        [StringLength(25)]
        public string CState { get; set; }
        [Column("C_ZIP")]
        [StringLength(18)]
        public string CZip { get; set; }
        [Column("C_COUNTRY")]
        [StringLength(30)]
        public string CCountry { get; set; }
        [Column("C_ISOCNTRYCODE")]
        [StringLength(10)]
        public string CIsocntrycode { get; set; }
        [Column("C_PHONE1")]
        [StringLength(18)]
        public string CPhone1 { get; set; }
        [Column("C_PHONE2")]
        [StringLength(18)]
        public string CPhone2 { get; set; }
        [Column("C_FAX1")]
        [StringLength(18)]
        public string CFax1 { get; set; }
        [Column("C_FAX2")]
        [StringLength(18)]
        public string CFax2 { get; set; }
        [Column("C_VAT")]
        [StringLength(18)]
        public string CVat { get; set; }
        [Column("BUYERPO")]
        [StringLength(50)]
        public string Buyerpo { get; set; }
        [Required]
        [Column("BILLTOKEY")]
        [StringLength(15)]
        public string Billtokey { get; set; }
        [Column("B_CONTACT1")]
        [StringLength(30)]
        public string BContact1 { get; set; }
        [Column("B_CONTACT2")]
        [StringLength(30)]
        public string BContact2 { get; set; }
        [Column("B_COMPANY")]
        [StringLength(45)]
        public string BCompany { get; set; }
        [Column("B_ADDRESS1")]
        [StringLength(45)]
        public string BAddress1 { get; set; }
        [Column("B_ADDRESS2")]
        [StringLength(45)]
        public string BAddress2 { get; set; }
        [Column("B_ADDRESS3")]
        [StringLength(45)]
        public string BAddress3 { get; set; }
        [Column("B_ADDRESS4")]
        [StringLength(45)]
        public string BAddress4 { get; set; }
        [Column("B_CITY")]
        [StringLength(45)]
        public string BCity { get; set; }
        [Column("B_STATE")]
        [StringLength(25)]
        public string BState { get; set; }
        [Column("B_ZIP")]
        [StringLength(18)]
        public string BZip { get; set; }
        [Column("B_COUNTRY")]
        [StringLength(30)]
        public string BCountry { get; set; }
        [Column("B_ISOCNTRYCODE")]
        [StringLength(10)]
        public string BIsocntrycode { get; set; }
        [Column("B_PHONE1")]
        [StringLength(18)]
        public string BPhone1 { get; set; }
        [Column("B_PHONE2")]
        [StringLength(18)]
        public string BPhone2 { get; set; }
        [Column("B_FAX1")]
        [StringLength(18)]
        public string BFax1 { get; set; }
        [Column("B_FAX2")]
        [StringLength(18)]
        public string BFax2 { get; set; }
        [Column("B_VAT")]
        [StringLength(18)]
        public string BVat { get; set; }
        [Column("INCOTERM")]
        [StringLength(10)]
        public string Incoterm { get; set; }
        [Column("PMTTERM")]
        [StringLength(10)]
        public string Pmtterm { get; set; }
        [Required]
        [Column("DOOR")]
        [StringLength(10)]
        public string Door { get; set; }
        [Column("SORTATIONLOCATION")]
        [StringLength(18)]
        public string Sortationlocation { get; set; }
        [Required]
        [Column("BATCHFLAG")]
        [StringLength(1)]
        public string Batchflag { get; set; }
        [Column("BULKCARTONGROUP")]
        [StringLength(10)]
        public string Bulkcartongroup { get; set; }
        [Required]
        [Column("ROUTE")]
        [StringLength(10)]
        public string Route { get; set; }
        [Column("STOP")]
        public int? Stop { get; set; }
        [Column("OPENQTY", TypeName = "decimal(22, 5)")]
        public decimal? Openqty { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("DISCHARGEPLACE")]
        [StringLength(30)]
        public string Dischargeplace { get; set; }
        [Column("DELIVERYPLACE")]
        [StringLength(30)]
        public string Deliveryplace { get; set; }
        [Required]
        [Column("INTERMODALVEHICLE")]
        [StringLength(30)]
        public string Intermodalvehicle { get; set; }
        [Column("COUNTRYOFORIGIN")]
        [StringLength(30)]
        public string Countryoforigin { get; set; }
        [Column("COUNTRYDESTINATION")]
        [StringLength(30)]
        public string Countrydestination { get; set; }
        [Required]
        [Column("UPDATESOURCE")]
        [StringLength(10)]
        public string Updatesource { get; set; }
        [Required]
        [Column("TYPE")]
        [StringLength(10)]
        public string Type { get; set; }
        [Required]
        [Column("ORDERGROUP")]
        [StringLength(20)]
        public string Ordergroup { get; set; }
        [Column("EFFECTIVEDATE", TypeName = "datetime")]
        public DateTime? Effectivedate { get; set; }
        [Column("STAGE")]
        [StringLength(10)]
        public string Stage { get; set; }
        [Column("DC_ID")]
        [StringLength(10)]
        public string DcId { get; set; }
        [Column("WHSE_ID")]
        [StringLength(10)]
        public string WhseId1 { get; set; }
        [Column("SPLIT_ORDERS")]
        [StringLength(1)]
        public string SplitOrders { get; set; }
        [Column("APPT_STATUS")]
        [StringLength(10)]
        public string ApptStatus { get; set; }
        [Column("CHEPPALLETINDICATOR")]
        [StringLength(10)]
        public string Cheppalletindicator { get; set; }
        [Column("CONTAINERTYPE")]
        [StringLength(20)]
        public string Containertype { get; set; }
        [Column("CONTAINERQTY", TypeName = "decimal(22, 5)")]
        public decimal? Containerqty { get; set; }
        [Column("BILLEDCONTAINERQTY", TypeName = "decimal(22, 5)")]
        public decimal? Billedcontainerqty { get; set; }
        [Column("TRANSPORTATIONMODE")]
        [StringLength(30)]
        public string Transportationmode { get; set; }
        [Column("TRANSPORTATIONSERVICE")]
        [StringLength(30)]
        public string Transportationservice { get; set; }
        [Column("EXTERNALORDERKEY2")]
        [StringLength(32)]
        public string Externalorderkey2 { get; set; }
        [Column("C_EMAIL1")]
        [StringLength(55)]
        public string CEmail1 { get; set; }
        [Column("C_EMAIL2")]
        [StringLength(55)]
        public string CEmail2 { get; set; }
        [Column("SUSR1")]
        [StringLength(30)]
        public string Susr1 { get; set; }
        [Column("SUSR2")]
        [StringLength(30)]
        public string Susr2 { get; set; }
        [Column("SUSR3")]
        [StringLength(30)]
        public string Susr3 { get; set; }
        [Column("SUSR4")]
        [StringLength(30)]
        public string Susr4 { get; set; }
        [Column("SUSR5")]
        [StringLength(30)]
        public string Susr5 { get; set; }
        [Column("NOTES2")]
        [StringLength(2000)]
        public string Notes2 { get; set; }
        [Column("ITEM_NUMBER", TypeName = "decimal(28, 0)")]
        public decimal? ItemNumber { get; set; }
        [Required]
        [Column("FORTE_FLAG")]
        [StringLength(6)]
        public string ForteFlag { get; set; }
        [Column("LOADID")]
        [StringLength(20)]
        public string Loadid { get; set; }
        [Required]
        [Column("SHIPTOGETHER")]
        [StringLength(1)]
        public string Shiptogether { get; set; }
        [Column("DELIVERYDATE2", TypeName = "datetime")]
        public DateTime? Deliverydate2 { get; set; }
        [Column("REQUESTEDSHIPDATE", TypeName = "datetime")]
        public DateTime? Requestedshipdate { get; set; }
        [Column("ACTUALSHIPDATE", TypeName = "datetime")]
        public DateTime? Actualshipdate { get; set; }
        [Column("DELIVER_DATE", TypeName = "datetime")]
        public DateTime? DeliverDate { get; set; }
        [Column("ORDERVALUE", TypeName = "decimal(10, 2)")]
        public decimal Ordervalue { get; set; }
        [Column("OHTYPE")]
        [StringLength(10)]
        public string Ohtype { get; set; }
        [Column("EXTERNALLOADID")]
        [StringLength(20)]
        public string Externalloadid { get; set; }
        [Column("DESTINATIONNESTID")]
        public int? Destinationnestid { get; set; }
        [Column("REFERENCENUM")]
        [StringLength(30)]
        public string Referencenum { get; set; }
        [Column("INTRANSITKEY")]
        [StringLength(10)]
        public string Intransitkey { get; set; }
        [Column("RECEIPTKEY")]
        [StringLength(10)]
        public string Receiptkey { get; set; }
        [StringLength(10)]
        public string CaseLabelType { get; set; }
        [Column("LABELNAME")]
        [StringLength(20)]
        public string Labelname { get; set; }
        [Column("STDSSCCLABELNAME")]
        [StringLength(20)]
        public string Stdsscclabelname { get; set; }
        [Column("STDGTINLABELNAME")]
        [StringLength(20)]
        public string Stdgtinlabelname { get; set; }
        [Column("RFIDSSCCLABELNAME")]
        [StringLength(20)]
        public string Rfidsscclabelname { get; set; }
        [Column("RFIDGTINLABELNAME")]
        [StringLength(20)]
        public string Rfidgtinlabelname { get; set; }
        [Required]
        [Column("RFIDFLAG")]
        [StringLength(1)]
        public string Rfidflag { get; set; }
        [StringLength(15)]
        public string CarrierCode { get; set; }
        [StringLength(45)]
        public string CarrierName { get; set; }
        [StringLength(45)]
        public string CarrierAddress1 { get; set; }
        [StringLength(45)]
        public string CarrierAddress2 { get; set; }
        [StringLength(45)]
        public string CarrierCity { get; set; }
        [StringLength(25)]
        public string CarrierState { get; set; }
        [StringLength(18)]
        public string CarrierZip { get; set; }
        [StringLength(30)]
        public string CarrierCountry { get; set; }
        [StringLength(18)]
        public string CarrierPhone { get; set; }
        [StringLength(25)]
        public string DriverName { get; set; }
        [StringLength(20)]
        public string TrailerNumber { get; set; }
        [StringLength(25)]
        public string TrailerOwner { get; set; }
        [StringLength(10)]
        public string TrailerType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DepDateTime { get; set; }
        [Column("ORDERBREAK")]
        [StringLength(1)]
        public string Orderbreak { get; set; }
        [Required]
        [Column("ALLOCATEDONERP")]
        [StringLength(1)]
        public string Allocatedonerp { get; set; }
        [Column("TRADINGPARTNER")]
        [StringLength(30)]
        public string Tradingpartner { get; set; }
        [Column("PRONUMBER")]
        [StringLength(32)]
        public string Pronumber { get; set; }
        [Column("ENABLEPACKING")]
        [StringLength(1)]
        public string Enablepacking { get; set; }
        [Column("PACKINGLOCATION")]
        [StringLength(10)]
        public string Packinglocation { get; set; }
        [Column("ORDERSID")]
        [StringLength(32)]
        public string Ordersid { get; set; }
        [Column("SUSPENDEDINDICATOR")]
        [StringLength(1)]
        public string Suspendedindicator { get; set; }
        [Column("PICKLISTREPORTID")]
        [StringLength(8)]
        public string Picklistreportid { get; set; }
        [Column("PACKINGLISTREPORTID")]
        [StringLength(8)]
        public string Packinglistreportid { get; set; }
        [Column("SOURCEVERSION")]
        [StringLength(22)]
        public string Sourceversion { get; set; }
        [Column("REFERENCETYPE")]
        [StringLength(64)]
        public string Referencetype { get; set; }
        [Column("REFERENCEDOCUMENT")]
        [StringLength(64)]
        public string Referencedocument { get; set; }
        [Column("REFERENCELOCATION")]
        [StringLength(64)]
        public string Referencelocation { get; set; }
        [Column("REFERENCEVERSION")]
        [StringLength(20)]
        public string Referenceversion { get; set; }
        [Column("FREIGHTCHARGEAMOUNT", TypeName = "decimal(22, 5)")]
        public decimal? Freightchargeamount { get; set; }
        [Column("FREIGHTCOSTAMOUNT", TypeName = "decimal(22, 5)")]
        public decimal? Freightcostamount { get; set; }
        [Column("APPOINTMENTKEY")]
        [StringLength(10)]
        public string Appointmentkey { get; set; }
        public int? AllowOverPick { get; set; }
        [Column("TOTALQTY", TypeName = "decimal(22, 5)")]
        public decimal? Totalqty { get; set; }
        [Column("TOTALGROSSWGT", TypeName = "decimal(22, 5)")]
        public decimal? Totalgrosswgt { get; set; }
        [Column("TOTALCUBE", TypeName = "decimal(22, 5)")]
        public decimal? Totalcube { get; set; }
        [Column("TOTALORDERLINES")]
        public int? Totalorderlines { get; set; }
        [StringLength(64)]
        public string ReferenceAccountingEntity { get; set; }
        [Column("POKEY")]
        [StringLength(50)]
        public string Pokey { get; set; }
        [Required]
        [Column("APPORTION")]
        [StringLength(1)]
        public string Apportion { get; set; }
        [Column("CONTAINERID")]
        [StringLength(18)]
        public string Containerid { get; set; }
        [Column("PROMISEDSHIPDATE", TypeName = "datetime")]
        public DateTime? Promisedshipdate { get; set; }
        [Column("PLANNEDSHIPDATE", TypeName = "datetime")]
        public DateTime? Plannedshipdate { get; set; }
        [Column("SCHEDULEDSHIPDATE", TypeName = "datetime")]
        public DateTime? Scheduledshipdate { get; set; }
        [Column("PROMISEDDELVDATE", TypeName = "datetime")]
        public DateTime? Promiseddelvdate { get; set; }
        [Column("PLANNEDDELVDATE", TypeName = "datetime")]
        public DateTime? Planneddelvdate { get; set; }
        [Column("SCHEDULEDDELVDATE", TypeName = "datetime")]
        public DateTime? Scheduleddelvdate { get; set; }
        [Column("ACTUALDELVDATE", TypeName = "datetime")]
        public DateTime? Actualdelvdate { get; set; }
        [Column("EARLIESTSHIPDATE", TypeName = "datetime")]
        public DateTime? Earliestshipdate { get; set; }
        [Column("EARLIESTDELIVERYDATE", TypeName = "datetime")]
        public DateTime? Earliestdeliverydate { get; set; }
        [Column("CARRIERROUTEDOCUMENT")]
        [StringLength(64)]
        public string Carrierroutedocument { get; set; }
        [Column("CARRIERROUTEACCOUNTINGENTITY")]
        [StringLength(64)]
        public string Carrierrouteaccountingentity { get; set; }
        [Column("CARRIERROUTELOCATION")]
        [StringLength(64)]
        public string Carrierroutelocation { get; set; }
        [Column("CARRIERROUTEVERSION")]
        [StringLength(20)]
        public string Carrierrouteversion { get; set; }
        [Column("TMHOUSEAIRWAYBILLNUMBER")]
        [StringLength(64)]
        public string Tmhouseairwaybillnumber { get; set; }
        [Column("TMMASTERAIRWAYBILLNUMBER")]
        [StringLength(64)]
        public string Tmmasterairwaybillnumber { get; set; }
        [Column("TMBOOKINGNUMBER")]
        [StringLength(64)]
        public string Tmbookingnumber { get; set; }
        [Column("TMHOUSEOCEANBOLNUMBER")]
        [StringLength(64)]
        public string Tmhouseoceanbolnumber { get; set; }
        [Column("TMMASTEROCEANBOLNUMBER")]
        [StringLength(64)]
        public string Tmmasteroceanbolnumber { get; set; }
        [Column("TMEQUIPMENTNUMBER")]
        [StringLength(64)]
        public string Tmequipmentnumber { get; set; }
        [Column("TMSEALNUMBER")]
        [StringLength(64)]
        public string Tmsealnumber { get; set; }
        [Column("TMLICENSEPLATENUMBER")]
        [StringLength(64)]
        public string Tmlicenseplatenumber { get; set; }
        [Column("TMEQUIPMENTTYPE")]
        [StringLength(30)]
        public string Tmequipmenttype { get; set; }
        [Column("TMEQUIPMENTLENGTH")]
        [StringLength(10)]
        public string Tmequipmentlength { get; set; }
        [Column("TMEQUIPMENTATTRIBUTE")]
        [StringLength(64)]
        public string Tmequipmentattribute { get; set; }
        [Column("TMAIRSERVICELEVEL")]
        [StringLength(30)]
        public string Tmairservicelevel { get; set; }
        [Column("TMOCEANSERVICELEVEL")]
        [StringLength(30)]
        public string Tmoceanservicelevel { get; set; }
        [Column("TMOCEANTARIFFSERVICE")]
        [StringLength(30)]
        public string Tmoceantariffservice { get; set; }
        [Column("TMPORTOFLOADING")]
        [StringLength(64)]
        public string Tmportofloading { get; set; }
        [Column("TMPORTOFDISCHARGE")]
        [StringLength(64)]
        public string Tmportofdischarge { get; set; }
        [Column("TMROUTEDVIA")]
        [StringLength(64)]
        public string Tmroutedvia { get; set; }
        [Column("TMSERVICEATTRIBUTE")]
        [StringLength(64)]
        public string Tmserviceattribute { get; set; }
        [Column("TMFREIGHTCOSTCURRENCY")]
        [StringLength(3)]
        public string Tmfreightcostcurrency { get; set; }
        [Column("TMFREIGHTCHARGECURRENCY")]
        [StringLength(3)]
        public string Tmfreightchargecurrency { get; set; }
        [Column("ACTUALARRIVALDATE", TypeName = "datetime")]
        public DateTime? Actualarrivaldate { get; set; }
        [Column("C_ADDRESS5")]
        [StringLength(45)]
        public string CAddress5 { get; set; }
        [Column("C_ADDRESS6")]
        [StringLength(45)]
        public string CAddress6 { get; set; }
        [Column("B_ADDRESS5")]
        [StringLength(45)]
        public string BAddress5 { get; set; }
        [Column("B_ADDRESS6")]
        [StringLength(45)]
        public string BAddress6 { get; set; }
        [Column("RETURNTOPARTY")]
        [StringLength(64)]
        public string Returntoparty { get; set; }
        [Column("TRAILERKEY")]
        [StringLength(20)]
        public string Trailerkey { get; set; }
        [Column("CARRIERROUTESTATUS")]
        [StringLength(10)]
        public string Carrierroutestatus { get; set; }
        [Required]
        [Column("SPLITSHIPMENTINDICATOR")]
        [StringLength(1)]
        public string Splitshipmentindicator { get; set; }
        [Column("SPLITSHIPMENTORIGINALORDERKEY")]
        [StringLength(32)]
        public string Splitshipmentoriginalorderkey { get; set; }
        [Column("SPLITSHIPMENTFINALSHIPMENT")]
        [StringLength(1)]
        public string Splitshipmentfinalshipment { get; set; }
        [Column("BODAPPLICATIONAREA", TypeName = "ntext")]
        public string Bodapplicationarea { get; set; }
        [Column("FREIGHTCOSTBASEAMOUNT", TypeName = "decimal(22, 5)")]
        public decimal? Freightcostbaseamount { get; set; }
        [Column("FREIGHTCHARGEBASEAMOUNT", TypeName = "decimal(22, 5)")]
        public decimal? Freightchargebaseamount { get; set; }
        [Column("PACKINGVALTEMPLATE")]
        [StringLength(10)]
        public string Packingvaltemplate { get; set; }
        [Column("PACKNOTES")]
        [StringLength(255)]
        public string Packnotes { get; set; }
        [Column("TOTALROUTES", TypeName = "decimal(22, 5)")]
        public decimal? Totalroutes { get; set; }
        [Column("AUTODOORASSIGNED")]
        [StringLength(10)]
        public string Autodoorassigned { get; set; }
        [Column("AUTOSTAGEASSIGNED")]
        [StringLength(10)]
        public string Autostageassigned { get; set; }
        [Column("AUTOPACKASSIGNED")]
        [StringLength(10)]
        public string Autopackassigned { get; set; }
        [Column("AUTODOCKASSIGNEDHOW")]
        [StringLength(10)]
        public string Autodockassignedhow { get; set; }
        [Column("AUTODOCKASSIGNEDSET")]
        [StringLength(20)]
        public string Autodockassignedset { get; set; }
        [Column("AUTODOCKASSIGNEDSTEP")]
        public int? Autodockassignedstep { get; set; }
        [Column("AUTODOCKASSIGNTIME", TypeName = "datetime")]
        public DateTime? Autodockassigntime { get; set; }
        [Column("TOTALPALLETESTIMATE")]
        public int? Totalpalletestimate { get; set; }
        [Column("REQUIREORDERCLOSE")]
        [StringLength(1)]
        public string Requireorderclose { get; set; }
        [Column("NOTES")]
        [StringLength(2000)]
        public string Notes { get; set; }
        [Column("SPSAPISTRATEGYKEY")]
        [StringLength(10)]
        public string Spsapistrategykey { get; set; }
        [Column("BOLNUMBER")]
        [StringLength(20)]
        public string Bolnumber { get; set; }
        [Required]
        [Column("BOLPRINTED")]
        [StringLength(1)]
        public string Bolprinted { get; set; }
        [Column("SHIPTOGROUP")]
        [StringLength(10)]
        public string Shiptogroup { get; set; }
        [Column("ADDDATE", TypeName = "datetime")]
        public DateTime Adddate { get; set; }
        [Required]
        [Column("ADDWHO")]
        [StringLength(18)]
        public string Addwho { get; set; }
        [Column("EDITDATE", TypeName = "datetime")]
        public DateTime Editdate { get; set; }
        [Required]
        [Column("EDITWHO")]
        [StringLength(18)]
        public string Editwho { get; set; }
        [Required]
        [Column("HOSTPROCESSREQUIRED")]
        [StringLength(1)]
        public string Hostprocessrequired { get; set; }
        [Column("BATCHORDERNUMBER")]
        [StringLength(10)]
        public string Batchordernumber { get; set; }

        [InverseProperty(nameof(Orderdetail.OrderkeyNavigation))]
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}
