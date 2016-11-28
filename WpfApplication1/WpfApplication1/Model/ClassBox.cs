using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Model
{
    using System;

    public class ClassBox
    {
        public string className { get; set; }
        public int xPos { get; set; }
        public int yPos { get; set; }
        public string fields { get; set; }
        public string methods { get; set; }

        public ClassBox(string className, int xPos, int yPos, string fields, string methods)
        {
            this.className = className;
            this.xPos = xPos;
            this.yPos = yPos;
            this.fields = fields;
            this.methods = methods;
        }
        
     



    }
}
