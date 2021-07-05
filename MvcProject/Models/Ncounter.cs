using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MvcProject.Models
{
    [Table("NCOUNTER", Schema = "wmwhse1")]
    [Index(nameof(Serialkey), Name = "NCO_153_UNIQUE", IsUnique = true)]
    public partial class Ncounter
    {
        [Column("SERIALKEY")]
        public int Serialkey { get; set; }
        [Column("WHSEID")]
        [StringLength(30)]
        public string Whseid { get; set; }
        [Key]
        [Column("KEYNAME")]
        [StringLength(30)]
        public string Keyname { get; set; }
        [Column("KEYCOUNT")]
        public int Keycount { get; set; }
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
    }
}
