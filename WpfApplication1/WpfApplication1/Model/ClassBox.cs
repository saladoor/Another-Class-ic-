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
        private string className;
        private int xPos, yPos;
        private string fields, methods;

        public ClassBox(string className, int xPos, int yPos, string fields, string methods)
        {
            this.className = className;
            this.xPos = xPos;
            this.yPos = yPos;
            this.fields = fields;
            this.methods = methods;
        }
        
        // Commit test



    }
}
