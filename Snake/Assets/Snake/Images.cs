﻿using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
namespace Snake
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImage("EmptySlotGrid.png");
        public readonly static ImageSource Body = LoadImage("Body.png");
        public readonly static ImageSource Head = LoadImage("Head.png");
        public readonly static ImageSource Food = LoadImage("FoodGrid.png");
        public readonly static ImageSource DeadHead = LoadImage("DeadHead.png");
        public readonly static ImageSource DeadBody = LoadImage("DeadBody.png");
        private static ImageSource LoadImage(string fileName)
        {

            return new BitmapImage(new Uri($"Assets/{fileName}", UriKind.Relative));
        }
    }
}
