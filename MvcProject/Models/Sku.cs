using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MvcProject.Models
{
    [Table("SKU", Schema = "wmwhse1")]
    [Index(nameof(Serialkey), Name = "SKU_245_UNIQUE", IsUnique = true)]
    public partial class Sku
    {
        public Sku()
        {
            Orderdetails = new HashSet<Orderdetail>();
        }

        [Column("SERIALKEY")]
        public int Serialkey { get; set; }
        [Column("WHSEID")]
        [StringLength(30)]
        public string Whseid { get; set; }
        [Key]
        [Column("STORERKEY")]
        [StringLength(15)]
        public string Storerkey { get; set; }
        [Key]
        [Column("SKU")]
        [StringLength(50)]
        public string Sku1 { get; set; }
        [Required]
        [Column("SOURCEVERSION")]
        [StringLength(22)]
        public string Sourceversion { get; set; }
        [Required]
        [Column("HAZMATCODESKEY")]
        [StringLength(10)]
        public string Hazmatcodeskey { get; set; }
        [Required]
        [Column("ITEMREFERENCE")]
        [StringLength(8)]
        public string Itemreference { get; set; }
        [Column("SERIALNUMBERSTART", TypeName = "decimal(15, 0)")]
        public decimal? Serialnumberstart { get; set; }
        [Column("SERIALNUMBEREND", TypeName = "decimal(15, 0)")]
        public decimal? Serialnumberend { get; set; }
        [Column("SERIALNUMBERNEXT", TypeName = "decimal(15, 0)")]
        public decimal? Serialnumbernext { get; set; }
        [Column("DESCR")]
        [StringLength(60)]
        public string Descr { get; set; }
        [Column("SUSR1")]
        [StringLength(18)]
        public string Susr1 { get; set; }
        [Column("SUSR2")]
        [StringLength(18)]
        public string Susr2 { get; set; }
        [Column("SUSR3")]
        [StringLength(18)]
        public string Susr3 { get; set; }
        [Column("SUSR4")]
        [StringLength(18)]
        public string Susr4 { get; set; }
        [Column("SUSR5")]
        [StringLength(18)]
        public string Susr5 { get; set; }
        [Column("MANUFACTURERSKU")]
        [StringLength(50)]
        public string Manufacturersku { get; set; }
        [Column("RETAILSKU")]
        [StringLength(50)]
        public string Retailsku { get; set; }
        [Column("ALTSKU")]
        [StringLength(50)]
        public string Altsku { get; set; }
        [Required]
        [Column("PACKKEY")]
        [StringLength(50)]
        public string Packkey { get; set; }
        [Column("STDGROSSWGT", TypeName = "decimal(22, 5)")]
        public decimal Stdgrosswgt { get; set; }
        [Column("STDNETWGT", TypeName = "decimal(22, 5)")]
        public decimal Stdnetwgt { get; set; }
        [Column("STDCUBE", TypeName = "decimal(22, 5)")]
        public decimal Stdcube { get; set; }
        [Column("TARE", TypeName = "decimal(22, 5)")]
        public decimal Tare { get; set; }
        [Required]
        [Column("CLASS")]
        [StringLength(10)]
        public string Class { get; set; }
        [Required]
        [Column("ACTIVE")]
        [StringLength(10)]
        public string Active { get; set; }
        [Required]
        [Column("SKUGROUP")]
        [StringLength(10)]
        public string Skugroup { get; set; }
        [Column("TARIFFKEY")]
        [StringLength(10)]
        public string Tariffkey { get; set; }
        [Column("BUSR1")]
        [StringLength(30)]
        public string Busr1 { get; set; }
        [Column("BUSR2")]
        [StringLength(30)]
        public string Busr2 { get; set; }
        [Column("BUSR3")]
        [StringLength(30)]
        public string Busr3 { get; set; }
        [Column("BUSR4")]
        [StringLength(30)]
        public string Busr4 { get; set; }
        [Column("BUSR5")]
        [StringLength(30)]
        public string Busr5 { get; set; }
        [Required]
        [Column("LOTTABLE01LABEL")]
        [StringLength(20)]
        public string Lottable01label { get; set; }
        [Required]
        [Column("LOTTABLE02LABEL")]
        [StringLength(20)]
        public string Lottable02label { get; set; }
        [Required]
        [Column("LOTTABLE03LABEL")]
        [StringLength(20)]
        public string Lottable03label { get; set; }
        [Required]
        [Column("LOTTABLE04LABEL")]
        [StringLength(20)]
        public string Lottable04label { get; set; }
        [Required]
        [Column("LOTTABLE05LABEL")]
        [StringLength(20)]
        public string Lottable05label { get; set; }
        [Required]
        [Column("LOTTABLE06LABEL")]
        [StringLength(20)]
        public string Lottable06label { get; set; }
        [Required]
        [Column("LOTTABLE07LABEL")]
        [StringLength(20)]
        public string Lottable07label { get; set; }
        [Required]
        [Column("LOTTABLE08LABEL")]
        [StringLength(20)]
        public string Lottable08label { get; set; }
        [Required]
        [Column("LOTTABLE09LABEL")]
        [StringLength(20)]
        public string Lottable09label { get; set; }
        [Required]
        [Column("LOTTABLE10LABEL")]
        [StringLength(20)]
        public string Lottable10label { get; set; }
        [Required]
        [Column("PICKCODE")]
        [StringLength(10)]
        public string Pickcode { get; set; }
        [Column("STRATEGYKEY")]
        [StringLength(10)]
        public string Strategykey { get; set; }
        [Required]
        [Column("CARTONGROUP")]
        [StringLength(10)]
        public string Cartongroup { get; set; }
        [Required]
        [Column("PUTCODE")]
        [StringLength(10)]
        public string Putcode { get; set; }
        [Required]
        [Column("PUTAWAYLOC")]
        [StringLength(10)]
        public string Putawayloc { get; set; }
        [Column("PUTAWAYZONE")]
        [StringLength(10)]
        public string Putawayzone { get; set; }
        [Column("INNERPACK", TypeName = "decimal(22, 5)")]
        public decimal Innerpack { get; set; }
        [Column("CUBE")]
        public double Cube { get; set; }
        [Column("GROSSWGT")]
        public double Grosswgt { get; set; }
        [Column("NETWGT")]
        public double Netwgt { get; set; }
        [Column("ABC")]
        [StringLength(5)]
        public string Abc { get; set; }
        [Column("CYCLECOUNTFREQUENCY")]
        public int? Cyclecountfrequency { get; set; }
        [Column("LASTCYCLECOUNT", TypeName = "datetime")]
        public DateTime? Lastcyclecount { get; set; }
        [Column("REORDERPOINT")]
        public int? Reorderpoint { get; set; }
        [Column("REORDERQTY", TypeName = "decimal(22, 5)")]
        public decimal? Reorderqty { get; set; }
        [Column("STDORDERCOST")]
        public double? Stdordercost { get; set; }
        [Column("CARRYCOST")]
        public double? Carrycost { get; set; }
        [Column("PRICE", TypeName = "decimal(19, 4)")]
        public decimal? Price { get; set; }
        [Column("COST", TypeName = "decimal(19, 4)")]
        public decimal? Cost { get; set; }
        [Required]
        [Column("ONRECEIPTCOPYPACKKEY")]
        [StringLength(10)]
        public string Onreceiptcopypackkey { get; set; }
        [Column("RECEIPTHOLDCODE")]
        [StringLength(10)]
        public string Receiptholdcode { get; set; }
        [Required]
        [Column("RECEIPTINSPECTIONLOC")]
        [StringLength(10)]
        public string Receiptinspectionloc { get; set; }
        [Column("ROTATEBY")]
        [StringLength(10)]
        public string Rotateby { get; set; }
        [Column("DATECODEDAYS")]
        public int? Datecodedays { get; set; }
        [Column("DEFAULTROTATION")]
        [StringLength(1)]
        public string Defaultrotation { get; set; }
        [Required]
        [Column("SHIPPABLECONTAINER")]
        [StringLength(10)]
        public string Shippablecontainer { get; set; }
        [Column("IOFLAG")]
        [StringLength(5)]
        public string Ioflag { get; set; }
        [Column("TAREWEIGHT", TypeName = "decimal(22, 5)")]
        public decimal? Tareweight { get; set; }
        [Column("LOTXIDDETAILOTHERLABEL1")]
        [StringLength(30)]
        public string Lotxiddetailotherlabel1 { get; set; }
        [Column("LOTXIDDETAILOTHERLABEL2")]
        [StringLength(30)]
        public string Lotxiddetailotherlabel2 { get; set; }
        [Column("LOTXIDDETAILOTHERLABEL3")]
        [StringLength(30)]
        public string Lotxiddetailotherlabel3 { get; set; }
        [Column("AVGCASEWEIGHT", TypeName = "decimal(22, 5)")]
        public decimal? Avgcaseweight { get; set; }
        [Column("TOLERANCEPCT", TypeName = "decimal(12, 6)")]
        public decimal? Tolerancepct { get; set; }
        [Column("SHELFLIFEINDICATOR")]
        [StringLength(10)]
        public string Shelflifeindicator { get; set; }
        [Column("SHELFLIFE")]
        public int? Shelflife { get; set; }
        [Column("TRANSPORTATIONMODE")]
        [StringLength(30)]
        public string Transportationmode { get; set; }
        [Column("SKUGROUP2")]
        [StringLength(30)]
        public string Skugroup2 { get; set; }
        [Column("SUSR6")]
        [StringLength(30)]
        public string Susr6 { get; set; }
        [Column("SUSR7")]
        [StringLength(30)]
        public string Susr7 { get; set; }
        [Column("SUSR8")]
        [StringLength(30)]
        public string Susr8 { get; set; }
        [Column("SUSR9")]
        [StringLength(30)]
        public string Susr9 { get; set; }
        [Column("SUSR10")]
        [StringLength(30)]
        public string Susr10 { get; set; }
        [Column("BUSR6")]
        [StringLength(30)]
        public string Busr6 { get; set; }
        [Column("BUSR7")]
        [StringLength(30)]
        public string Busr7 { get; set; }
        [Column("BUSR8")]
        [StringLength(30)]
        public string Busr8 { get; set; }
        [Column("BUSR9")]
        [StringLength(30)]
        public string Busr9 { get; set; }
        [Column("BUSR10")]
        [StringLength(30)]
        public string Busr10 { get; set; }
        [Column("MINIMUMSHELFLIFEONRFPICKING", TypeName = "decimal(10, 0)")]
        public decimal Minimumshelflifeonrfpicking { get; set; }
        [Column("FREIGHTCLASS")]
        [StringLength(10)]
        public string Freightclass { get; set; }
        [Column("ICWFLAG")]
        [StringLength(1)]
        public string Icwflag { get; set; }
        [Column("ICWBY")]
        [StringLength(1)]
        public string Icwby { get; set; }
        [Column("IDEWEIGHT")]
        [StringLength(1)]
        public string Ideweight { get; set; }
        [Column("ICDFLAG")]
        [StringLength(1)]
        public string Icdflag { get; set; }
        [Column("ICDLABEL1")]
        [StringLength(5)]
        public string Icdlabel1 { get; set; }
        [Column("ICDLABEL2")]
        [StringLength(5)]
        public string Icdlabel2 { get; set; }
        [Column("ICDLABEL3")]
        [StringLength(5)]
        public string Icdlabel3 { get; set; }
        [Column("OCWFLAG")]
        [StringLength(1)]
        public string Ocwflag { get; set; }
        [Column("OCWBY")]
        [StringLength(1)]
        public string Ocwby { get; set; }
        [Column("ODEWEIGHT")]
        [StringLength(1)]
        public string Odeweight { get; set; }
        [Column("OACOVERRIDE")]
        [StringLength(1)]
        public string Oacoverride { get; set; }
        [Column("OCDFLAG")]
        [StringLength(1)]
        public string Ocdflag { get; set; }
        [Column("OCDLABEL1")]
        [StringLength(5)]
        public string Ocdlabel1 { get; set; }
        [Column("OCDLABEL2")]
        [StringLength(5)]
        public string Ocdlabel2 { get; set; }
        [Column("OCDLABEL3")]
        [StringLength(5)]
        public string Ocdlabel3 { get; set; }
        [Column("OTAREWEIGHT", TypeName = "decimal(22, 5)")]
        public decimal? Otareweight { get; set; }
        [Column("OAVGCASEWEIGHT", TypeName = "decimal(22, 5)")]
        public decimal? Oavgcaseweight { get; set; }
        [Column("OTOLERANCEPCT", TypeName = "decimal(12, 6)")]
        public decimal? Otolerancepct { get; set; }
        [Column("RFDEFAULTPACK")]
        [StringLength(50)]
        public string Rfdefaultpack { get; set; }
        [Column("RFDEFAULTUOM")]
        [StringLength(10)]
        public string Rfdefaultuom { get; set; }
        [Required]
        [Column("SHELFLIFECODETYPE")]
        [StringLength(1)]
        public string Shelflifecodetype { get; set; }
        [Column("SHELFLIFEONRECEIVING")]
        public int Shelflifeonreceiving { get; set; }
        [Required]
        [Column("LOTTABLEVALIDATIONKEY")]
        [StringLength(10)]
        public string Lottablevalidationkey { get; set; }
        [Column("ALLOWCONSOLIDATION")]
        [StringLength(1)]
        public string Allowconsolidation { get; set; }
        [Column("MINIMUMWAVEQTY", TypeName = "decimal(22, 5)")]
        public decimal? Minimumwaveqty { get; set; }
        [Column("BULKCARTONGROUP")]
        [StringLength(10)]
        public string Bulkcartongroup { get; set; }
        [Required]
        [Column("PICKUOM")]
        [StringLength(2)]
        public string Pickuom { get; set; }
        [Column("EACHKEY")]
        [StringLength(10)]
        public string Eachkey { get; set; }
        [Column("CASEKEY")]
        [StringLength(10)]
        public string Casekey { get; set; }
        [Column("TYPE")]
        [StringLength(32)]
        public string Type { get; set; }
        [Column("EFFECSTARTDATE", TypeName = "datetime")]
        public DateTime? Effecstartdate { get; set; }
        [Column("EFFECENDDATE", TypeName = "datetime")]
        public DateTime? Effecenddate { get; set; }
        [Column("CONVEYABLE")]
        [StringLength(1)]
        public string Conveyable { get; set; }
        [Column("FLOWTHRUITEM")]
        [StringLength(1)]
        public string Flowthruitem { get; set; }
        [Column("NOTES1")]
        [StringLength(2000)]
        public string Notes1 { get; set; }
        [Column("NOTES2")]
        [StringLength(2000)]
        public string Notes2 { get; set; }
        [Column("VERT_STORAGE")]
        [StringLength(1)]
        public string VertStorage { get; set; }
        [Column("CWFLAG")]
        [StringLength(10)]
        public string Cwflag { get; set; }
        [Column("VERIFYLOT04LOT05")]
        [StringLength(1)]
        public string Verifylot04lot05 { get; set; }
        [Column("PUTAWAYSTRATEGYKEY")]
        [StringLength(10)]
        public string Putawaystrategykey { get; set; }
        [Required]
        [Column("RETURNSLOC")]
        [StringLength(10)]
        public string Returnsloc { get; set; }
        [Required]
        [Column("QCLOC")]
        [StringLength(10)]
        public string Qcloc { get; set; }
        [Required]
        [Column("RECEIPTVALIDATIONTEMPLATE")]
        [StringLength(18)]
        public string Receiptvalidationtemplate { get; set; }
        [Required]
        [Column("SKUTYPE")]
        [StringLength(1)]
        public string Skutype { get; set; }
        public int StackLimit { get; set; }
        public int MaxPalletsPerZone { get; set; }
        [Required]
        [Column("CCDISCREPANCYRULE")]
        [StringLength(10)]
        public string Ccdiscrepancyrule { get; set; }
        [Required]
        [Column("MANUALSETUPREQUIRED")]
        [StringLength(1)]
        public string Manualsetuprequired { get; set; }
        [Column("QCLOCOUT")]
        [StringLength(10)]
        public string Qclocout { get; set; }
        [Column("OCDCATCHWHEN")]
        [StringLength(10)]
        public string Ocdcatchwhen { get; set; }
        [Column("OCDCATCHQTY1")]
        [StringLength(10)]
        public string Ocdcatchqty1 { get; set; }
        [Column("OCDCATCHQTY2")]
        [StringLength(10)]
        public string Ocdcatchqty2 { get; set; }
        [Column("OCDCATCHQTY3")]
        [StringLength(10)]
        public string Ocdcatchqty3 { get; set; }
        [Column("HASIMAGE")]
        [StringLength(1)]
        public string Hasimage { get; set; }
        [Column("GUID")]
        [StringLength(32)]
        public string Guid { get; set; }
        [Column("NONSTOCKEDINDICATOR")]
        [StringLength(1)]
        public string Nonstockedindicator { get; set; }
        [Required]
        [Column("LOTTABLE11LABEL")]
        [StringLength(20)]
        public string Lottable11label { get; set; }
        [Required]
        [Column("LOTTABLE12LABEL")]
        [StringLength(20)]
        public string Lottable12label { get; set; }
        [Column("TOEXPIREDAYS")]
        public int? Toexpiredays { get; set; }
        [Column("TODELIVERBYDAYS")]
        public int? Todeliverbydays { get; set; }
        [Column("TOBESTBYDAYS")]
        public int? Tobestbydays { get; set; }
        [Column("SNUM_POSITION")]
        public int? SnumPosition { get; set; }
        [Column("SNUM_LENGTH")]
        public int? SnumLength { get; set; }
        [Column("SNUM_DELIMITER")]
        [StringLength(1)]
        public string SnumDelimiter { get; set; }
        [Column("SNUM_DELIM_COUNT")]
        public int? SnumDelimCount { get; set; }
        [Column("SNUM_QUANTITY")]
        public int? SnumQuantity { get; set; }
        [Column("SNUM_INCR_POS")]
        public int? SnumIncrPos { get; set; }
        [Column("SNUM_INCR_LENGTH")]
        public int? SnumIncrLength { get; set; }
        [Column("SNUM_ENDTOEND")]
        public int? SnumEndtoend { get; set; }
        [Column("SNUM_MASK")]
        [StringLength(50)]
        public string SnumMask { get; set; }
        [Column("ICDLABEL4")]
        [StringLength(5)]
        public string Icdlabel4 { get; set; }
        [Column("ICDLABEL5")]
        [StringLength(5)]
        public string Icdlabel5 { get; set; }
        [Column("OCDLABEL4")]
        [StringLength(5)]
        public string Ocdlabel4 { get; set; }
        [Column("OCDLABEL5")]
        [StringLength(5)]
        public string Ocdlabel5 { get; set; }
        [Column("ICD1UNIQUE")]
        [StringLength(1)]
        public string Icd1unique { get; set; }
        [Column("OCD1UNIQUE")]
        [StringLength(1)]
        public string Ocd1unique { get; set; }
        [Column("SNUMLONG_DELIMITER")]
        [StringLength(5)]
        public string SnumlongDelimiter { get; set; }
        [Column("SNUMLONG_FIXED")]
        public int? SnumlongFixed { get; set; }
        [Column("SNUM_AUTOINCREMENT")]
        public int? SnumAutoincrement { get; set; }
        [Column("ACCOUNTINGENTITY")]
        [StringLength(64)]
        public string Accountingentity { get; set; }
        [Required]
        [Column("VOICEGROUPINGID")]
        [StringLength(1)]
        public string Voicegroupingid { get; set; }
        [Column("COUNTSEQUENCE")]
        public int Countsequence { get; set; }
        [Column("DAPICKSORT")]
        [StringLength(1)]
        public string Dapicksort { get; set; }
        [Column("RPLNSORT")]
        [StringLength(1)]
        public string Rplnsort { get; set; }
        [Column("CATCHGROSSWGT")]
        public int Catchgrosswgt { get; set; }
        [Column("CATCHNETWGT")]
        public int Catchnetwgt { get; set; }
        [Column("CATCHTAREWGT")]
        public int Catchtarewgt { get; set; }
        [Column("TAREWGT1")]
        public double Tarewgt1 { get; set; }
        [Column("STDNETWGT1")]
        public double Stdnetwgt1 { get; set; }
        [Column("STDGROSSWGT1")]
        public double Stdgrosswgt1 { get; set; }
        [Column("STDUOM")]
        [StringLength(10)]
        public string Stduom { get; set; }
        [Column("ZERODEFAULTWGTFORPICK")]
        public int Zerodefaultwgtforpick { get; set; }
        [Column("FILLQTYUOM")]
        [StringLength(2)]
        public string Fillqtyuom { get; set; }
        [Required]
        [Column("CARTONIZEFT")]
        [StringLength(1)]
        public string Cartonizeft { get; set; }
        [Column("RECURCODE")]
        [StringLength(10)]
        public string Recurcode { get; set; }
        [Column("WGTUOM")]
        [StringLength(20)]
        public string Wgtuom { get; set; }
        [Column("DIMENUOM")]
        [StringLength(20)]
        public string Dimenuom { get; set; }
        [Column("CUBEUOM")]
        [StringLength(20)]
        public string Cubeuom { get; set; }
        [Column("STORAGETYPE")]
        [StringLength(20)]
        public string Storagetype { get; set; }
        [Column("NMFCCLASS")]
        [StringLength(40)]
        public string Nmfcclass { get; set; }
        [Column("MATEABILITYCODE")]
        [StringLength(64)]
        public string Mateabilitycode { get; set; }
        [Column("LOTHOLDCODE")]
        [StringLength(10)]
        public string Lotholdcode { get; set; }
        [Column("AUTORELEASELOTBY")]
        [StringLength(10)]
        public string Autoreleaselotby { get; set; }
        [Column("HOURSTOHOLDLOT", TypeName = "decimal(10, 2)")]
        public decimal? Hourstoholdlot { get; set; }
        [Column("AUTORELEASELPNBY")]
        [StringLength(10)]
        public string Autoreleaselpnby { get; set; }
        [Column("HOURSTOHOLDLPN", TypeName = "decimal(10, 2)")]
        public decimal? Hourstoholdlpn { get; set; }
        [Column("AMSTRATEGYKEY")]
        [StringLength(10)]
        public string Amstrategykey { get; set; }
        [Required]
        [Column("TEMPFORASN")]
        [StringLength(1)]
        public string Tempforasn { get; set; }
        [Column("IBSUMCWFLG")]
        [StringLength(1)]
        public string Ibsumcwflg { get; set; }
        [Column("OBSUMCWFLG")]
        [StringLength(1)]
        public string Obsumcwflg { get; set; }
        [Column("SHOWRFCWONTRANS")]
        [StringLength(1)]
        public string Showrfcwontrans { get; set; }
        [Required]
        [Column("PUTAWAYCLASS")]
        [StringLength(10)]
        public string Putawayclass { get; set; }
        [Column("GROUPFTEACH")]
        [StringLength(1)]
        public string Groupfteach { get; set; }
        [Column("TRANSPORTATIONSERVICE")]
        [StringLength(10)]
        public string Transportationservice { get; set; }
        [Column("SKUFACILITYGROUP")]
        [StringLength(10)]
        public string Skufacilitygroup { get; set; }
        [Column("LOTCTRLATPACK")]
        [StringLength(1)]
        public string Lotctrlatpack { get; set; }
        [Column("LASTCCRELEASEDATE", TypeName = "datetime")]
        public DateTime? Lastccreleasedate { get; set; }
        [Column("DEFAULTEQUIPMENTATTRIBUTE")]
        [StringLength(10)]
        public string Defaultequipmentattribute { get; set; }
        [Column("DEFAULTEQUIPMENTTYPE")]
        [StringLength(10)]
        public string Defaultequipmenttype { get; set; }
        [Column("DEFAULTEQUIPMENTLENGTH")]
        [StringLength(10)]
        public string Defaultequipmentlength { get; set; }
        [Column("BARCODECONFIGKEY")]
        [StringLength(18)]
        public string Barcodeconfigkey { get; set; }
        [Column("AUTOASSIGNCONSLOC")]
        [StringLength(1)]
        public string Autoassignconsloc { get; set; }
        [Column("CONSPICKLOCMIN", TypeName = "decimal(22, 5)")]
        public decimal Conspicklocmin { get; set; }
        [Column("CONSPICKLOCMAX", TypeName = "decimal(22, 5)")]
        public decimal Conspicklocmax { get; set; }
        [Column("CONSPICKMINMAXUOM")]
        [StringLength(10)]
        public string Conspickminmaxuom { get; set; }
        [Column("CONSPICKREPLENUOM")]
        [StringLength(10)]
        public string Conspickreplenuom { get; set; }
        [Column("ROUNDBACKFLUSHQTY")]
        [StringLength(1)]
        public string Roundbackflushqty { get; set; }
        [Column("ITEMCHARACTERISTIC1")]
        [StringLength(25)]
        public string Itemcharacteristic1 { get; set; }
        [Column("ITEMCHARACTERISTIC2")]
        [StringLength(25)]
        public string Itemcharacteristic2 { get; set; }
        [Column("COMMODITYCLASS")]
        [StringLength(25)]
        public string Commodityclass { get; set; }
        [Column("STOCKCATEGORY")]
        [StringLength(25)]
        public string Stockcategory { get; set; }
        [Column("COUNTRYOFORIGIN")]
        [StringLength(25)]
        public string Countryoforigin { get; set; }
        [Column("COLLECTION")]
        [StringLength(25)]
        public string Collection { get; set; }
        [Column("THEME")]
        [StringLength(25)]
        public string Theme { get; set; }
        [Column("SEASON")]
        [StringLength(25)]
        public string Season { get; set; }
        [Column("STYLE")]
        [StringLength(25)]
        public string Style { get; set; }
        [Column("COLOR")]
        [StringLength(25)]
        public string Color { get; set; }
        [Column("SKUSIZE")]
        [StringLength(25)]
        public string Skusize { get; set; }
        [Column("CAMPAIGNSTART")]
        [StringLength(25)]
        public string Campaignstart { get; set; }
        [Column("CAMPAIGNEND")]
        [StringLength(25)]
        public string Campaignend { get; set; }
        [Required]
        [Column("ALLOWMULTILOTLPN")]
        [StringLength(1)]
        public string Allowmultilotlpn { get; set; }
        [Column("RECEIPTUNITLABELNAME")]
        [StringLength(20)]
        public string Receiptunitlabelname { get; set; }
        [Column("RECEIPTUNITLABELUOM")]
        [StringLength(10)]
        public string Receiptunitlabeluom { get; set; }
        [Required]
        [Column("QCFIRSTCOMPL")]
        [StringLength(1)]
        public string Qcfirstcompl { get; set; }
        [Column("NEWALLOCATIONSTRATEGY")]
        [StringLength(10)]
        public string Newallocationstrategy { get; set; }
        [Column("SLOTGROUP")]
        [StringLength(15)]
        public string Slotgroup { get; set; }
        [Required]
        [Column("PICKCONTPLACEMENT")]
        [StringLength(10)]
        public string Pickcontplacement { get; set; }
        [Required]
        [Column("FORCEUOMREPLENQTY")]
        [StringLength(1)]
        public string Forceuomreplenqty { get; set; }
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

        [InverseProperty(nameof(Orderdetail.S))]
        public virtual ICollection<Orderdetail> Orderdetails { get; set; }
    }
}
