using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_01_Box
{
    public class Box
    {
        private const int BoxMinPropertyValue = 0;
        private const string ZeroOrNegativeArgumentException = "{0} cannot be zero or negative.";//{0} is a place holder later 
        // is being replaced using String.Format(ZeroOrNegativeArgumentException, here we are stating the value of the place holder)
        private double length;
        private double width;
        private double height;


        public Box(double length, double width, double heigth)
        {
            
            this.Length = length;
            this.Width = width;
            this.Height = heigth;
        }

        public double Length 
        {
            get 
            { 
                return this.length;
            } 
            private set 
            {
                if (value <= BoxMinPropertyValue)
                {
                    throw new ArgumentException(String.Format(ZeroOrNegativeArgumentException,nameof(this.Length)));
                }
                else 
                {
                    this.length = value; 
                }
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= BoxMinPropertyValue)
                {
                    throw new ArgumentException(String.Format(ZeroOrNegativeArgumentException, nameof(this.Width)));
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= BoxMinPropertyValue)
                {
                    throw new ArgumentException(String.Format(ZeroOrNegativeArgumentException, nameof(this.Height)));
                }
                else
                {
                    this.height = value;
                }
            }
        }
        public double SurfaceArea() => (2 * Length*Width) + (2 * Width*Height) + (2 * Height*Length); 
  
        public double LateralSurfaceArea() => 2 * Height * (Length + Width);

        public double Volume() => Height * Length * Width;


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Surface Area - {this.SurfaceArea():f2}")
                  .AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}")
                  .AppendLine($"Volume - {this.Volume():f2}");

            return output.ToString().TrimEnd();


        }


    }
}
//Ако имаме рефертни типове данни не