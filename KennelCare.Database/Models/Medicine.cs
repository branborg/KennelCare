using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelCare.Database.Models
{
    public class Medicine
    {  
        [Key]
        public long MedicineId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Pet? MedicatedPet { get; set; } //the question mark after the type is a new c# feature, you must say a type is nullable explicitly
        [ForeignKey(nameof(Pet.PetId))]
        public long PetId { get; set; }
    }
}
