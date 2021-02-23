using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        [Key]
        public int UserId { get; set; } // nasıl ilişkilendirecegimizi sor. (toDo-1-)
        public string CompanyName { get; set; }
        
        
    }
}
