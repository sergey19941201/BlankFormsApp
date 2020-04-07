using Xamarin.Forms;

namespace BlankFormsApp.Controls
{
    // Taglabel has custom bindable property Tag 
    public class TagLabel : Label
    {
        public static readonly BindableProperty TagProperty =
            BindableProperty.Create(
                "Tag", // название обычного свойства
                typeof(string), // возвращаемый тип 
                typeof(TagLabel), // тип,  котором объявляется свойство
                "0" // значение по умолчанию
            );

        public string Tag
        {
            set { SetValue(TagProperty, value); }
            get { return (string) GetValue(TagProperty); }
        }
    }
}