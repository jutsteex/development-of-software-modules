using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Student_Name { get; set; }  
        public string Good_Name { get; set; }
        public string Bad_Name { get; set; }
        public string Ocenka { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Add_Student_Click(object sender, RoutedEventArgs e)
        {
            this.Students_list1.Items.Add(this.TextBox_Student.Text);
            this.TextBox_Student.Text = "";
        }

        private void Clear_Field_Click(object sender, RoutedEventArgs e)
        {
            this.Students_list1.Items.Clear(); 
        }

        private void Add_Good_Click(object sender, RoutedEventArgs e)
        {
            this.Goods_list.Items.Add($"{Student_Name} : {Ocenka}");
            this.Students_list1.Items.Remove(Student_Name);
            Student_Name = "";
        }

        private void Add_Bad_Click(object sender, RoutedEventArgs e)
        {
            this.Bads_list.Items.Add(Student_Name);
            this.Students_list1.Items.Remove(Student_Name);
            Student_Name = "";
        }

        private void Goods_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Students_list1.Items.Add(Good_Name);
            this.Goods_list.Items.Remove(Good_Name);
        }

        private void Bads_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Students_list1.Items.Add(Bad_Name);
            this.Bads_list.Items.Remove(Bad_Name);
        }

        private void Clear_all_Click(object sender, RoutedEventArgs e)
        {
            this.Students_list1.Items.Clear();
            this.Goods_list.Items.Clear();
            this.Bads_list.Items.Clear();
            this.TextBox_Student.Clear();
        }

        public ObservableCollection<string> Items { get; } = new ObservableCollection<string>()
        {
            "2",
            "3",
            "4",
            "5"
        };
    }
}
