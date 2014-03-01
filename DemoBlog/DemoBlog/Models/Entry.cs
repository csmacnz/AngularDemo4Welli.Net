﻿using System.Collections.Generic;

namespace DemoBlog.Models
{
    public class Entry
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }
        public List<Comment> Comments { get; set; }
     }

    public class Comment
    {
        public string User { get; set; }
        public string Message { get; set; }
    }
}