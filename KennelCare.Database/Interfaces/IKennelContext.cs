using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KennelCare.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Kennel.Database.Interfaces
{
    public interface IKennelContext
    {
        DbSet<Pet>? Pets { get; init; }
        DbSet<Medicine>? Medicines { get; init; }
    }
}
