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

namespace FinalProject13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BindData();
        }
        void BindData()
        {
            mediaDataGrid.ItemsSource = Library.medias;
            membersDataGrid.ItemsSource = Library.libraryMembers;
        }

        private void lendMediaBtn_Click(object sender, RoutedEventArgs e)
        {
           
            if (mediaDataGrid.SelectedItem == null || membersDataGrid.SelectedItem == null)
            {

                MessageBox.Show("Warnning! \nPlease select one Media row and select person", "Lend Media");
            }
            else if (!((Media)mediaDataGrid.SelectedItem).Availability)
            {
                MessageBox.Show("Warnning! \nThe media is not available to lend", "Lend Media");
            }
            else {

                ((Media)mediaDataGrid.SelectedItem).WhoBorrowed = membersDataGrid.SelectedItem.ToString();
                ((Media)mediaDataGrid.SelectedItem).Availability = false;
                MessageBox.Show("The "+((Media)mediaDataGrid.SelectedItem).Title+" "+((Media)mediaDataGrid.SelectedItem).MediaType+ " is borrowed by "+ ((LibraryMember)membersDataGrid.SelectedItem).ToString(), "Lend Media");
                
            }
            UpdateMediaDataGrid();
            membersDataGrid.SelectedItem = null;
        }

        private void returnMediaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (mediaDataGrid.SelectedItem == null )
            {

                MessageBox.Show("Warnning! \nPlease select the Media row which you want to return ", "Return Media");
            }
            else if (((Media)mediaDataGrid.SelectedItem).Availability)
            {
                MessageBox.Show("Warnning! \nThe media is not borrowed, try again!", "Return Media");
            }
            else
            {
                ((Media)mediaDataGrid.SelectedItem).WhoBorrowed = null;
                ((Media)mediaDataGrid.SelectedItem).Availability = true;
                MessageBox.Show("The " + ((Media)mediaDataGrid.SelectedItem).Title + " is returned sucessfully","Return Media");
                

            }
            UpdateMediaDataGrid();
            membersDataGrid.SelectedItem = null;
        }

        private void UpdateMediaDataGrid()
        {
            mediaDataGrid.ItemsSource = null;    
            BindData();
        }

    }
}
