using Xamarin.Forms;

namespace BlankFormsApp.Triggers
{
    public class FocusTriggerAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            if (sender.IsFocused)
                sender.FadeTo(1);
            else
                sender.FadeTo(0.5);
        }
    }
}