using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;

namespace FileControlAvalonia.Views
{
    public partial class FileExplorerWindow : Window
    {
        public FileExplorerWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}