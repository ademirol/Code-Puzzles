using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using deneme.Views;
using deneme.Presenters;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace deneme
{
    public partial class Form1 : Form, IShape
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string LengthText
        {
             get; set; 
        }
        public string WidthText
        {
            get; set;
        }

        public string RadiousText
        {
            get; set;
        }
        public string SideLengthText
        {
            get; set;
        }
        public string SideALengthText
        {
            get; set;
        }
        public string SideBLengthText
        {
            get; set;
        }
        public string SideCLengthText
        {
            get; set;
        }
        public string HeightText
        {
            get; set;
        }
        public string NaturalLanguageText
        {
            get
            {
                return txtEnter.Text;
            }
            set
            {
                txtEnter.Text = value;
            }
        }
        public string ShapeLabel
        {
            get
            {
                return lblShape.Text;
            }
            set
            {
                lblShape.Text = value;
            }
        }
        public Boolean RightShape
        {
            get; set;
        }

        public void DrawPoligon(Pen penPol, int numofSide, int sideLength)
        {
            var x_0 = panel1.Width / 2;
            var y_0 = panel1.Height / 2;

            var shape = new PointF[numofSide];

            var r = Convert.ToInt32(sideLength);
            this.panel1.Refresh();
            
            Graphics g = this.panel1.CreateGraphics();

            //Create numofSide points
            for (int a = 0; a < numofSide; a++)
            {
                shape[a] = new PointF(
                x_0 + r * (float)Math.Cos(a * (360/numofSide) * Math.PI / 180f),
                y_0 + r * (float)Math.Sin(a * (360 / numofSide) * Math.PI / 180f));
            }
            g.DrawPolygon(penPol, shape);
        }

        public void DrawPicture()
        {
            Graphics g = this.panel1.CreateGraphics();
            switch (this.ShapeLabel)
            {
                case "0": // Isosceles Triangle
                    {
                        this.panel1.Refresh();
                        Pen pen0 = new Pen(Color.DarkRed); // define the pen and the color
                        g.DrawLine(pen0, 10 , 10 +Convert.ToInt32(WidthText), 10 + Convert.ToInt32(HeightText)/2, 10);
                        g.DrawLine(pen0, 10 + Convert.ToInt32(HeightText) / 2, 10, 10 + Convert.ToInt32(HeightText), 10 + Convert.ToInt32(WidthText));
                        g.DrawLine(pen0, 10, 10 + Convert.ToInt32(WidthText), 10 + Convert.ToInt32(HeightText), 10 + Convert.ToInt32(WidthText));
                        break;
                    }
                case "1": // Square
                    {
                        this.panel1.Refresh();
                        Pen pen1 = new Pen(Color.DarkRed); // define the pen and the color
                        g.DrawRectangle(pen1, 10, 10, Convert.ToInt32(SideLengthText), Convert.ToInt32(SideLengthText));
                        break;

                        // Drawpoligon method can also be used here
                        /*Pen pen1 = new Pen(Color.Crimson);
                        DrawPoligon(pen1, 4, Convert.ToInt32(SideLengthText));
                        break;*/
                    }
                case "2": // Scalene Triangle
                    {
                        // My algorithm -- find the height of the triagle from the area of the triangle
                        // after that, find the intersection point and finally find the coordinates
                        this.panel1.Refresh(); 
                        double area;
                        double s = (Convert.ToInt32(SideALengthText) + Convert.ToInt32(SideBLengthText) + Convert.ToInt32(SideCLengthText)) / 2;
                        area = Math.Sqrt(s * (s - Convert.ToInt32(SideALengthText)) * (s - Convert.ToInt32(SideBLengthText)) * (s - Convert.ToInt32(SideCLengthText)));
                        double height = (2 * area) / Convert.ToInt32(SideALengthText);
                        double xBWeight = Math.Sqrt((Convert.ToInt32(SideBLengthText) * Convert.ToInt32(SideBLengthText) - ((Convert.ToInt32(height) * Convert.ToInt32(height)))));
                        Pen pen2 = new Pen(Color.DarkRed); // define the pen and the color
                        if (Convert.ToInt32(SideCLengthText)* Convert.ToInt32(SideCLengthText)<(Convert.ToInt32(SideBLengthText)* Convert.ToInt32(SideBLengthText)+Convert.ToInt32(SideALengthText)*Convert.ToInt32(SideALengthText)))
                        {
                            g.DrawLine(pen2, 10, 10 + Convert.ToInt32(height), 10 + Convert.ToInt32(SideALengthText), 10 + Convert.ToInt32(height));
                            g.DrawLine(pen2, 10, 10 + Convert.ToInt32(height), 10 + Convert.ToInt32(xBWeight), 10);
                            g.DrawLine(pen2, 10 + Convert.ToInt32(xBWeight), 10, 10 + Convert.ToInt32(SideALengthText), 10 + Convert.ToInt32(height));
                        }
                        else
                        {
                            g.DrawLine(pen2, 10 + Convert.ToInt32(xBWeight), 10 + Convert.ToInt32(height), 10  +Convert.ToInt32(xBWeight) + Convert.ToInt32(SideALengthText), 10 + Convert.ToInt32(height));
                            g.DrawLine(pen2, 10 + Convert.ToInt32(xBWeight), 10 + Convert.ToInt32(height), 10 , 10);
                            g.DrawLine(pen2, 10 , 10, 10 + Convert.ToInt32(xBWeight) + Convert.ToInt32(SideALengthText), 10 + Convert.ToInt32(height));
                        }
                        break;
                    }
                case "3": // Parallelogram

                    this.panel1.Refresh();
                    Double widthY = Convert.ToInt32(HeightText) * ((float)Math.Sin(60 *Math.PI / 180f));
                    Double widthX = Convert.ToInt32(HeightText) * ((float)Math.Cos(60* Math.PI / 180f));
                    Pen pen3 = new Pen(Color.DarkRed); // define the pen and the color
                    g.DrawLine(pen3, 10, 10 + Convert.ToInt32(widthY), 10 + Convert.ToInt32(WidthText), 10 + Convert.ToInt32(widthY));
                    g.DrawLine(pen3, 10 + Convert.ToInt32(widthX), 10 , 10 + Convert.ToInt32(WidthText) + Convert.ToInt32(widthX), 10 );
                    g.DrawLine(pen3, 10, 10 + Convert.ToInt32(widthY), 10 + Convert.ToInt32(widthX), 10);
                    g.DrawLine(pen3, 10 + Convert.ToInt32(WidthText), 10 + Convert.ToInt32(widthY), 10 + Convert.ToInt32(WidthText) + Convert.ToInt32(widthX), 10);
                    break;
                case "4": // Equilateral Triangle
                    this.panel1.Refresh();
                    Double width = Convert.ToInt32(SideLengthText)*(Math.Sqrt(3) / 2);
                    Pen pen4 = new Pen(Color.DarkRed); // define the pen and the color
                    g.DrawLine(pen4, 10, 10 + Convert.ToInt32(width), 10 + Convert.ToInt32(SideLengthText) / 2, 10);
                    g.DrawLine(pen4, 10 + Convert.ToInt32(SideLengthText) / 2, 10, 10 + Convert.ToInt32(SideLengthText), 10 + Convert.ToInt32(width));
                    g.DrawLine(pen4, 10, 10 + Convert.ToInt32(width), 10 + Convert.ToInt32(SideLengthText), 10 + Convert.ToInt32(width));
                    break;

                    // Drawpoligon method can also be used here
                    /*Pen pen4 = new Pen(Color.Crimson);
                    DrawPoligon(pen4, 3, Convert.ToInt32(SideLengthText));
                    break; */

                case "5": // Pentagon
                    {
                        Pen pen5 = new Pen(Color.Crimson); // define the pen and the color
                        DrawPoligon(pen5,5, Convert.ToInt32(SideLengthText));
                        break;
                    }
                case "6": // Rectangle
                    {
                        this.panel1.Refresh();
                        Pen pen6 = new Pen(Color.Black); // define the pen and the color
                        g.DrawRectangle(pen6, 10, 10, Convert.ToInt32(HeightText), Convert.ToInt32(WidthText));
                        break;
                    }
                case "7": // Hexagon
                    Pen pen7 = new Pen(Color.DarkRed); // define the pen and the color
                    DrawPoligon(pen7,6, Convert.ToInt32(SideLengthText));
                    break;
                case "8": // Heptagon
                    Pen pen8 = new Pen(Color.Ivory); // define the pen and the color
                    DrawPoligon(pen8,7, Convert.ToInt32(SideLengthText));
                    break;
                case "9": // Octagon 
                    Pen pen9 = new Pen(Color.Magenta); // define the pen and the color
                    DrawPoligon(pen9,8, Convert.ToInt32(SideLengthText));
                    break;
                case "10": // Circle
                    {
                        this.panel1.Refresh();
                        Pen pen = new Pen(Color.Blue); // define the pen and the color
                        g.DrawEllipse(pen,  10, 10, Convert.ToInt32(RadiousText), Convert.ToInt32(RadiousText));
                        break;
                    }
                case "11": // Oval
                    {
                        this.panel1.Refresh();
                        Pen pen11 = new Pen(Color.BurlyWood); // define the pen and the color
                        g.DrawEllipse(pen11, 10, 10, Convert.ToInt32(WidthText), Convert.ToInt32(HeightText));
                        break;
                    }
            }
        }
        private void btsubmit_Click(object sender, EventArgs e)
        {
            ShapePresenter presenter = new ShapePresenter(this);
            // Firstly parse the text and find the shape with it's measurements
            presenter.FindShape();
            if (RightShape)
            {
                DrawPicture(); // Draw the pictures on the screen
            }
            else
                MessageBox.Show("Wrong syntax, please enter right syntax","Error",MessageBoxButtons.OK);

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
