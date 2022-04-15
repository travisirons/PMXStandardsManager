using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class TextStyleModel
    {
        public string StyleName { get; set; }
        public string FontFile { get; set; }
        public string Annotative { get; set; }
        public string TextHeight { get; set; }
        public string WidthFactor { get; set; }
        public string ObliquingAngle { get; set; }

    }

    public class DimensionStyleModel
    { 
        public string DIMSTYLE { get; set; }
        public string DIMTXSTY { get; set; }
        public string DIMANNO { get; set; }
    }

    public class LeaderStyleModel
    { 
        public string LeaderName { get; set; }
        public string GroupId { get; set; }
    }

    public class LinetypeModel
    { 
        public string Linetype { get; set; }
        public string Description { get; set; }
    }

    public class LinetypeGroupModel
    {
        public string GroupName { get; set; }
        public string GroupAssoc { get; set; }
    }
}
