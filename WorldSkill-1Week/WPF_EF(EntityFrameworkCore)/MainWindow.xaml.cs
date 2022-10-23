using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_EF_EntityFrameworkCore_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly WorldSkills1Context _context =
            new WorldSkills1Context();

        private CollectionViewSource userViewSource;

        public MainWindow()
        {
            InitializeComponent();
            userViewSource =
                (CollectionViewSource)FindResource(nameof(userViewSource));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // this is for demo purposes only, to make it easier
            // to get up and running
            _context.Database.EnsureCreated();

            // load the entities into EF Core
            _context.Users.Load();

            // bind to the source
            userViewSource.Source =
                _context.Users.Local.ToObservableCollection();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // clean up database connections
            _context.Dispose();
            base.OnClosing(e);
        }
    }
}
