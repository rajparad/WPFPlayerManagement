using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MTDhruvRajpara
{
    /// <summary>
    /// Interaction logic for PlayerWindow.xaml
    /// </summary>
    public partial class PlayerWindow : Window
    {
        static List<Player> player = new List<Player>();
        static int ind = 1;
        public PlayerWindow()
        {
            InitializeComponent();
            if (player.Count == 0)
            {
                Player player1 = new Player(ind++, "Chirag", 13, 11, 2, 4);
                player.Add(player1);

                Player player2 = new Player(ind++, "Yash", 10, 7, 3, 13);
                player.Add(player2);

                Player player3 = new Player(ind++, "Pratik", 50, 50, 0, 43);
                player.Add(player3);

                Player player4 = new Player(ind++, "Vaibhav", 5, 2, 3, 8);
                player.Add(player4);

                Player player5 = new Player(ind++, "Dhruv", 22, 20, 2, 4);
                player.Add(player5);

            }
        }

        private void listPlayer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = playerList.SelectedIndex;
            if (index != -1)
            {
                var pla = (from p in player
                          where p.Name == player[index].Name
                          select p).FirstOrDefault();

                if (pla != null)
                {
                    textId.Text = pla.Id.ToString();
                    textName.Text = pla.Name;
                    textMatchesPlayed.Text = pla.MatchesPlayed.ToString();
                    textWon.Text = pla.Won.ToString();
                    textLost.Text = pla.Lost.ToString();
                    textGoalsScored.Text = pla.GoalsScored.ToString();
                    
                }
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {

            int mp, won, lost, gs;
            if (Int32.TryParse(textMatchesPlayed.Text, out mp) && Int32.TryParse(textWon.Text, out won) && Int32.TryParse(textLost.Text, out lost) && Int32.TryParse(textGoalsScored.Text, out gs))
            {
                Player newPlayer = new Player(ind++,  textName.Text, mp, won, lost, gs);
                player.Add(newPlayer);
                
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var pla = from p in player
                    select p.Name;

            playerList.ItemsSource = pla;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int index = playerList.SelectedIndex;

            if (index != -1)
            {
                Player p = player[index];
                int mp, won, lost, gs;
                if (Int32.TryParse(textMatchesPlayed.Text, out mp) && Int32.TryParse(textWon.Text, out won) && Int32.TryParse(textLost.Text, out lost) && Int32.TryParse(textGoalsScored.Text, out gs))
                {
                    var result = MessageBox.Show("Do you want to update this player? ", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        p.Name = textName.Text;
                        p.MatchesPlayed = mp;
                        p.Won = won;
                        p.Lost = lost;
                        p.GoalsScored = gs;

                    }
                 
                }
                else
                {
                    MessageBox.Show("Invalid Input!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            var plaUpdate = from p in player
                    select p.Name;

            playerList.ItemsSource = plaUpdate;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int index = playerList.SelectedIndex;
            var result = MessageBox.Show("Do you  want to delete this player? ", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);


            if (index != -1 && result == MessageBoxResult.Yes)
            {
                player.RemoveAt(index);
                textId.Clear();
                textName.Clear();
                textMatchesPlayed.Clear();
                textWon.Clear();
                textLost.Clear();
                textGoalsScored.Clear();
               
            }
            var plaDelete = from p in player
                    select p.Name;

            playerList.ItemsSource = plaDelete;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var pla = from p in player
                    select p.Name;

            playerList.ItemsSource = pla ;
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
