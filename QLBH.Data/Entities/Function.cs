using System;
using System.Collections.Generic;
using System.Text;

namespace QLBH.Data.Entities
{
    public class Function
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int ParentId { get; set; }
        public Boolean Status { get; set; }
        public string SortOrder { get; set; }
    }
}
