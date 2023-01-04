﻿using ECommerceApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Domain.Entities
{
    public interface IBaseEntity 
    {
        DateTime CreateDate { get; set; }
        DateTime? DeleteDate { get; set; }
        DateTime? UpdateDate { get; set; }
        Status Status { get; set; }
        Roles Roles { get; set; }
    }
}
