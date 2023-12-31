﻿using DetectiveHelper.Model.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveHelper.Repository.DbContexts
{
    public class DetectiveDbContext : DbContext
    {
        public DetectiveDbContext(DbContextOptions<DetectiveDbContext> options)
         : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }


    }
}
