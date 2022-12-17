using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace iStock.Models
{
    public class Warehouse
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Location { get; set; }

        public string Capacity { get; set; }
    }
}
