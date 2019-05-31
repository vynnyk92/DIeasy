using PeopleViewer.Presentation;
using PersonDataReader.Service;
using System.Windows;

namespace PeopleViewer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            BuildDependencies();
            Application.Current.MainWindow.Show();
        }

        private static void BuildDependencies()
        {
            var reader = new ServiceReader();
            var viewModel = new PeopleViewModel(reader);
            Application.Current.MainWindow = new PeopleViewerWindow(viewModel);
        }
    }
}
