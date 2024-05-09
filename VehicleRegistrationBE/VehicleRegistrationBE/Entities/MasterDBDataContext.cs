﻿using Microsoft.EntityFrameworkCore;

namespace VehicleRegistrationBE.Entities
{
    public class MasterDBDataContext : DbContext
    {
        public MasterDBDataContext(DbContextOptions<MasterDBDataContext> options) : base(options)
        {
        }

        public virtual DbSet<MsUserEntity> MasterUserEntities { get; set; }
    }
}