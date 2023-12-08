namespace WpfApp1
{
    using System;
    using System.Windows;
    using BLL;

    /// <summary>
    /// Interaction logic for AddActorWindow.xaml
    /// </summary>
    public partial class AddActorWindow : Window
    {
        public AddActorWindow()
        {
            InitializeComponent();
        }

        private void AddActorButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string actorName = ActorNameInput.Text;
                DuberPageLogic.AddActor(actorName);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
