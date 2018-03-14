using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme.Views
{
    interface IShape
    {
        string LengthText { get; set; }
        string WidthText { get; set; }
        string RadiousText { get; set; }
        string SideLengthText { get; set; }
        string SideALengthText { get; set; }
        string SideBLengthText { get; set; }
        string SideCLengthText { get; set; }
        string HeightText { get; set; }
        string NaturalLanguageText { get; set; }
        string ShapeLabel { get; set; }
        bool RightShape { get; set; }
    }
}
