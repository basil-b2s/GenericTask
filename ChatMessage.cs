﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask
{
    public class ChatMessage
    {
        public int MessageId { get; set; }
        public string? Content { get; set; }
        public DateTime TimeStamp { get; set; }
        public int SourceId { get; set; }
    }
}
