using System;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.MarkupExtensions
{
    public class PlayerStringEnding : IMarkupExtension
    {
        public int Count { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return $"{Count} players";
        }
    }
}
