﻿using QLBH.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLBH.Data.Entities
{
    public class Promotion
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public bool ApplyForAll { set; get; }
        public int? DiscountPecent { set; get; }
        public decimal? DiscountAmount { set; get; }
        public string ProductIds { set; get; }
        public string ProductCategoryId { set; get; }
        public Status Status { get; set; }
       
    }
}