using ProjetoCG.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCG.Draw
{
    abstract class Draw
    {
        protected Normalize normalize;
        protected Color color;
        public Bitmap bitmap { get; set; }

        public Draw() {
            this.normalize = new Normalize();
            this.bitmap = new Bitmap(normalize.environment.Width, normalize.environment.Height);
        }
    }
}
