using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KennelCare.Database.Models
{
    public class Pet
    {
        [Key]
        public long PetId{ get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }  //the question mark after the type is a new c# feature, you must say a type is nullable explicitly.
                                               //initally C# allowed ?s to be for primitives to make the nullable. Refs can no longer be nullable by default.
        public DateTime BirthDate { get; set; }

    }
}
