﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppEntityFrameworkTest.Configurations
{
    public class BranchEntityTypeConfiguration : IEntityTypeConfiguration<BranchModel>
    {
        public void Configure(EntityTypeBuilder<BranchModel> builder)
        {

        }
    }

       
}
