using System;
using System.Collections.Generic;

namespace MyBucks.Core.Model
{
    public class FormReply : ReplyBase
    {
        public List<string> Errors { get; set; } = new List<string>();
    }
}
