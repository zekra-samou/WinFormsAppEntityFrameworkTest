using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppEntityFrameworkTest.Configurations
{
    public class UserEntitytypeConfiguration : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder.Property(m => m.first_name).IsRequired();
        }

        //internal void Configure(EntityTypeBuilder<UserModel> entityTypeBuilder)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
