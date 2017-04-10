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
using System.Windows.Shapes;

namespace LibraryKurs
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public Search()
        {
            InitializeComponent();
            if (type == 1)
            {
                label.Content = "Enter name:";
                FantasyBtn.Visibility = Visibility.Hidden;
                ScienceBtn.Visibility = Visibility.Hidden;
                ForChildrenBtn.Visibility = Visibility.Hidden;
                HorrorBtn.Visibility = Visibility.Hidden;
                NovelBtn.Visibility = Visibility.Hidden;
                DetectiveBtn.Visibility = Visibility.Hidden;
            }
            if (type == 2)
            {
                label.Content = "Enter author:";
                FantasyBtn.Visibility = Visibility.Hidden;
                ScienceBtn.Visibility = Visibility.Hidden;
                ForChildrenBtn.Visibility = Visibility.Hidden;
                HorrorBtn.Visibility = Visibility.Hidden;
                NovelBtn.Visibility = Visibility.Hidden;
                DetectiveBtn.Visibility = Visibility.Hidden;
            }
            if (type == 3)
            {
                label.Visibility = Visibility.Hidden;
                button.Visibility = Visibility.Hidden;
                textBox.Visibility = Visibility.Hidden;
            }
        }

        public static int type;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (type == 1)
                Books.SearchName = textBox.Text;
            if (type == 2)
                Books.SearchAuthor = textBox.Text;
            Close();
        }

        #region Genres

        private void FantasyBtn_Click(object sender, RoutedEventArgs e)
        {
            Books.SearchGenre = "Fantasy";
            Close();
        }

        private void DetectiveBtn_Click(object sender, RoutedEventArgs e)
        {
            Books.SearchGenre = "Detective";
            Close();
        }

        private void ForChildrenBtn_Click(object sender, RoutedEventArgs e)
        {
            Books.SearchGenre = "For Children";
            Close();
        }

        private void NovelBtn_Click(object sender, RoutedEventArgs e)
        {
            Books.SearchGenre = "Novel";
            Close();
        }

        private void HorrorBtn_Click(object sender, RoutedEventArgs e)
        {
            Books.SearchGenre = "Horror";
            Close();
        }

        private void ScienceBtn_Click(object sender, RoutedEventArgs e)
        {
            Books.SearchGenre = "Science";
            Close();
        }

        #endregion

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
