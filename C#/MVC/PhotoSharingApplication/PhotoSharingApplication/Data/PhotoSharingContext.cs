using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using PhotoSharingApplication.Models;

namespace PhotoSharingApplication.Data
{
    public class PhotoSharingContext: DbContext
    {
        public PhotoSharingContext() : base("keyPhotoDB") { }

        public DbSet<Photo> Photos { get;set; }
        public DbSet<Comment> Comments { get;set; }
    }
}