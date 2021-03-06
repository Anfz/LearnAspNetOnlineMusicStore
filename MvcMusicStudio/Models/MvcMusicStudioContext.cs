﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMusicStudio.Models
{
    public class MvcMusicStudioContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MvcMusicStudioContext() : base("name=MvcMusicStudioContext")
        {
        }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public System.Data.Entity.DbSet<MvcMusicStudio.Models.Track> Tracks { get; set; }
    }
}
