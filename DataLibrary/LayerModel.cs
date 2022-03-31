using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class LayerModel
    {
        public string   LayerName { get; set; }
        public string   LayerDescription { get; set; }
        public string   LayerColor { get; set; }
        public string   LayerLinetype { get; set; }

    }

    public class LayerDisciplineModel
    {
        public string DisciplineName { get; set; }
        public string DisciplineAssoc { get; set; }

    }

    public class LayerGroupModel 
    {
        public string GroupName { get; set; }
        public string GroupAssoc { get; set; }

    }
}
