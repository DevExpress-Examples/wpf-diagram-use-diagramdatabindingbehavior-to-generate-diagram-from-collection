using DiagramDataBindingBehavior.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramDataBindingBehavior.ViewModel
{
    
    public class ViewModel
    {
        public List<ClassData> ClassSource { get; set; }
        public List<ConnectionData> ConnectionSource { get; set; }

        public ViewModel()
        {
            ClassSource = ClassStructureGenerator.ClassList();
            ConnectionSource = ClassStructureGenerator.ConnectionList();
        }
    }
}
