﻿using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
