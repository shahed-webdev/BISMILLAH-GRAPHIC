﻿using System.Collections.Generic;


namespace BismillahGraphic.DataCore
{
    public class DataResult<T> where T : class
    {
        public int draw { get; set; }
        public long recordsTotal { get; set; }
        public long recordsFiltered { get; set; }
        public List<T> data { get; set; }
    }
}
