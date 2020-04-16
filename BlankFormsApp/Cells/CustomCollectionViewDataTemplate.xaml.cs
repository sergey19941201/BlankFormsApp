using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankFormsApp.Cells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomCollectionViewDataTemplate : Frame
    {
        public CustomCollectionViewDataTemplate()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(CustomCollectionViewDataTemplate));

        public string Title
        {
            get
            {
                var display = (string) GetValue(TitleProperty);
                return !string.IsNullOrWhiteSpace(display) ? display.ToUpper() : display;
            }
            set { SetValue(TitleProperty, value.ToUpper()); }
        }

        public static readonly BindableProperty ImagePathProperty =
            BindableProperty.Create(nameof(ImagePath), typeof(string), typeof(CustomCollectionViewDataTemplate));

        public string ImagePath
        {
            get { return (string) GetValue(ImagePathProperty); }
            set { SetValue(ImagePathProperty, value); }
        }
    }
}