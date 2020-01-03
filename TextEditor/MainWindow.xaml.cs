using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;


namespace TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string activeFile = null;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        //Events
        private void NewFile_Click(object sender, RoutedEventArgs e)
        {
            NewFile();
            SaveBtn.IsEnabled = true;
            SaveAsBtn.IsEnabled = true;
        }
        private void ExitProgram_Click(object sender, RoutedEventArgs e)
        {
            if (AskForSave(activeFile))
                Application.Current.MainWindow.Close();
        }
        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFile(activeFile);
        }
        private void SaveFileAs_Click(object sender, RoutedEventArgs e)
        {
            SaveAs();
        }
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            if (OpenFile())
            {
                SaveBtn.IsEnabled = true;
                SaveAsBtn.IsEnabled = true;
                textBox.IsEnabled = true;
            }
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Simple Text Editor v1.0 by Cezary Kania");
        }
        private void DarkMode_Click(object sender, RoutedEventArgs e)
        {
            if (DarkModeBtn.IsChecked)
                LoadDarkMode();
            else
                LoadClassicMode();

        }
        private void TextWrapping_Click(object sender, RoutedEventArgs e)
        {
            if(TextWrappingBtn.IsChecked)
                textBox.TextWrapping = TextWrapping.Wrap;
            else
                textBox.TextWrapping = TextWrapping.NoWrap;
        }
        private void Align_TextBox(object sender, SizeChangedEventArgs e)
        {
            textBox.Height = this.Height - 18;
        }
        private void FontSettings_Click(object sender, RoutedEventArgs e)
        {
            FontSettings fontSettingsWindow = FontSettings.GetFSettingsWindow(this);
            if (!fontSettingsWindow.IsLoaded)
            {
                fontSettingsWindow.Show();
            }
            else
            {
                fontSettingsWindow.Activate();
            }
            
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FontSettings fontSettingsWindow = FontSettings.GetFSettingsWindow(this);
            fontSettingsWindow.Close();
        }
        //Logic
        private void LoadDarkMode()
        {
            textBox.Background = Brushes.Black;
            textBox.Foreground = Brushes.Yellow;
        }
        private void LoadClassicMode()
        {
            textBox.Background = Brushes.White;
            textBox.Foreground = Brushes.Black;
        }
        private void NewFile()
        {
            if (!AskForSave(activeFile))
               return;
            this.Title = "Simple Text Editor - New file";
            textBox.Text = "";
            textBox.IsEnabled = true;
            activeFile = System.IO.Directory.GetCurrentDirectory() + "/New_File.txt";
        }
        private bool AskForSave(string fileName)
        {
            if (activeFile == null)
                return true;
            if(HasTextChanged() == true)
            {
                string message = $"Do you want to save {fileName}?";
                MessageBoxResult result = MessageBox.Show(message, "Save", MessageBoxButton.YesNoCancel);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        SaveFile(fileName);
                        return true;
                    case MessageBoxResult.No:
                        return true;
                    default:
                        return false;
                }
            }
            return true;
        }
        private void SaveFile(string fileName)
        {
            using(System.IO.StreamWriter file = 
                new System.IO.StreamWriter(fileName))
            {
                string text = textBox.Text;
                file.Write(text);
            }
        }
        private bool OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;
                textBox.Text = File.ReadAllText(fileName);
                activeFile = fileName;
                return true;
            }
            return false;
        }
        private void SaveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                string fileName = saveFileDialog.FileName;
                SaveFile(fileName);
            }
        }
        private bool HasTextChanged()
        {
            string textFromFile = File.ReadAllText(activeFile);
            string textFromEditor = textBox.Text;
            return textFromFile != textFromEditor;
        }
    }
}
