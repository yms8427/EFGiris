using BilgeAdam.Data.EF.Models;
using System.Windows.Forms;

namespace BilgeAdam.Data.EF
{
    public static class Extensions
    {
        public static T GetBoundValue<T>(this ComboBox comboBox)
        {
            return (comboBox.SelectedItem as ComboBoxItem<T>).Value;
        }
    }
}
