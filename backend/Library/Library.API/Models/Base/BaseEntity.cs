using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.API.Models.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public Int32 Id { get; set; }
    }
}
