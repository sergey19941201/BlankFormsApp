using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BlankFormsApp.Pages
{
    public class AnimationEyeTrainingPage : ContentPage
    {
        private bool _isAnimating, _isScaling, _increasing;
        private ImageButton _imageButton;

        private double _scaleValue = 1;
        private double _scaleMaxValue = 2;
        private double _scaleMinValue = 0.1;
        private double _scaleStepValue = 0.05;
        private int _scaleDelay = 40;
        private uint _rotationStepValue = 6;
        private int _rotationDelay = 5;

        public AnimationEyeTrainingPage()
        {
            InitializeButton();

            Content = new StackLayout
            {
                Padding = new Thickness(0, 60, 0, 0),
                BackgroundColor = Color.White,
                Children = {_imageButton}
            };

            Subscribe();
        }

        private void InitializeButton()
        {
            _imageButton = new ImageButton
            {
                Source = "monkey_circle.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                WidthRequest = 100,
                HeightRequest = 100,
            };
        }

        private void Subscribe()
        {
            _imageButton.Clicked -= ImageButtonOnClicked;
            _imageButton.Clicked += ImageButtonOnClicked;
        }

        private void ImageButtonOnClicked(object sender, EventArgs e)
        {
            _isAnimating = !_isAnimating;

            var rotationTask = new Task(async () =>
            {
                while (_isAnimating)
                {
                    _imageButton.Rotation += _rotationStepValue;
                    await Task.Delay(_rotationDelay);
                }
            });

            rotationTask.Start();

            var scaleTask = new Task(async () =>
            {
                while (_isAnimating)
                {
                    PerformScale();
                    await Task.Delay(_scaleDelay);
                }
            });

            scaleTask.Start();
        }

        private void PerformScale()
        {
            if (_isScaling)
            {
                return;
            }

            if (_scaleValue <= _scaleMaxValue && _increasing)
            {
                _scaleValue += _scaleStepValue;
            }
            else
            {
                _increasing = false;
                _scaleValue -= _scaleStepValue;

                if (_scaleValue <= _scaleMinValue)
                {
                    _increasing = true;
                }
            }

            _isScaling = true;
            _imageButton.Scale = _scaleValue;
            _isScaling = false;
        }
    }
}