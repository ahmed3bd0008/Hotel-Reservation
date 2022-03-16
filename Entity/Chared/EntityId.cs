using System;
using System.ComponentModel.DataAnnotations;

namespace Entity.Shared
{
    public class EntityId
    {
        [Key]
        public int Id { get; set; }
    }
}