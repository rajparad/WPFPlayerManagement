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

namespace MTDhruvRajpara
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    private void Window_Loaded(object sender, RoutedEventArgs e)
        {

          
        }


        private void Playerbtn_Click(object sender, RoutedEventArgs e)
        {
            PlayerWindow p = new PlayerWindow();
            p.ShowDialog();
        }

        private void Coachbtn_Click(object sender, RoutedEventArgs e)
        {
            CoachWindow c = new CoachWindow();
            c.ShowDialog();
        }


 
        private void Managerbtn_Click(object sender, RoutedEventArgs e) 
        {
            ManagerWindow m = new ManagerWindow();
            m.ShowDialog();

        }

        private void quitMenu_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Do you really want to close? ", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                this.Close();

            }

        }

        private void studInfo_Click(object sender, RoutedEventArgs e)
        {
            studInfo s = new studInfo();
            s.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Do you really want to close? ", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                this.Close();

            }
        }
    }
}
