﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidlyByYo.Models
{
    public class MembershipType
    {
        public byte Id { set; get; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}