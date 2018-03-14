using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deneme.Models;
using deneme.Views;

namespace deneme.Presenters
{
    class ShapePresenter
    {
        IShape Shapeview;
        public ShapePresenter(IShape view)
        {
            Shapeview = view;
        }
        public void FindShape()
        {
            Shape mShape = new Shape();
            
            Shapeview.ShapeLabel = Convert.ToString( mShape.FindShape(Shapeview.NaturalLanguageText));
            Shapeview.RightShape = mShape.RightSyntax;
            Shapeview.LengthText = mShape.Length.ToString();
            Shapeview.WidthText = mShape.Width.ToString();
            Shapeview.RadiousText = mShape.Radius.ToString();
            Shapeview.SideLengthText = mShape.SideLength.ToString();
            Shapeview.SideALengthText = mShape.SideALength.ToString();
            Shapeview.SideBLengthText = mShape.SideBLength.ToString();
            Shapeview.SideCLengthText = mShape.SideCLength.ToString();
            Shapeview.HeightText = mShape.Height.ToString();
        }
    }
}
