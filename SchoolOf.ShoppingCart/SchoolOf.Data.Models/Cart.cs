﻿using SchoolOf.Common.Enums;
using SchoolOf.Data.Abstraction;

namespace SchoolOf.Data.Models
{
    public class Cart : BaseEntityModel
    {
        public CartStatus Status { get; set; }
    }
}