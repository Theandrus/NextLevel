namespace Presentation
{
    using System;
    using System.Windows;
    using BLL;

    /// <summary>
    /// Interaction logic for AddProjectWindow.xaml.
    /// </summary>
    public partial class AddProjectWindow : Window
    {
        public AddProjectWindow()
        {
            InitializeComponent();
        }

        private void AddProjectButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string projectName = AddProjectInput.Text;
                MainWindowLogic.AddProject(projectName);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
