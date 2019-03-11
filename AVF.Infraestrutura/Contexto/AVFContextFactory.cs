using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace AVF.Infraestrutura.Contexto
{
    public class AVFContextFactory : IDesignTimeDbContextFactory<AVFDataContext>
    {
        public AVFDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AVFDataContext>();
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-ORKOL2U\SQLEXPRESS;Database=EVF;Trusted_Connection=True;");
            return new AVFDataContext(optionsBuilder.Options);
        }
    }
}
