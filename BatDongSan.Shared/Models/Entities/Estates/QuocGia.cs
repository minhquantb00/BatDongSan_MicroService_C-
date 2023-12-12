﻿using BatDongSan.Shared.Models.Entities.BaseEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatDongSan.Shared.Models.Entities.Estates
{
    public class QuocGia : BaseEntity
    {
        public string TenQuocGia { get; set; }
        public IEnumerable<ThanhPho> ThanhPhos { get; set; }
    }
}
