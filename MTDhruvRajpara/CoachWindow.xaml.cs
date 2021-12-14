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
    /// Interaction logic for CoachWindow.xaml
    /// </summary>
    public partial class CoachWindow : Window
    {
        static List<Coach> coach = new List<Coach>();
        static int ind = 1;

        public CoachWindow()
        {
            InitializeComponent();

            if (coach.Count == 0)

            {
                Coach coach1 = new Coach(ind++, "Keshav", 12, 105, 99, 13);
                coach.Add(coach1);

                Coach coach2 = new Coach(ind++, "Mahant", 16, 101, 91, 11);
                coach.Add(coach2);

                Coach coach3 = new Coach(ind++, "Pratik", 13, 83, 79.3, 7);
                coach.Add(coach3);

                Coach coach4 = new Coach(ind++, "Akshar", 8, 89, 95.63, 9);
                coach.Add(coach4);

                Coach coach5 = new Coach(ind++, "Dhruv", 4, 34, 73.4, 4);
                coach.Add(coach5);



            }
        }

        private void Winodw_Loaded(object sender, RoutedEventArgs e)
        {
            var coa = from c in coach select c.Name;

            coachList.ItemsSource = coa;

        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            int not;
            int pt;
            double wp;
            int yoe;
            if (Int32.TryParse(textNumberOfTeamsCoached.Text, out not) && Int32.TryParse(textPlayersTrained.Text, out pt ) && Double.TryParse(textWinPercentage.Text, out wp) && Int32.TryParse(textYearsOfExperience.Text, out yoe))
            {
                Coach newCoach = new Coach(ind++, textName.Text, not, pt, wp, yoe);
                coach.Add(newCoach);

            }
            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var coa = from c in coach
                      select c.Name;

            coachList.ItemsSource = coa;


        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int index = coachList.SelectedIndex;

            if (index != -1)
            {
                Coach ca = coach[index];
                int not;
                int pt;
                double wp;
                int yoe;
                if (Int32.TryParse(textNumberOfTeamsCoached.Text, out not) && Int32.TryParse(textPlayersTrained.Text, out pt) && Double.TryParse(textWinPercentage.Text, out wp) && Int32.TryParse(textYearsOfExperience.Text, out yoe))

                {
                    var result = MessageBox.Show("Do you want to update this player? ", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                    if (result == MessageBoxResult.Yes)
                    {
                        ca.Name = textName.Text;
                        ca.NumberOfTeansCoached = not;
                        ca.PlayerTrained = pt;
                        ca.WinPercentage = wp;
                        ca.YearsOfExperience = yoe;


                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            var coachUpdate = from c in coach
                            select c.Name;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int index = coachList.SelectedIndex;
            var result = MessageBox.Show("Do you  want to delete this player? ", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning);


            if (index != -1 && result == MessageBoxResult.Yes)
            {
                coach.RemoveAt(index);

                textId.Clear();
                textName.Clear();
                textNumberOfTeamsCoached.Clear();
                textPlayersTrained.Clear();
                textWinPercentage.Clear();
                textYearsOfExperience.Clear();
            }
            var coaDelete = from c in coach
                            select c.Name;

            coachList.ItemsSource = coaDelete;
        }

        private void coachList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = coachList.SelectedIndex;
            if (index != -1)
            {
                var coa = (from c in coach
                           where c.Name == coach[index].Name
                           select c).FirstOrDefault();

                if (coa != null)
                {
                    textId.Text = coa.Id.ToString();
                    textName.Text = coa.Name;
                    textNumberOfTeamsCoached.Text = coa.NumberOfTeansCoached.ToString();
                    textPlayersTrained.Text = coa.PlayerTrained.ToString();
                    textWinPercentage.Text = coa.WinPercentage.ToString();
                    textYearsOfExperience.Text = coa.YearsOfExperience.ToString();


                }
            }

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
