using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;

namespace dataprocessor.Collation
{
    [DebuggerDisplay("Name: {Description}")]
    public class NameInfo
    {
        public NameInfo(NameType desc) 
        {
            Description = desc;
        }

        public NameType Description { get; }
        public WriterInfo SourceWriter { get; set; }
        public ProcessorInfo SourceProcessor { get; set; }
        public List<ProcessorInfo> Consumers { get; } = new List<ProcessorInfo>();
    }
}
