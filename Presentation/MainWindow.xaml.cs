namespace WpfApp1
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using BLL;
    using Presentation;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            var projects = MainWindowLogic.GetAllProjects();

            foreach (var project in projects)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = project.ProjectName;
                this.PageSelector.Items.Add(comboBoxItem);
            }
        }

        private void PageSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            SessionManager.ChangeProject(selectedItem.Content.ToString());

            if (selectedItem != null)
            {
                var roles = RolesPageLogic.GetRolesByProjectId(SessionManager.CurrentProject.Id);
                var rolesWithActors = RolesPageLogic.GetRolesActorsPair(roles);
                this.Main.Content = new RolesPage(rolesWithActors);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (SessionManager.CurrentProject != null)
                {
                    this.Main.Content = new DuberPage(SessionManager.CurrentProject.Id);
                    this.PageSelector.SelectedIndex = -1;
                }
                else
                {
                    this.Main.Content = new DuberPage(-1);
                    this.PageSelector.SelectedIndex = -1;
                }
            }
            catch (Exception)
            {
            }
        }

        private void RemoveProject_Click(object sender, RoutedEventArgs e)
        {
            RemoveProjectWindow removeProjectWindow = new RemoveProjectWindow();
            removeProjectWindow.Closed += AddRemoveProject_Closed;
            removeProjectWindow.ShowDialog();
        }

        private void AddProject_Click(object sender, RoutedEventArgs e)
        {
            AddProjectWindow addProjectWindow = new AddProjectWindow();
            addProjectWindow.Closed += AddRemoveProject_Closed;
            addProjectWindow.ShowDialog();
        }

        private void AddRemoveProject_Closed(object sender, EventArgs e)
        {
            try
            {
                var projects = MainWindowLogic.GetAllProjects();
                this.PageSelector.Items.Clear();
                foreach (var project in projects)
                {
                    ComboBoxItem comboBoxItem = new ComboBoxItem();
                    comboBoxItem.Content = project.ProjectName;
                    this.PageSelector.Items.Add(comboBoxItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}