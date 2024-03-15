﻿using System;
using SplashKitSDK;
namespace ShapeDrawer
{
	public class Shape
	{

        private Color _color;
        private float _x;
        private float _y;
        private int _width;
        private int _height;
        //constructor
        public Shape()
		{
			_color = Color.RandomRGB(500);
			_x = _y = 0.0f;
			
			_width = _height = 100;
			 
		}
		//property
		public Color Color
		{
			get
			{
				return _color;
			}
			set
			{
				_color = value;
			}
		}
		public float X
		{
			get
			{
				return _x;
			}
			set
			{
				_x = value;
			}

		}
		public float Y
		{
			get
			{
				return _y;
			}
			set
			{
				_y = value;
			}
		}
		

		//draw function

		public void Draw()
		{
			SplashKit.FillRectangle(_color, _x, _y, _width, _height);
		}
		public bool IsAt(Point2D pt)
		{
			return SplashKit.PointInRectangle(pt, SplashKit.RectangleFrom(X, Y, _width, _height));
			
						
		}




	}
}

