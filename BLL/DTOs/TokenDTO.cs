﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TokenDTO
    {
        public int Id { get; set; }
        public string Tkey { get; set; }
        public System.DateTime StartingTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string Username { get; set; }
    }
}
