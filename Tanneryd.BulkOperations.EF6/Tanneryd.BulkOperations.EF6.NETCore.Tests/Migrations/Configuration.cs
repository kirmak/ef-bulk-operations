﻿namespace Tanneryd.BulkOperations.EF6.NETCore.Tests.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Tanneryd.BulkOperations.EF6.NETCore.Tests.Models.EF.UnitTestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations";  
        }
        
        protected override void Seed(Tanneryd.BulkOperations.EF6.NETCore.Tests.Models.EF.UnitTestContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
