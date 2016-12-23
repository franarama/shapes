/****    
*
* Name: Francesca Ramunno
* April 1st 2016
*
* Program Purpose: This program instantiates 2 objects of each 4 types of shapes.
* Each having different dimensions. The shape names appear in a listbox and allow
* the user to click on the shape name and view the corresponding perimeter, area, 
* and dimensions of the object.
****/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar5
{
    public partial class Form1 : Form
    {
        Circle circle1 = new Circle("Circle 1", 50);
        Circle circle2 = new Circle("Circle 2", 24);
        Rectangle rectangle1 = new Rectangle("Rectangle 1", 10, 5);
        Rectangle rectangle2 = new Rectangle("Rectangle 2", 20, 15);
        Square square1 = new Square("Square 1", 4);
        Square square2 = new Square("Square 2", 6);
        House house1 = new House("House 1", 22, 10, 4);
        House house2 = new House("House 2", 15, 6, 5);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            shape[] arr = { circle1, circle2, rectangle1, rectangle2, square1, square2, house1, house2 };

            for (int i = 0; i < 8; i++)
            {
                shapeListBox.Items.Add(arr[i]._name);
            }


        }

        private void shapeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (shapeListBox.SelectedIndex != -1)
            {
                string curItem = shapeListBox.SelectedItem.ToString();

                if (curItem == circle1._name)
                {
                    perimeterLabel.Text = circle1.Perimeter().ToString("#.##") + "cm";
                    areaLabel.Text = circle1.Area().ToString("#.##") + "cm";
                    dimensionsLabel.Text = circle1.dimensions();
                }

                if (curItem.Equals(circle2._name))
                {
                    perimeterLabel.Text = circle2.Perimeter().ToString("#.##") + "cm";
                    areaLabel.Text = circle2.Area().ToString("#.##") + "cm";
                    dimensionsLabel.Text = circle2.dimensions();
                }

                if (curItem.Equals(rectangle1._name))
                {
                    perimeterLabel.Text = rectangle1.Perimeter().ToString("#.##") + "cm";
                    areaLabel.Text = rectangle1.Area().ToString("#.##") + "cm";
                    dimensionsLabel.Text = rectangle1.dimensions();
                }

                if (curItem.Equals(rectangle2._name))
                {
                    perimeterLabel.Text = rectangle2.Perimeter().ToString("#.##") + "cm";
                    areaLabel.Text = rectangle2.Area().ToString("#.##") + "cm";
                    dimensionsLabel.Text = rectangle2.dimensions();
                }

                if (curItem.Equals(square1._name))
                {
                    perimeterLabel.Text = square1.Perimeter().ToString("#.##") + "cm";
                    areaLabel.Text = square1.Area().ToString("#.##") + "cm";
                    dimensionsLabel.Text = square1.dimensions();
                }

                if (curItem.Equals(square2._name))
                {
                    perimeterLabel.Text = square2.Perimeter().ToString("#.##") + "cm";
                    areaLabel.Text = square2.Area().ToString("#.##") + "cm";
                    dimensionsLabel.Text = square2.dimensions();
                }

                if (curItem.Equals(house1._name))
                {
                    perimeterLabel.Text = house1.Perimeter().ToString("#.##") + "cm";
                    areaLabel.Text = house1.Area().ToString("#.##") + "cm";
                    dimensionsLabel.Text = house1.dimensions();
                }

                if (curItem.Equals(house2._name))
                {
                    perimeterLabel.Text = house2.Perimeter().ToString("#.##") + "cm";
                    areaLabel.Text = house2.Area().ToString("#.##") + "cm";
                    dimensionsLabel.Text = house2.dimensions();
                }
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            shapeListBox.SelectedIndex = -1;
            perimeterLabel.Text = "";
            dimensionsLabel.Text = "";
            areaLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

/****    
*
* Name: Francesca Ramunno
* April 1st 2016
*
* Program Purpose: This program contains an abstract shape class and 4 subclasses that inherit 
* the abstract properties and methods of the superclass. Each subclass implements the methods in 
* their own way. The purpose is to calculate the perimeter, area, and dimensions for different
* shapes.
*
****/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar5
{
    public abstract class shape
    {
        public string _name
        {
            get;
            set;
        }
        public static double _length;

        public shape(string name, double length)
        {
            _name = name;
            _length = length;
        }


        public abstract double Perimeter();
        public abstract double Area();
        public abstract string dimensions();
    }

    public class Circle : shape
    {
        protected double radius;

        public Circle(string name, double length)
            :base(name, length)
        {
            radius = length;

        }

        public override double Area()
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        public override string dimensions()
        {
            return("Radius: " + radius.ToString() + "cm");
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Square : shape
    {
        protected double side;

        public Square(string name, double length)
            :base(name, length)
        {
            side = length;
        }


        public override double Area()
        {

            return Math.Pow(side, 2);
        }

        public override string dimensions()
        {
            return ("Side length: " + side.ToString() + "cm");
        }

        public override double Perimeter()
        {
            return 4 * side;
        }
    }

    public class Rectangle : shape
    {
        protected double width;
        protected double rectLength;

        public Rectangle(string name, double length, double newWidth)
            :base(name, length)
        {
            width = newWidth;
            rectLength = length;
        }

        public override double Area()
        {
            return rectLength * width;
        }

        public override string dimensions()
        {
            return("Length: " + rectLength.ToString() + "cm, Width: " + width.ToString() + "cm");
        }

        public override double Perimeter()
        {
            return (2 * rectLength) + (2 * width);
        }
    }

    public class House : shape
    {
        protected double radius;
        protected double width;
        protected double houseLength;

        public House(string name, double length, double newRadius, double newWidth)
            :base(name, length)
        {
            radius = newRadius;
            width = newWidth;
            houseLength = length;
        }

        public override double Area()
        {
            double semiCircleArea = (Math.PI * Math.Pow(radius, 2)) / 2;
            double rectangleArea = houseLength * width;
            return semiCircleArea + rectangleArea;
        }

        public override string dimensions()
        {
           return("Radius: " + radius.ToString() + "cm, Width: " + width.ToString() + "cm, Length: " + houseLength.ToString() + "cm");
        }

        public override double Perimeter()
        {
            double semiCirclePerimeter = (2 * Math.PI * radius) / 2;
            double remainingPerimeter = (2 * width) + houseLength;
            return semiCirclePerimeter + remainingPerimeter;
        }
    }

}
