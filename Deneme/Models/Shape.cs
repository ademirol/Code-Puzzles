using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace deneme.Models
{ 
    public enum shapeTypes
{
    Isosceles_Triangle = 0, 	
    Square = 1,
    Scalene_Triangle = 2, 	
    Parallelogram =3,
    Equilateral_Triangle =4, 	
    Pentagon  = 5,
    Rectangle = 6,
    Hexagon =7,
    Heptagon = 8 ,
    Octagon = 9,
    Circle = 10,
    Oval = 11

}

    
    class Shape
    {
        public String[] ShapeNames = { "isosceles Triangle", "Square", "Scalene Triangle", "Parallelogram", "Equilateral Triangle",
        "Pentagon","Rectangle", "Hexagon", "Heptagon", "Octagon","Circle","Oval"};
        public shapeTypes Shape_Type { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }
        public double SideLength { get; set; }
        public double SideALength { get; set; }
        public double SideBLength { get; set; }
        public double SideCLength { get; set; }

        public Boolean RightSyntax;
        public int FindSize(string strMeasurement, string strNaturalLang)
        {
            int i;
            string strNaturalLangLower = strNaturalLang.ToLower();
            string resultString;

            i = strNaturalLangLower.IndexOf(strMeasurement);
            if (i > 0)
            {
                resultString = Regex.Match(strNaturalLang.Substring(i), @"\d+").Value;
                return Convert.ToInt32(resultString);
            }
            else
            {
                return 0;
            }

            
        }
        public int FindShape(string strNaturalLang)
        {
            int i;
            bool bFound = false;
            string strNaturalLangLower = strNaturalLang.ToLower();
            string sShape = "Not Found";
            int intOrder = 0; 

            RightSyntax = false; // checks the natural language syntax
            try
            {
                for (i = 0; i < ShapeNames.Length; i++)
                {
                    if (strNaturalLangLower.IndexOf(ShapeNames[i].ToLower()) > 0) // searchs the shape name in the text
                    {

                        sShape = ShapeNames[i];
                        intOrder = i;
                        bFound = true;
                        break;
                    }
                }
                
            }
            catch (ArgumentException e)
            {
                return -1;
            }

            if (bFound)
            {
                switch (intOrder)
                {
                    case (int)shapeTypes.Isosceles_Triangle:
                        Height = FindSize("height",strNaturalLang);
                        Width = FindSize("width", strNaturalLang);
                        if (Height > 0 && Width > 0) RightSyntax = true;
                        break;
                    case (int)shapeTypes.Square:
                        SideLength = FindSize("side length", strNaturalLang);
                        if (SideLength > 0) RightSyntax = true;
                        break;
                    case (int)shapeTypes.Scalene_Triangle:
                        SideALength = FindSize("side a", strNaturalLang);
                        SideBLength = FindSize("side b", strNaturalLang);
                        SideCLength = FindSize("side c", strNaturalLang);
                        if (SideALength > 0 && SideBLength > 0 && SideCLength > 0) RightSyntax = true;
                        break;
                    case (int)shapeTypes.Parallelogram:
                        Width = FindSize("width", strNaturalLang);
                        Height = FindSize("height", strNaturalLang);
                        if (Height > 0 && Width > 0) RightSyntax = true;
                        break;
                    case (int)shapeTypes.Equilateral_Triangle:
                        SideLength = FindSize("side length", strNaturalLang);
                        if (SideLength > 0) RightSyntax = true;
                        break;
                    case (int)shapeTypes.Pentagon:
                        SideLength = FindSize("side length", strNaturalLang);
                        if (SideLength > 0) RightSyntax = true;
                        break;
                    case (int)shapeTypes.Rectangle:
                        Width = FindSize("width", strNaturalLang);
                        Height = FindSize("height", strNaturalLang);
                        if (Height > 0 && Width > 0) RightSyntax = true;
                        break;
                    case (int)shapeTypes.Hexagon:
                        SideLength = FindSize("side length", strNaturalLang);
                        if (SideLength > 0) RightSyntax = true;
                        break;
                    case (int)shapeTypes.Heptagon:
                        SideLength = FindSize("side length", strNaturalLang);
                        if (SideLength > 0) RightSyntax = true;
                        break;
                    case (int)shapeTypes.Octagon:
                        SideLength = FindSize("side length", strNaturalLang);
                        if (SideLength > 0) RightSyntax = true;
                        break;
                    case (int)shapeTypes.Circle:
                        Radius = FindSize("radius", strNaturalLang);
                        if (Radius > 0) RightSyntax = true;
                        break;
                    case (int)shapeTypes.Oval:
                        Width = FindSize("width", strNaturalLang);
                        Height = FindSize("height", strNaturalLang);
                        if (Height > 0 && Width > 0) RightSyntax = true;
                        break;
                }
            }
            return intOrder;
        }
    }
}
