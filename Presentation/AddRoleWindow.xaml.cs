namespace Presentation
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using BLL;
    using DAL;

    /// <summary>
    /// Interaction logic for AddRoleWindow.xaml
    /// </summary>
    public partial class AddRoleWindow : Window
    {
        public AddRoleWindow()
        {
            InitializeComponent();
            var actors = DuberPageLogic.GetAllActors();

            ActorComboBox.Items.Clear();

            foreach (var actor in actors)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = actor.ActorName;
                ActorComboBox.Items.Add(comboBoxItem);
            }
        }

        private void AddRoleButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int projectId = SessionManager.CurrentProject.Id;
                string roleName = AddRoleInput.Text;

                // Check if an item is selected in the ComboBox
                if (ActorComboBox.SelectedItem != null)
                {
                    // Retrieve the selected actor name
                    string actorName = ((ComboBoxItem)ActorComboBox.SelectedItem).Content.ToString();

                    RolesPageLogic.AddRole(roleName, projectId);
                    Role addedRole = RolesPageLogic.GetRoleByRoleNameAndProjId(roleName, projectId);

                    // Check if the actorName is not null or empty
                    if (!string.IsNullOrEmpty(actorName))
                    {
                        Actor bindedActor = DuberPageLogic.GetActorByName(actorName);

                        // Check if the actor is found
                        if (bindedActor != null)
                        {
                            DuberPageLogic.AddProjectCast(bindedActor.Id, addedRole.Id);
                        }
                        else
                        {
                            MessageBox.Show($"Actor '{actorName}' not found.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                        }

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Please select an actor.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an actor.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
