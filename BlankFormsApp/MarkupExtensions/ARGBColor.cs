﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.MarkupExtensions
{
    public class ARGBColor : IMarkupExtension
    {
        public int Alpha { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromRgba(Red, Green, Blue, Alpha);
        }
    }
}
