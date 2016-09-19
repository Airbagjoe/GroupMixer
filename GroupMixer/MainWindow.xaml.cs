using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Microsoft.Win32;

namespace GroupMixer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            cbTeam.ItemsSource = Team.Teams;
            cbTeam.DisplayMemberPath = "Name";
            cbTeam.SelectedIndex = 0;
        }

        private void bGroup_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNumberOfGroups.Text))
            {
                MessageBox.Show(this, "Please enter a number of groupe to divide into.", "Invalid group number", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            int nrGroups = int.Parse(tbNumberOfGroups.Text);
            if (nrGroups == 0)
            {
                MessageBox.Show(this, "The number of groups must be greater than zero.", "Invalid group number", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            var rnd = new Random(Guid.NewGuid().GetHashCode());

            var team = (Team)cbTeam.SelectedValue;

            //Init buckets
            var buckets = new List<List<string>>();
            for (int i = 0; i < nrGroups; i++)
            {
                buckets.Add(new List<string>());
            }

            int bucketNumber = 0;
            foreach (var student in team.Students.Randomize())
            {
                buckets[bucketNumber].Add(student);

                if (bucketNumber == nrGroups -1)
                {
                    bucketNumber = 0;
                }
                else
                {
                    bucketNumber++;
                }
            }

            var sb = new StringBuilder();
            for (int i = 0; i < buckets.Count; i++)
            {
                List<string> bucket = buckets[i];
                if (checkIncludeGroupNr.IsChecked.HasValue && checkIncludeGroupNr.IsChecked.Value)
                {
                    sb.Append("Group " + (i + 1) + "\t");
                }
                
                sb.Append(string.Join("\t", bucket));

                if (i != buckets.Count -1)
                {
                    sb.AppendLine();
                } 
            }

            resultText.Document.Blocks.Clear();
            resultText.AppendText(sb.ToString());
            resultText.FontFamily = new FontFamily("Times New Roman");
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
