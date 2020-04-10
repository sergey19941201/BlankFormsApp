using System.Globalization;

namespace BlankFormsApp.Interfaces
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
    }
}