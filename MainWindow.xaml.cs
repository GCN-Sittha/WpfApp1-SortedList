using System;
using System.Collections;
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

namespace WpfApp1_SortedList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedlist;
        public MainWindow()
        {
            InitializeComponent();
            sortedlist = new SortedList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            sortedlist.Add(int.Parse(keyTxt.Text), valueTxt.Text);
            keyTxt.Clear();
            valueTxt.Clear();
            string allData = "";

            ICollection collection = sortedlist.Keys;

            foreach(int key in collection)
            {
                allData = allData + " " + "\n" + sortedlist[key].ToString();
                
            }
            MessageBox.Show(allData);

        }
    }
}
