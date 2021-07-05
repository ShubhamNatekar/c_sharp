using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MvcProject.Models
{
    [Table("ORDERDETAIL", Schema = "wmwhse1")]
    [Index(nameof(Serialkey), Name = "ORD_169_UNIQUE", IsUnique = true)]
    public partial class Orderdetail
    {
        [Column("SERIALKEY")]
        public int Serialkey { get; set; }
        [Column("WHSEID")]
        [StringLength(30)]
        public string Whseid { get; set; }
        [Key]
        [Column("ORDERKEY")]
        [StringLength(10)]
        public string Orderkey { get; set; }
        [Key]
        [Column("ORDERLINENUMBER")]
        [StringLength(5)]
        public string Orderlinenumber { get; set; }
        [Column("ORDERDETAILSYSID")]
        public int? Orderdetailsysid { get; set; }
        [Required]
        [Column("EXTERNORDERKEY")]
        [StringLength(32)]
        public string Externorderkey { get; set; }
        [Required]
        [Column("EXTERNLINENO")]
        [StringLength(20)]
        public string Externlineno { get; set; }
        [Required]
        [Column("SKU")]
        [StringLength(50)]
        public string Sku { get; set; }
        [Required]
        [Column("STORERKEY")]
        [StringLength(15)]
        public string Storerkey { get; set; }
        [Required]
        [Column("MANUFACTURERSKU")]
        [StringLength(50)]
        public string Manufacturersku { get; set; }
        [Required]
        [Column("RETAILSKU")]
        [StringLength(50)]
        public string Retailsku { get; set; }
        [Required]
        [Column("ALTSKU")]
        [StringLength(50)]
        public string Altsku { get; set; }
        [Column("ORIGINALQTY", TypeName = "decimal(22, 5)")]
        public decimal Originalqty { get; set; }
        [Column("OPENQTY", TypeName = "decimal(22, 5)")]
        public decimal Openqty { get; set; }
        [Column("SHIPPEDQTY", TypeName = "decimal(22, 5)")]
        public decimal Shippedqty { get; set; }
        [Column("ADJUSTEDQTY", TypeName = "decimal(22, 5)")]
        public decimal Adjustedqty { get; set; }
        [Column("QTYPREALLOCATED", TypeName = "decimal(22, 5)")]
        public decimal Qtypreallocated { get; set; }
        [Column("QTYALLOCATED", TypeName = "decimal(22, 5)")]
        public decimal Qtyallocated { get; set; }
        [Column("QTYPICKED", TypeName = "decimal(22, 5)")]
        public decimal Qtypicked { get; set; }
        [Required]
        [Column("UOM")]
        [StringLength(10)]
        public string Uom { get; set; }
        [Required]
        [Column("PACKKEY")]
        [StringLength(50)]
        public string Packkey { get; set; }
        [Required]
        [Column("PICKCODE")]
        [StringLength(10)]
        public string Pickcode { get; set; }
        [Required]
        [Column("CARTONGROUP")]
        [StringLength(10)]
        public string Cartongroup { get; set; }
        [Required]
        [Column("LOT")]
        [StringLength(10)]
        public string Lot { get; set; }
        [Required]
        [Column("ID")]
        [StringLength(50)]
        public string Id { get; set; }
        [Required]
        [Column("FACILITY")]
        [StringLength(20)]
        public string Facility { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("UNITPRICE")]
        public double Unitprice { get; set; }
        [Column("TAX01")]
        public double Tax01 { get; set; }
        [Column("TAX02")]
        public double Tax02 { get; set; }
        [Column("EXTENDEDPRICE")]
        public double Extendedprice { get; set; }
        [Required]
        [Column("UPDATESOURCE")]
        [StringLength(10)]
        public string Updatesource { get; set; }
        [Required]
        [Column("LOTTABLE01")]
        [StringLength(50)]
        public string Lottable01 { get; set; }
        [Required]
        [Column("LOTTABLE02")]
        [StringLength(50)]
        public string Lottable02 { get; set; }
        [Required]
        [Column("LOTTABLE03")]
        [StringLength(50)]
        public string Lottable03 { get; set; }
        [Column("LOTTABLE04", TypeName = "datetime")]
        public DateTime? Lottable04 { get; set; }
        [Column("LOTTABLE05", TypeName = "datetime")]
        public DateTime? Lottable05 { get; set; }
        [Required]
        [Column("LOTTABLE06")]
        [StringLength(50)]
        public string Lottable06 { get; set; }
        [Required]
        [Column("LOTTABLE07")]
        [StringLength(50)]
        public string Lottable07 { get; set; }
        [Required]
        [Column("LOTTABLE08")]
        [StringLength(50)]
        public string Lottable08 { get; set; }
        [Required]
        [Column("LOTTABLE09")]
        [StringLength(50)]
        public string Lottable09 { get; set; }
        [Required]
        [Column("LOTTABLE10")]
        [StringLength(50)]
        public string Lottable10 { get; set; }
        [Column("EFFECTIVEDATE", TypeName = "datetime")]
        public DateTime? Effectivedate { get; set; }
        [Required]
        [Column("FORTE_FLAG")]
        [StringLength(6)]
        public string ForteFlag { get; set; }
        [Column("TARIFFKEY")]
        [StringLength(10)]
        public string Tariffkey { get; set; }
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
        [Column("NOTES")]
        [StringLength(2000)]
        public string Notes { get; set; }
        [Column("WORKORDERKEY")]
        [StringLength(10)]
        public string Workorderkey { get; set; }
        [Column("ALLOCATESTRATEGYKEY")]
        [StringLength(10)]
        public string Allocatestrategykey { get; set; }
        [Column("PREALLOCATESTRATEGYKEY")]
        [StringLength(10)]
        public string Preallocatestrategykey { get; set; }
        [Column("ALLOCATESTRATEGYTYPE")]
        [StringLength(10)]
        public string Allocatestrategytype { get; set; }
        [Column("SKUROTATION")]
        [StringLength(10)]
        public string Skurotation { get; set; }
        [Column("SHELFLIFE")]
        public int? Shelflife { get; set; }
        [Column("ROTATION")]
        [StringLength(1)]
        public string Rotation { get; set; }
        [Column("PALLET_ID")]
        [StringLength(50)]
        public string PalletId { get; set; }
        [Column("SUB_FLAG")]
        [StringLength(1)]
        public string SubFlag { get; set; }
        [Column("PRODUCT_WEIGHT")]
        public double ProductWeight { get; set; }
        [Column("PRODUCT_CUBE")]
        public double ProductCube { get; set; }
        [Column("ORIGCASEQTY", TypeName = "decimal(22, 5)")]
        public decimal Origcaseqty { get; set; }
        [Column("ORIGPALLETQTY", TypeName = "decimal(22, 5)")]
        public decimal Origpalletqty { get; set; }
        [Column("OKTOSUBSTITUTE")]
        public int Oktosubstitute { get; set; }
        [Column("ISSUBSTITUTE")]
        public int Issubstitute { get; set; }
        [Column("ORIGINALSKU")]
        [StringLength(50)]
        public string Originalsku { get; set; }
        [Column("ORIGINALLINENUMBER")]
        [StringLength(5)]
        public string Originallinenumber { get; set; }
        [Required]
        [Column("SHIPGROUP01")]
        [StringLength(1)]
        public string Shipgroup01 { get; set; }
        [Required]
        [Column("SHIPGROUP02")]
        [StringLength(1)]
        public string Shipgroup02 { get; set; }
        [Required]
        [Column("SHIPGROUP03")]
        [StringLength(1)]
        public string Shipgroup03 { get; set; }
        [Column("ACTUALSHIPDATE", TypeName = "datetime")]
        public DateTime? Actualshipdate { get; set; }
        [Column("INTERMODALVEHICLE")]
        [StringLength(10)]
        public string Intermodalvehicle { get; set; }
        [Column("PICKINGINSTRUCTIONS")]
        [StringLength(255)]
        public string Pickinginstructions { get; set; }
        [Column("CARTONBREAK")]
        [StringLength(10)]
        public string Cartonbreak { get; set; }
        [Column("CARTONQTYBREAK")]
        public int? Cartonqtybreak { get; set; }
        [Column("QTYINTRANSIT", TypeName = "decimal(22, 5)")]
        public decimal Qtyintransit { get; set; }
        [Column("OPPREQUEST")]
        [StringLength(1)]
        public string Opprequest { get; set; }
        [Required]
        [Column("WPRELEASED")]
        [StringLength(1)]
        public string Wpreleased { get; set; }
        [Column("EXTERNALLOT")]
        [StringLength(100)]
        public string Externallot { get; set; }
        [Column("BUYERPO")]
        [StringLength(50)]
        public string Buyerpo { get; set; }
        [Required]
        [StringLength(1)]
        public string GenerateContainerDetail { get; set; }
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
        [Column("EXTERNALLOCSEQUENCE")]
        [StringLength(20)]
        public string Externallocsequence { get; set; }
        [Column("MINSHIPPERCENT")]
        public int Minshippercent { get; set; }
        [Column("LINETYPE")]
        [StringLength(1)]
        public string Linetype { get; set; }
        [Column("COMPONENTQTY", TypeName = "decimal(22, 5)")]
        public decimal? Componentqty { get; set; }
        [Column("COMPONENTREFERENCE")]
        [StringLength(50)]
        public string Componentreference { get; set; }
        [Required]
        [Column("OQCREQUIRED")]
        [StringLength(1)]
        public string Oqcrequired { get; set; }
        [Required]
        [Column("OQCAUTOADJUST")]
        [StringLength(1)]
        public string Oqcautoadjust { get; set; }
        [Column("ORDERDETAILID")]
        [StringLength(32)]
        public string Orderdetailid { get; set; }
        [Column("LOTTABLE11", TypeName = "datetime")]
        public DateTime? Lottable11 { get; set; }
        [Column("LOTTABLE12", TypeName = "datetime")]
        public DateTime? Lottable12 { get; set; }
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
        [Column("REFERENCELINE")]
        [StringLength(20)]
        public string Referenceline { get; set; }
        [Column("CUBICMETER", TypeName = "decimal(22, 5)")]
        public decimal? Cubicmeter { get; set; }
        [Column("HUNDREDWEIGHT", TypeName = "decimal(22, 5)")]
        public decimal? Hundredweight { get; set; }
        [StringLength(20)]
        public string StageLoc { get; set; }
        [Column("FULFILLQTY", TypeName = "decimal(22, 5)")]
        public decimal Fulfillqty { get; set; }
        [Column("DAPICKSORT")]
        [StringLength(1)]
        public string Dapicksort { get; set; }
        [Column("SHORTSHIPREASON")]
        [StringLength(10)]
        public string Shortshipreason { get; set; }
        [Column("ORIGLAYERQTY", TypeName = "decimal(22, 5)")]
        public decimal Origlayerqty { get; set; }
        [StringLength(64)]
        public string ReferenceAccountingEntity { get; set; }
        [StringLength(20)]
        public string ReferenceScheduleLine { get; set; }
        [Column("BASEORDERKEY")]
        [StringLength(10)]
        public string Baseorderkey { get; set; }
        [Column("CONVERTEDQTY", TypeName = "decimal(22, 5)")]
        public decimal? Convertedqty { get; set; }
        [Column("PROCESSEDQTY", TypeName = "decimal(22, 5)")]
        public decimal? Processedqty { get; set; }
        [Column("QTYTOPROCESS", TypeName = "decimal(22, 5)")]
        public decimal? Qtytoprocess { get; set; }
        [Column("SEQUENCE", TypeName = "decimal(18, 0)")]
        public decimal? Sequence { get; set; }
        [Column("REQUISITIONDOCUMENT")]
        [StringLength(64)]
        public string Requisitiondocument { get; set; }
        [Column("REQUISITIONACCOUNTINGENTITY")]
        [StringLength(64)]
        public string Requisitionaccountingentity { get; set; }
        [Column("REQUISITIONLOCATION")]
        [StringLength(64)]
        public string Requisitionlocation { get; set; }
        [Column("REQUISITIONVERSION")]
        [StringLength(20)]
        public string Requisitionversion { get; set; }
        [Column("REQUISITIONLINE")]
        [StringLength(20)]
        public string Requisitionline { get; set; }
        [Column("REQUISITIONSCHEDULELINE")]
        [StringLength(20)]
        public string Requisitionscheduleline { get; set; }
        [Column("PURCHASEORDERDOCUMENT")]
        [StringLength(64)]
        public string Purchaseorderdocument { get; set; }
        [Column("PURCHASEORDERACCOUNTINGENTITY")]
        [StringLength(64)]
        public string Purchaseorderaccountingentity { get; set; }
        [Column("PURCHASEORDERLOCATION")]
        [StringLength(64)]
        public string Purchaseorderlocation { get; set; }
        [Column("PURCHASEORDERVERSION")]
        [StringLength(20)]
        public string Purchaseorderversion { get; set; }
        [Column("PURCHASEORDERLINE")]
        [StringLength(20)]
        public string Purchaseorderline { get; set; }
        [Column("PURCHASEORDERSCHEDULELINE")]
        [StringLength(20)]
        public string Purchaseorderscheduleline { get; set; }
        [Column("SALESORDERDOCUMENT")]
        [StringLength(64)]
        public string Salesorderdocument { get; set; }
        [Column("SALESORDERACCOUNTINGENTITY")]
        [StringLength(64)]
        public string Salesorderaccountingentity { get; set; }
        [Column("SALESORDERLOCATION")]
        [StringLength(64)]
        public string Salesorderlocation { get; set; }
        [Column("SALESORDERVERSION")]
        [StringLength(20)]
        public string Salesorderversion { get; set; }
        [Column("SALESORDERLINE")]
        [StringLength(20)]
        public string Salesorderline { get; set; }
        [Column("SALESORDERSCHEDULELINE")]
        [StringLength(20)]
        public string Salesorderscheduleline { get; set; }
        [Column("IDREQUIRED")]
        [StringLength(18)]
        public string Idrequired { get; set; }
        [Column("KITORDERASN")]
        [StringLength(10)]
        public string Kitorderasn { get; set; }
        [Column("PALLETESTIMATE", TypeName = "decimal(22, 5)")]
        public decimal? Palletestimate { get; set; }
        [Column("BACKFLUSHINDICATOR")]
        [StringLength(1)]
        public string Backflushindicator { get; set; }
        [Column("ALLOCLOTLIMIT")]
        [StringLength(1)]
        public string Alloclotlimit { get; set; }
        [Column("LASTSHIPPEDDATE", TypeName = "datetime")]
        public DateTime? Lastshippeddate { get; set; }
        [Required]
        [Column("LABELSPRINTED")]
        [StringLength(1)]
        public string Labelsprinted { get; set; }
        [Column("NEWALLOCATIONSTRATEGY")]
        [StringLength(10)]
        public string Newallocationstrategy { get; set; }
        [Column("ITEMCLASS")]
        [StringLength(10)]
        public string Itemclass { get; set; }
        [Column("RUNINQTY", TypeName = "decimal(22, 5)")]
        public decimal? Runinqty { get; set; }
        [Column("RUNOUTQTY", TypeName = "decimal(22, 5)")]
        public decimal? Runoutqty { get; set; }
        [Column("FGQTYRECEIVED", TypeName = "decimal(22, 5)")]
        public decimal? Fgqtyreceived { get; set; }
        [Column("RUNINUOM")]
        [StringLength(10)]
        public string Runinuom { get; set; }
        [Column("RUNOUTUOM")]
        [StringLength(10)]
        public string Runoutuom { get; set; }
        [Column("EXTERNALSHIPREQUESTQTY", TypeName = "decimal(22, 5)")]
        public decimal? Externalshiprequestqty { get; set; }
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
        [Column("BATCHORDERNUMBER")]
        [StringLength(10)]
        public string Batchordernumber { get; set; }
        [Column("BATCHORDERLINE")]
        [StringLength(5)]
        public string Batchorderline { get; set; }
        [Column("ORIGORDERNUMBER")]
        [StringLength(10)]
        public string Origordernumber { get; set; }
        [Column("ORIGORDERLINE")]
        [StringLength(5)]
        public string Origorderline { get; set; }

        [ForeignKey(nameof(Orderkey))]
        [InverseProperty(nameof(Order.Orderdetails))]
        public virtual Order OrderkeyNavigation { get; set; }
        [ForeignKey("Sku,Storerkey")]
        [InverseProperty("Orderdetails")]
        public virtual Sku S { get; set; }
    }
}
