using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MvcProject.Models;

#nullable disable

namespace MvcProject.Data
{
    public partial class TestDBContext : DbContext
    {
        public TestDBContext()
        {
        }

        public TestDBContext(DbContextOptions<TestDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ncounter> Ncounters { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderdetail> Orderdetails { get; set; }
        public virtual DbSet<Sku> Skus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.; Database=TestDB; UID=SA; PWD=Pass@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Ncounter>(entity =>
            {
                entity.HasKey(e => e.Keyname)
                    .HasName("PK__NCOUNTER__BDAB36D5BB4B3367");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Addwho).HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Editdate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Editwho).HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Serialkey).ValueGeneratedOnAdd();

                entity.Property(e => e.Whseid).HasDefaultValueSql("(user_name())");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Orderkey)
                    .HasName("PK__ORDERS__61857B4B087E3E23");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Addwho).HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Allocatedonerp).HasDefaultValueSql("('0')");

                entity.Property(e => e.AllowOverPick).HasDefaultValueSql("((0))");

                entity.Property(e => e.Apportion).HasDefaultValueSql("('0')");

                entity.Property(e => e.Batchflag).HasDefaultValueSql("('0')");

                entity.Property(e => e.Billtokey).HasDefaultValueSql("('')");

                entity.Property(e => e.Bolprinted).HasDefaultValueSql("('0')");

                entity.Property(e => e.CarrierCode).HasDefaultValueSql("(' ')");

                entity.Property(e => e.CarrierName).HasDefaultValueSql("(' ')");

                entity.Property(e => e.Carrierroutestatus).HasDefaultValueSql("('NEW')");

                entity.Property(e => e.Consigneekey).HasDefaultValueSql("('')");

                entity.Property(e => e.DcId).HasDefaultValueSql("('')");

                entity.Property(e => e.Door).HasDefaultValueSql("('')");

                entity.Property(e => e.Editdate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Editwho).HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Enablepacking).HasDefaultValueSql("('0')");

                entity.Property(e => e.Externalloadid).HasDefaultValueSql("('')");

                entity.Property(e => e.Externorderkey).HasDefaultValueSql("('')");

                entity.Property(e => e.ForteFlag).HasDefaultValueSql("('I')");

                entity.Property(e => e.Hostprocessrequired).HasDefaultValueSql("('0')");

                entity.Property(e => e.Intermodalvehicle).HasDefaultValueSql("('')");

                entity.Property(e => e.ItemNumber).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ohtype).HasDefaultValueSql("('1')");

                entity.Property(e => e.Openqty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Orderdate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Ordergroup).HasDefaultValueSql("('')");

                entity.Property(e => e.Priority).HasDefaultValueSql("('5')");

                entity.Property(e => e.Requireorderclose).HasDefaultValueSql("('0')");

                entity.Property(e => e.Rfidflag).HasDefaultValueSql("('0')");

                entity.Property(e => e.Route).HasDefaultValueSql("('')");

                entity.Property(e => e.Serialkey).ValueGeneratedOnAdd();

                entity.Property(e => e.Shiptogether).HasDefaultValueSql("('N')");

                entity.Property(e => e.SplitOrders).HasDefaultValueSql("('0')");

                entity.Property(e => e.Splitshipmentindicator).HasDefaultValueSql("('0')");

                entity.Property(e => e.Stage).HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasDefaultValueSql("('02')");

                entity.Property(e => e.Storerkey).HasDefaultValueSql("('')");

                entity.Property(e => e.Suspendedindicator).HasDefaultValueSql("('0')");

                entity.Property(e => e.Totalcube).HasDefaultValueSql("((0))");

                entity.Property(e => e.Totalgrosswgt).HasDefaultValueSql("((0))");

                entity.Property(e => e.Totalorderlines).HasDefaultValueSql("((0))");

                entity.Property(e => e.Totalqty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Type).HasDefaultValueSql("('0')");

                entity.Property(e => e.Updatesource).HasDefaultValueSql("('0')");

                entity.Property(e => e.WhseId1).HasDefaultValueSql("('')");

                entity.Property(e => e.Whseid).HasDefaultValueSql("(user_name())");
            });

            modelBuilder.Entity<Orderdetail>(entity =>
            {
                entity.HasKey(e => new { e.Orderkey, e.Orderlinenumber })
                    .HasName("PK__ORDERDET__9BB450751E1D5C79");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Addwho).HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Altsku).HasDefaultValueSql("('')");

                entity.Property(e => e.Backflushindicator).HasDefaultValueSql("('0')");

                entity.Property(e => e.Cartonbreak).HasDefaultValueSql("('')");

                entity.Property(e => e.Cartongroup).HasDefaultValueSql("('')");

                entity.Property(e => e.Cubicmeter).HasDefaultValueSql("((0))");

                entity.Property(e => e.Dapicksort).HasDefaultValueSql("('1')");

                entity.Property(e => e.Editdate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Editwho).HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Externlineno).HasDefaultValueSql("('')");

                entity.Property(e => e.Externorderkey).HasDefaultValueSql("('')");

                entity.Property(e => e.Facility).HasDefaultValueSql("('')");

                entity.Property(e => e.Fgqtyreceived).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForteFlag).HasDefaultValueSql("('I')");

                entity.Property(e => e.GenerateContainerDetail).HasDefaultValueSql("('0')");

                entity.Property(e => e.Hundredweight).HasDefaultValueSql("((0))");

                entity.Property(e => e.Id).HasDefaultValueSql("('')");

                entity.Property(e => e.Labelsprinted).HasDefaultValueSql("('0')");

                entity.Property(e => e.Lot).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable01).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable02).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable03).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable06).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable07).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable08).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable09).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable10).HasDefaultValueSql("('')");

                entity.Property(e => e.Manufacturersku).HasDefaultValueSql("('')");

                entity.Property(e => e.Minshippercent).HasDefaultValueSql("('0')");

                entity.Property(e => e.Opprequest).HasDefaultValueSql("((0))");

                entity.Property(e => e.Oqcautoadjust).HasDefaultValueSql("('0')");

                entity.Property(e => e.Oqcrequired).HasDefaultValueSql("('0')");

                entity.Property(e => e.Packkey).HasDefaultValueSql("('STD')");

                entity.Property(e => e.PalletId).HasDefaultValueSql("('')");

                entity.Property(e => e.Pickcode).HasDefaultValueSql("('')");

                entity.Property(e => e.Retailsku).HasDefaultValueSql("('')");

                entity.Property(e => e.Rotation).HasDefaultValueSql("('1')");

                entity.Property(e => e.Runinqty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Runinuom).HasDefaultValueSql("('')");

                entity.Property(e => e.Runoutqty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Runoutuom).HasDefaultValueSql("('')");

                entity.Property(e => e.Serialkey).ValueGeneratedOnAdd();

                entity.Property(e => e.Shelflife).HasDefaultValueSql("((0))");

                entity.Property(e => e.Shipgroup01).HasDefaultValueSql("('N')");

                entity.Property(e => e.Shipgroup02).HasDefaultValueSql("('N')");

                entity.Property(e => e.Shipgroup03).HasDefaultValueSql("('N')");

                entity.Property(e => e.Sku).HasDefaultValueSql("('')");

                entity.Property(e => e.Skurotation).HasDefaultValueSql("('Lot')");

                entity.Property(e => e.Status).HasDefaultValueSql("('02')");

                entity.Property(e => e.Storerkey).HasDefaultValueSql("('')");

                entity.Property(e => e.SubFlag).HasDefaultValueSql("('')");

                entity.Property(e => e.Uom).HasDefaultValueSql("('')");

                entity.Property(e => e.Updatesource).HasDefaultValueSql("('0')");

                entity.Property(e => e.Whseid).HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Workorderkey).HasDefaultValueSql("('')");

                entity.Property(e => e.Wpreleased).HasDefaultValueSql("('0')");

                entity.HasOne(d => d.OrderkeyNavigation)
                    .WithMany(p => p.Orderdetails)
                    .HasForeignKey(d => d.Orderkey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ORDERDETA__ORDER__23F3538A");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.Orderdetails)
                    .HasForeignKey(d => new { d.Sku, d.Storerkey })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ORDERDETAIL__24E777C3");
            });

            modelBuilder.Entity<Sku>(entity =>
            {
                entity.HasKey(e => new { e.Sku1, e.Storerkey })
                    .HasName("PK__SKU__D38A08E12D26EF6F");

                entity.Property(e => e.Active).HasDefaultValueSql("('1')");

                entity.Property(e => e.Adddate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Addwho).HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Allowconsolidation).HasDefaultValueSql("('0')");

                entity.Property(e => e.Allowmultilotlpn).HasDefaultValueSql("('0')");

                entity.Property(e => e.Autoassignconsloc).HasDefaultValueSql("('0')");

                entity.Property(e => e.Autoreleaselotby).HasDefaultValueSql("('01')");

                entity.Property(e => e.Autoreleaselpnby).HasDefaultValueSql("('01')");

                entity.Property(e => e.Avgcaseweight).HasDefaultValueSql("((0))");

                entity.Property(e => e.Bulkcartongroup).HasDefaultValueSql("(' ')");

                entity.Property(e => e.Cartongroup).HasDefaultValueSql("('STD')");

                entity.Property(e => e.Cartonizeft).HasDefaultValueSql("('0')");

                entity.Property(e => e.Casekey).HasDefaultValueSql("(' ')");

                entity.Property(e => e.Ccdiscrepancyrule).HasDefaultValueSql("('STD')");

                entity.Property(e => e.Class).HasDefaultValueSql("('STD')");

                entity.Property(e => e.Conveyable).HasDefaultValueSql("('N')");

                entity.Property(e => e.Countsequence).HasDefaultValueSql("((1))");

                entity.Property(e => e.Dapicksort).HasDefaultValueSql("('1')");

                entity.Property(e => e.Datecodedays).HasDefaultValueSql("((999))");

                entity.Property(e => e.Defaultrotation).HasDefaultValueSql("('1')");

                entity.Property(e => e.Eachkey).HasDefaultValueSql("(' ')");

                entity.Property(e => e.Editdate).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Editwho).HasDefaultValueSql("(user_name())");

                entity.Property(e => e.Fillqtyuom).HasDefaultValueSql("(' ')");

                entity.Property(e => e.Flowthruitem).HasDefaultValueSql("('N')");

                entity.Property(e => e.Forceuomreplenqty).HasDefaultValueSql("('0')");

                entity.Property(e => e.Groupfteach).HasDefaultValueSql("('1')");

                entity.Property(e => e.Hazmatcodeskey).HasDefaultValueSql("('')");

                entity.Property(e => e.Hourstoholdlot).HasDefaultValueSql("((0))");

                entity.Property(e => e.Hourstoholdlpn).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ibsumcwflg).HasDefaultValueSql("('0')");

                entity.Property(e => e.Icdflag).HasDefaultValueSql("('0')");

                entity.Property(e => e.Icdlabel1).HasDefaultValueSql("('')");

                entity.Property(e => e.Icdlabel2).HasDefaultValueSql("('')");

                entity.Property(e => e.Icdlabel3).HasDefaultValueSql("('')");

                entity.Property(e => e.Icwby).HasDefaultValueSql("('0')");

                entity.Property(e => e.Icwflag).HasDefaultValueSql("('0')");

                entity.Property(e => e.Ideweight).HasDefaultValueSql("('0')");

                entity.Property(e => e.Itemreference).HasDefaultValueSql("(' ')");

                entity.Property(e => e.Lotctrlatpack).HasDefaultValueSql("('0')");

                entity.Property(e => e.Lottable01label).HasDefaultValueSql("('JULIAN DT.')");

                entity.Property(e => e.Lottable02label).HasDefaultValueSql("('CUST.LOT')");

                entity.Property(e => e.Lottable03label).HasDefaultValueSql("('COLOR')");

                entity.Property(e => e.Lottable04label).HasDefaultValueSql("('MAN.DATE')");

                entity.Property(e => e.Lottable05label).HasDefaultValueSql("('EXP.DATE')");

                entity.Property(e => e.Lottable06label).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable07label).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable08label).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable09label).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable10label).HasDefaultValueSql("('')");

                entity.Property(e => e.Lottable11label).HasDefaultValueSql("('Delivery By Date')");

                entity.Property(e => e.Lottable12label).HasDefaultValueSql("('Best By Date')");

                entity.Property(e => e.Lottablevalidationkey).HasDefaultValueSql("('STD')");

                entity.Property(e => e.Lotxiddetailotherlabel1).HasDefaultValueSql("('SER#')");

                entity.Property(e => e.Lotxiddetailotherlabel2).HasDefaultValueSql("('CSID')");

                entity.Property(e => e.Lotxiddetailotherlabel3).HasDefaultValueSql("('OTHER')");

                entity.Property(e => e.Manualsetuprequired).HasDefaultValueSql("('0')");

                entity.Property(e => e.Nonstockedindicator).HasDefaultValueSql("('0')");

                entity.Property(e => e.Oacoverride).HasDefaultValueSql("('0')");

                entity.Property(e => e.Oavgcaseweight).HasDefaultValueSql("((0))");

                entity.Property(e => e.Obsumcwflg).HasDefaultValueSql("('0')");

                entity.Property(e => e.Ocdcatchqty1).HasDefaultValueSql("('ANY')");

                entity.Property(e => e.Ocdcatchqty2).HasDefaultValueSql("('ANY')");

                entity.Property(e => e.Ocdcatchqty3).HasDefaultValueSql("('ANY')");

                entity.Property(e => e.Ocdcatchwhen).HasDefaultValueSql("('PICK')");

                entity.Property(e => e.Ocdflag).HasDefaultValueSql("('0')");

                entity.Property(e => e.Ocdlabel1).HasDefaultValueSql("('')");

                entity.Property(e => e.Ocdlabel2).HasDefaultValueSql("('')");

                entity.Property(e => e.Ocdlabel3).HasDefaultValueSql("('')");

                entity.Property(e => e.Ocwby).HasDefaultValueSql("('0')");

                entity.Property(e => e.Ocwflag).HasDefaultValueSql("('0')");

                entity.Property(e => e.Odeweight).HasDefaultValueSql("('1')");

                entity.Property(e => e.Onreceiptcopypackkey).HasDefaultValueSql("('0')");

                entity.Property(e => e.Otareweight).HasDefaultValueSql("((0))");

                entity.Property(e => e.Otolerancepct).HasDefaultValueSql("((0))");

                entity.Property(e => e.Packkey).HasDefaultValueSql("('STD')");

                entity.Property(e => e.Pickcode).HasDefaultValueSql("('NSPFIFO')");

                entity.Property(e => e.Pickcontplacement).HasDefaultValueSql("('5')");

                entity.Property(e => e.Pickuom).HasDefaultValueSql("('1')");

                entity.Property(e => e.Putawayclass).HasDefaultValueSql("('0')");

                entity.Property(e => e.Putawayloc).HasDefaultValueSql("('UNKNOWN')");

                entity.Property(e => e.Putawayzone).HasDefaultValueSql("('RACK')");

                entity.Property(e => e.Putcode).HasDefaultValueSql("('NSPPASTD')");

                entity.Property(e => e.Qcfirstcompl).HasDefaultValueSql("('0')");

                entity.Property(e => e.Qcloc).HasDefaultValueSql("('QC')");

                entity.Property(e => e.Receiptholdcode).HasDefaultValueSql("('')");

                entity.Property(e => e.Receiptinspectionloc).HasDefaultValueSql("('QC')");

                entity.Property(e => e.Receiptvalidationtemplate).HasDefaultValueSql("('STD')");

                entity.Property(e => e.Returnsloc).HasDefaultValueSql("('RETURN')");

                entity.Property(e => e.Rfdefaultpack).HasDefaultValueSql("('STD')");

                entity.Property(e => e.Rfdefaultuom).HasDefaultValueSql("('EA')");

                entity.Property(e => e.Rotateby).HasDefaultValueSql("('Lot')");

                entity.Property(e => e.Roundbackflushqty).HasDefaultValueSql("('1')");

                entity.Property(e => e.Rplnsort).HasDefaultValueSql("('1')");

                entity.Property(e => e.Serialkey).ValueGeneratedOnAdd();

                entity.Property(e => e.Shelflife).HasDefaultValueSql("((0))");

                entity.Property(e => e.Shelflifecodetype).HasDefaultValueSql("('E')");

                entity.Property(e => e.Shippablecontainer).HasDefaultValueSql("('N')");

                entity.Property(e => e.Showrfcwontrans).HasDefaultValueSql("('0')");

                entity.Property(e => e.Skugroup).HasDefaultValueSql("('STD')");

                entity.Property(e => e.Skutype).HasDefaultValueSql("('0')");

                entity.Property(e => e.SnumAutoincrement).HasDefaultValueSql("((0))");

                entity.Property(e => e.SnumDelimCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.SnumEndtoend).HasDefaultValueSql("((0))");

                entity.Property(e => e.SnumIncrPos).HasDefaultValueSql("((0))");

                entity.Property(e => e.SnumPosition).HasDefaultValueSql("((1))");

                entity.Property(e => e.SnumQuantity).HasDefaultValueSql("((1))");

                entity.Property(e => e.SnumlongFixed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sourceversion).HasDefaultValueSql("('0')");

                entity.Property(e => e.Tareweight).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tariffkey).HasDefaultValueSql("('XXXXXXXXXX')");

                entity.Property(e => e.Tempforasn).HasDefaultValueSql("('N')");

                entity.Property(e => e.Tobestbydays).HasDefaultValueSql("((0))");

                entity.Property(e => e.Todeliverbydays).HasDefaultValueSql("((0))");

                entity.Property(e => e.Toexpiredays).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tolerancepct).HasDefaultValueSql("((0))");

                entity.Property(e => e.Verifylot04lot05).HasDefaultValueSql("('0')");

                entity.Property(e => e.VertStorage).HasDefaultValueSql("('0')");

                entity.Property(e => e.Voicegroupingid).HasDefaultValueSql("('0')");

                entity.Property(e => e.Whseid).HasDefaultValueSql("(user_name())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
