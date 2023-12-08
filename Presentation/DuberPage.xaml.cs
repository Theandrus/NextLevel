namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using BLL;
    using DAL;

    /// <summary>
    /// Interaction logic for DuberPage.xaml
    /// </summary>
    public partial class DuberPage : Page
    {
        List<Tuple<Actor, bool>> Dubers;

        public DuberPage(int projectId)
        {
            this.InitializeComponent();
            this.Dubers = DuberPageLogic.GetActorsToDisplay(projectId);
            this.DataContext = this;
            this.SetRolesList(Dubers);
        }

        private void SetRolesList(List<Tuple<Actor, bool>> dubers)
        {
            this.DuberListView.ItemsSource = dubers;
        }

        private void RemoveActor_Click(object sender, RoutedEventArgs e)
        {
            RemoveActorPage removeActorPage = new RemoveActorPage();
            removeActorPage.Closed += AddRemoveActorPage_Closed;
            removeActorPage.ShowDialog();
        }

        private void AddActor_Click(object sender, RoutedEventArgs e)
        {
            AddActorWindow addActorWindow = new AddActorWindow();
            addActorWindow.Closed += AddRemoveActorPage_Closed;
            addActorWindow.ShowDialog();
        }

        private void AddRemoveActorPage_Closed(object sender, EventArgs e)
        {
            int projectId = -1;
            if (SessionManager.CurrentProject != null)
            {
                projectId = SessionManager.CurrentProject.Id;
            }

            this.Dubers = DuberPageLogic.GetActorsToDisplay(projectId);
            this.SetRolesList(this.Dubers);
        }
    }
}
