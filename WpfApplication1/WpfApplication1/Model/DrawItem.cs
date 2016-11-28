using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApplication1.Model
{
    class DrawItem
    {
        public DrawItem()
        {
            
        }
        public void drawClassBox(ClassBox box)
        {
            TextBox className = new TextBox();
            TextBox fields = new TextBox();
            TextBox methods = new TextBox();

            className.Text = box.className;
            fields.Text = box.fields;
            methods.Text = box.methods;
        }
        
    }
}
