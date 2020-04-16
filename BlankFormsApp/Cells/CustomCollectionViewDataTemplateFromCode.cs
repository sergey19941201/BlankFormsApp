using Xamarin.Forms;
using System.Reflection;

namespace BlankFormsApp.Cells
{
    public class CustomCollectionViewDataTemplateFromCode : Grid
    {
        public  CustomCollectionViewDataTemplateFromCode ()
        {
            Padding = 10;
            RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
            ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

            Image image = new Image { Aspect = Aspect.AspectFill, HeightRequest = 60, WidthRequest = 60 };
            image.SetBinding(Image.SourceProperty, "ImagePath");

            var nameLabel = new Label { FontAttributes = FontAttributes.Bold };
            nameLabel.TextColor = Color.Brown;
            nameLabel.SetBinding(Label.TextProperty, "Title");

            Grid.SetRowSpan(image, 2);

            Children.Add(image);
            Children.Add(nameLabel, 1, 0);
            BackgroundColor=Color.Aqua;
        }
    }
}