namespace Presentation
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using BLL;

    /// <summary>
    /// Interaction logic for RemoveRolePage.xaml
    /// </summary>
    public partial class RemoveRolePage : Window
    {
        public RemoveRolePage()
        {
            this.InitializeComponent();
            int projectId = SessionManager.CurrentProject.Id;
            var roles = RolesPageLogic.GetRolesByProjectId(projectId);

            this.RoleComboBox.Items.Clear();

            foreach (var role in roles)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = role.RoleName;
                this.RoleComboBox.Items.Add(comboBoxItem);
            }
        }

        private void RemoveRoleButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string roleName = ((ComboBoxItem)this.RoleComboBox.SelectedItem).Content.ToString();
                int projectId = SessionManager.CurrentProject.Id;

                RolesPageLogic.RemoveRole(roleName, projectId);
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.WriteLog(ex.Message, LogLevel.Error);
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
