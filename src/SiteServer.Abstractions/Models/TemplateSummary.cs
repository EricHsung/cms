﻿using System;

namespace SiteServer.Abstractions
{
    public class TemplateSummary
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }
        public bool Default { get; set; }
    }
}