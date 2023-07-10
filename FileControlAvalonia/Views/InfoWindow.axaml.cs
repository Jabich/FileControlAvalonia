using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using FileControlAvalonia.Services;
using System;

namespace FileControlAvalonia.Views
{
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();
            Deactivated += DeactivatedWindow;
        }

        private void DeactivatedWindow(object? sender, EventArgs e)
        {
            string activeWindow = WindowsAPI.GetActiveProcessName();
            if (activeWindow != WindowsAPI.programProcessName)
            {
                var window = App.CurrentApplication.Windows;
                for (int i = 1; i < window.Count; i++)
                {
                    window[i].Close();
                }
                window[0].Hide();
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        protected override void OnOpened(EventArgs e)
        {
            base.OnOpened(e);
            Position = new PixelPoint(WindowAssistant.X_Coordinate + 100, WindowAssistant.Y_Coordinate + 120);
            CanResize = false;
        }
    }
}
