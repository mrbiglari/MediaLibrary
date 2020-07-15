using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediaLibrary.Models
{
    public class Media : IMedia
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public MediaType MediaType { get; set; }

        [Required]
        public int EntityId { get; set; }

    }
}
