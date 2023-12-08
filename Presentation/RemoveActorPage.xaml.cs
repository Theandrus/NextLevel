namespace WpfApp1
{
    using System;
    using System.Windows;
    using BLL;

    /// <summary>
    /// Interaction logic for RemoveActorPage.xaml
    /// </summary>
    public partial class RemoveActorPage : Window
    {
        public RemoveActorPage()
        {
            this.InitializeComponent();
        }

        private void RemoveActorButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string actorName = this.ActorNameInput.Text;
                DuberPageLogic.RemoveActor(actorName);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
