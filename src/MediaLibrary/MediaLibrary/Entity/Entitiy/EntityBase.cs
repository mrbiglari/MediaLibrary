using System;
using System.ComponentModel.DataAnnotations;

namespace MediaLibrary.Models
{
    public abstract class EntityBase : IEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}