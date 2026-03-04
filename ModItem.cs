using System.Windows.Media;

#nullable enable
namespace DbdModManager
{
    public class ModItem
    {
        public string Name { get; set; } = "";
        public string Path { get; set; } = "";
        public bool IsSelected { get; set; }
        public System.Windows.Media.Brush SelectionBrush => IsSelected ? (System.Windows.Media.Brush)System.Windows.Application.Current.Resources["AccentBrush"] : new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Transparent);
        public string StatusText => IsSelected ? "ACTIVE" : "DISABLED";
        public System.Windows.Media.Color StatusColor => IsSelected ? (System.Windows.Media.Color)System.Windows.Application.Current.Resources["AccentColor"] : (System.Windows.Media.Color)System.Windows.Media.ColorConverter.ConvertFromString("#444444");
        public System.Windows.Media.Brush StatusBrush => new System.Windows.Media.SolidColorBrush(StatusColor);
    }
}
