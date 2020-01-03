using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Reflection;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
namespace TextEditor
{
    /// <summary>
    /// Interaction logic for FontSettings.xaml
    /// </summary>
    public partial class FontSettings : Window
    {
        private MainWindow mainWindow;
        private static FontSettings settingsWindow = null;
        private FontSettings(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            

            FontSizeValue.Content = mainWindow.textBox.FontSize;
            slider.Value = mainWindow.textBox.FontSize;

            FontFamilyCMB.SelectedValue = mainWindow.textBox.FontFamily;
            FontFamilyCMB.ItemsSource = Fonts.SystemFontFamilies;

            
            PropertyInfo[] colors = typeof(Brushes).GetProperties();
            string[] colorStrings = new string[colors.Length];
            for (int i = 0; i < colors.Length; i++)
            {
                string[] tmpString = colors[i].ToString().Split();
                colorStrings[i] = tmpString[tmpString.Length - 1];
            }
            BrushConverter brushConverter = new BrushConverter();
            brushConverter.ConvertToString(mainWindow.textBox.Foreground);
            FontColorCMB.ItemsSource = colorStrings;
            FontColorCMB.SelectedValue = "Black";
        }
        public static FontSettings GetFSettingsWindow(MainWindow mainWindow)
        {
            if(settingsWindow == null)
            {
                settingsWindow = new FontSettings(mainWindow);
            }
            return settingsWindow;
        }
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mainWindow.textBox.FontSize = (int)slider.Value;
            FontSizeValue.Content = (int)slider.Value;
        }

        private void FontFamilyCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FontFamily selectedfontFamily = (FontFamily)FontFamilyCMB.SelectedItem;
            mainWindow.textBox.FontFamily = selectedfontFamily;
        }
        private void FontColorCMB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Brush myBrush = (SolidColorBrush)new BrushConverter().ConvertFromString(FontColorCMB.SelectedItem.ToString());
            mainWindow.textBox.Foreground = myBrush;
        }
    }
}
