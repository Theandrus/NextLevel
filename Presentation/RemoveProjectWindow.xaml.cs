namespace Presentation
{
    using System;
    using System.Windows;
    using BLL;

    /// <summary>
    /// Interaction logic for RemoveProjectWindow.xaml.
    /// </summary>
    public partial class RemoveProjectWindow : Window
    {
        public RemoveProjectWindow()
        {
            this.InitializeComponent();
        }

        private void RemoveProjectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string projectName = this.RemoveProjectInput.Text;
                MainWindowLogic.RemoveProject(projectName);
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog("Error: Project does not exist", LogLevel.Error);
                MessageBox.Show($"Error: Project does not exist", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
