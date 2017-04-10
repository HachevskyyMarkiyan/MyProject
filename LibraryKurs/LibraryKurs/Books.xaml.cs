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
using System.Data;

namespace LibraryKurs
{
    /// <summary>
    /// Interaction logic for Books.xaml
    /// </summary>
    public partial class Books : Window
    {
        public Books()
        {
            InitializeComponent();
            this.WindowStyle = WindowStyle.None;
            this.WindowState = WindowState.Maximized;

            BooksDT = BTA.GetData();
            GenresDT = GTA.GetData();

            dataGrid.ItemsSource = BooksDT;
            dataGrid.CanUserAddRows = false;
            dataGrid.CanUserDeleteRows = false;
        }

        public static LibraryDataSetTableAdapters.BooksTableAdapter BTA = new LibraryDataSetTableAdapters.BooksTableAdapter();
        public static LibraryDataSetTableAdapters.GenresTableAdapter GTA = new LibraryDataSetTableAdapters.GenresTableAdapter();
        public static LibraryDataSet.BooksDataTable BooksDT;
        public static LibraryDataSet.GenresDataTable GenresDT;

        public static string SearchName, SearchAuthor, SearchGenre;

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Search.type = 1;
            Search a = new Search();
            a.ShowDialog();
            DataRow[] result = BooksDT.Select(String.Format(("Name = '{0}'"),SearchName));
            dataGrid.ItemsSource = result;
            dataGrid.Columns[7].Visibility = Visibility.Hidden;
            dataGrid.Columns[8].Visibility = Visibility.Hidden;
            dataGrid.Columns[9].Visibility = Visibility.Hidden;
            dataGrid.Columns[10].Visibility = Visibility.Hidden;
            dataGrid.Columns[11].Visibility = Visibility.Hidden;
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Search.type = 3;
            Search a = new Search();
            a.ShowDialog();

            string res = "ID = 0";
            foreach ( var book in GenresDT)
            {
                if (book.Genre == SearchGenre)
                    res += " OR ID = " + book.ID;
            }
            DataRow[] result = BooksDT.Select(res);
            dataGrid.ItemsSource = result;
            dataGrid.Columns[7].Visibility = Visibility.Hidden;
            dataGrid.Columns[8].Visibility = Visibility.Hidden;
            dataGrid.Columns[9].Visibility = Visibility.Hidden;
            dataGrid.Columns[10].Visibility = Visibility.Hidden;
            dataGrid.Columns[11].Visibility = Visibility.Hidden;
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Search.type = 2;
            Search a = new Search();
            a.ShowDialog();
            DataRow[] result = BooksDT.Select(String.Format(("Author = '{0}'"),SearchAuthor));
            dataGrid.ItemsSource = result;
            dataGrid.Columns[7].Visibility = Visibility.Hidden;
            dataGrid.Columns[8].Visibility = Visibility.Hidden;
            dataGrid.Columns[9].Visibility = Visibility.Hidden;
            dataGrid.Columns[10].Visibility = Visibility.Hidden;
            dataGrid.Columns[11].Visibility = Visibility.Hidden;
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            for (int i = 0; i < BooksDT.Rows.Count; ++i)
            {
                object item = dataGrid.SelectedItem;
                string ID = (dataGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                if (BooksDT[i].ID == int.Parse(ID))
                {
                    OneBook.BookID = i;
                    OneBook.Name1 = BooksDT[i].Name;
                    OneBook.Author1 = BooksDT[i].Author;
                    OneBook.Publishing1 = BooksDT[i].Publishing;
                    OneBook.Year1 = BooksDT[i].Year;
                    OneBook.Pages1 = BooksDT[i].Pages;
                    OneBook.Availability1 = BooksDT[i].Availability;
                }
            }

            try
            {
                bool known = false;

                for (int i = 0; i < GenresDT.Rows.Count; ++i)
                {
                    if (GenresDT[i].ID == BooksDT[dataGrid.SelectedIndex].ID)
                    {
                        OneBook.Genre1 = GenresDT[i].Genre;
                        OneBook.GenreID = i;
                        known = true;
                    }   
                }

                if (!known)
                    OneBook.Genre1 = "Unknown";
            }
            catch (Exception ex) { }

            OneBook a = new OneBook();
            a.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = BooksDT;

            BTA.Update(BooksDT);
            //GTA.Update(GenresDT);
        }
    }
}
