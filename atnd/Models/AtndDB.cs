using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace atnd.Models
{
    public class AtndDB : DbContext
    {
        public DbSet<Attendee> Attendees { get; set; }
    }
}