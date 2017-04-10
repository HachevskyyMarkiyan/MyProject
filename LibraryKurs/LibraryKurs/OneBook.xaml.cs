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
    /// Interaction logic for OneBook.xaml
    /// </summary>
    public partial class OneBook : Window
    {
        public OneBook()
        {
            InitializeComponent();
            Name.Text = Name1;
            Author.Text = Author1;
            Publishing.Text = Publishing1;
            Pages.Text =  Pages1.ToString();
            Year.Text = Year1.ToString();
            Availability.Text = Availability1.ToString();

            string[] GenresItems = { "Fantasy", "Novel", "Horror", "Detective", "For children", "Science" };
            Genre.ItemsSource = GenresItems;
            for (int i = 0; i < GenresItems.Length; ++i)
            {
                if (GenresItems[i] == Genre1)
                    Genre.SelectedIndex = i;
            }
        }

        public static string Name1, Author1, Publishing1, Genre1;
        public static int Pages1, Year1, Availability1, BookID, GenreID;

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
                Books.BooksDT[BookID].Name = Name.Text;
                Books.BooksDT[BookID].Author = Author.Text;
                Books.BooksDT[BookID].Publishing = Publishing.Text;
                Books.BooksDT[BookID].Pages = int.Parse(Pages.Text);
                Books.BooksDT[BookID].Year = int.Parse(Year.Text);
                Books.BooksDT[BookID].Availability = int.Parse(Availability.Text);
                Books.GenresDT[GenreID].Genre = Genre.SelectedItem.ToString();

                Books.BTA.Update(Books.BooksDT);
                //Books.GTA.Update(Books.GenresDT);
            }
            catch( Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
