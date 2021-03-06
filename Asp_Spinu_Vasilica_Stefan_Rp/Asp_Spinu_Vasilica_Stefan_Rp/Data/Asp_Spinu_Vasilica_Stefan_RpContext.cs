﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Spinu_Vasilica_Stefan_Rp.Models;

namespace Asp_Spinu_Vasilica_Stefan_Rp.Data
{
    public class Asp_Spinu_Vasilica_Stefan_RpContext : DbContext
    {
        public Asp_Spinu_Vasilica_Stefan_RpContext (DbContextOptions<Asp_Spinu_Vasilica_Stefan_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Spinu_Vasilica_Stefan_Rp.Models.Movie> Movie { get; set; }
    }
}
