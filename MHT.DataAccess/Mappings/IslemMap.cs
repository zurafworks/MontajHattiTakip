using MHT.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHT.DataAccess.Mappings
{
    public class IslemMap : IEntityTypeConfiguration<Islem>
    {
        public void Configure(EntityTypeBuilder<Islem> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}
