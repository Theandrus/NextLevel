namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using BLL;
    using DAL;
    using Presentation;

    /// <summary>
    /// Interaction logic for RolesPage.xaml.
    /// </summary>
    public partial class RolesPage : Page
    {
        List<Tuple<Role, Actor>> RolesWithActors;

        public RolesPage(List<Tuple<Role, Actor>> rolesWithActors)
        {
            this.InitializeComponent();
            this.RolesWithActors = rolesWithActors;
            this.DataContext = this;
            this.SetRolesList(RolesWithActors);
        }

        private void SetRolesList(List<Tuple<Role, Actor>> rolesWithActors)
        {
            this.RolesListView.ItemsSource = rolesWithActors;
        }

        private void RemoveRole_Click(object sender, RoutedEventArgs e)
        {
            RemoveRolePage removeRolePage = new RemoveRolePage();
            removeRolePage.Closed += this.AddRemoveRoleWindow_Closed;
            removeRolePage.ShowDialog();
        }

        private void AddRole_Click(object sender, RoutedEventArgs e)
        {
            AddRoleWindow addRoleWindow = new AddRoleWindow();
            addRoleWindow.Closed += AddRemoveRoleWindow_Closed;
            addRoleWindow.ShowDialog();
        }

        private void AddRemoveRoleWindow_Closed(object sender, EventArgs e)
        {
            try
            {
                if (SessionManager.CurrentProject != null)
                {
                    var roles = RolesPageLogic.GetRolesByProjectId(SessionManager.CurrentProject.Id);
                    var rolesWithActors = RolesPageLogic.GetRolesActorsPair(roles);
                    this.RolesWithActors = rolesWithActors;
                    this.DataContext = this;
                    this.SetRolesList(this.RolesWithActors);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
