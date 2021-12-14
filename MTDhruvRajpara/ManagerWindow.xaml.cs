using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MTDhruvRajpara
{
    /// <summary>
    /// Interaction logic for ManagerWindow.xaml
    /// </summary>
    public partial class ManagerWindow : Window
    {
        static List<Manager> manager = new List<Manager>();
        static int ind = 1;
        public ManagerWindow()
        {
            InitializeComponent();

            if (manager.Count == 0)
            {
                Manager manager1 = new Manager(ind++, "Pramukh", 22, 4472.28, "Leader");
                manager.Add(manager1);

                Manager manager2 = new Manager(ind++, "Jay", 16, 3462.23, "Knowledgeable");
                manager.Add(manager2);

                Manager manager3 = new Manager(ind++, "Trushar", 12, 2324.42,"Creative");
                manager.Add(manager3);

                Manager manager4 = new Manager(ind++, "Siddharth", 21, 3211.37 , "Expert");
                manager.Add(manager4);

                Manager manager5 = new Manager(ind++, "Harshil", 9, 1274.32, "Effective");
                manager.Add(manager5);

                

            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            int pr;
            double ab;
            var st = textStength.Text;
            if (Int32.TryParse(textPlayersRecruited.Text, out pr) && Double.TryParse(textAvailableBudget.Text, out ab) && st.Any())
            {
                Manager newManager = new Manager(ind++, textName.Text, pr, ab, st );
                manager.Add(newManager);

            }
            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var man = from m in manager
                    select m.Name;

            managerList.ItemsSource = man;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var m = from manager in manager
                    select manager.Name;

            managerList.ItemsSource = m;
        }

        private void managerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = managerList.SelectedIndex;
            if (index != -1)
            {
                var man = (from m in manager
                         where m.Name == manager[index].Name
                         select m).FirstOrDefault();

                if (man != null)
                {
                    textId.Text = man.Id.ToString();
                    textName.Text = man.Name;
                    textPlayersRecruited.Text = man.PlayersRecruited.ToString();
                    textAvailableBudget.Text = man.AvailableBudget.ToString();
                    textStength.Text = man.Strength.ToString();
                   

                }
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int index = managerList.SelectedIndex;

            if (index != -1)
            {
                Manager man = manager[index];
                int pr;
                double ab;
                var st = textStength.Text;
                if (Int32.TryParse(textPlayersRecruited.Text, out pr) && Double.TryParse(textAvailableBudget.Text, out ab) && st.Any())

                {
                    var result = MessageBox.Show("Do you want to update this player? ", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        man.Name = textName.Text;
                        man.PlayersRecruited = pr;
                       man.AvailableBudget = ab;
                        man.Strength = st;
                       

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            var manUpdate = from m in manager
                     select m.Name;

            managerList.ItemsSource = manUpdate;

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int index = managerList.SelectedIndex;
            var result = MessageBox.Show("Do you  want to delete this player? ", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);


            if (index != -1 && result == MessageBoxResult.Yes)
            {
                manager.RemoveAt(index);

                textId.Clear();
                textName.Clear();
                textPlayersRecruited.Clear();
                textAvailableBudget.Clear();
                textStength.Clear();

            }
            var manDelete= from m in manager
                    select m.Name;

            managerList.ItemsSource = manDelete;
        }


        private void quitMenu_Click(object sender, RoutedEventArgs e)
        { 
                this.Close();

        }
        private void studInfo_Click(object sender, RoutedEventArgs e)
        {
            studInfo s = new studInfo();
            s.ShowDialog();
        }
    }
}
