using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    class CirclePic : PictureBox { 


    protected override void OnPaint(PaintEventArgs pe)
    {
        GraphicsPath gr = new GraphicsPath();
        gr.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        this.Region = new System.Drawing.Region(gr);
        base.OnPaint(pe);
    }
}
}
