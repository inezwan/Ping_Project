﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SportsPro.Models.DataLayer.SeedData
{
    internal class SeedTechnicians:IEntityTypeConfiguration<Technician>
    {

        public void Configure(EntityTypeBuilder<Technician> entity)
        {
            entity.HasData(
                     new Technician
                     {
                         TechnicianID = 11,
                         Name = "Alison Diaz",
                         Email = "alison@sportsprosoftware.com",
                         Phone = "800-555-0443"
                     },
                new Technician
                {
                    TechnicianID = 12,
                    Name = "Jason Lee",
                    Email = "jason@sportsprosoftware.com",
                    Phone = "800-555-0444"
                },
                new Technician
                {
                    TechnicianID = 13,
                    Name = "Andrew Wilson",
                    Email = "awilson@sportsprosoftware.com",
                    Phone = "800-555-0449"
                },
                new Technician
                {
                    TechnicianID = 14,
                    Name = "Gunter Wendt",
                    Email = "gunter@sportsprosoftware.com",
                    Phone = "800-555-0400"
                },
                new Technician
                {
                    TechnicianID = 15,
                    Name = "Gina Fiori",
                    Email = "gfiori@sportsprosoftware.com",
                    Phone = "800-555-0459"
                }
              );
        }
    }
}
