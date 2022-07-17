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
using System.IO;
//Diagnose 
using System.Diagnostics;


namespace Notizbuch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static string notizPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/Notizen/";
        //static string notizPath = @"E:\Notizen\";
        static string[] notizen = { };
        static string notizname;
        static string offene_notiz;
        static bool delitem = false;
        static bool x = false;




        static void if_file()
        {
            if (!File.Exists(notizPath))
            {
                Directory.CreateDirectory(notizPath);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            Grid_new.Visibility = Visibility.Hidden;
            Save_msg.Visibility = Visibility.Hidden;
            if_file();
            notiz();    
        }

        public void notiz()
        {
            System.IO.DirectoryInfo ParentDirectory = new System.IO.DirectoryInfo(notizPath);
            listBox.Items.Clear();
            foreach (System.IO.FileInfo f in ParentDirectory.GetFiles())
            {
                Debug.WriteLine("Datei: " + f.Name);
                string data = f.Name;
                listBox.Items.Add(data);
            }
        }

        // Notizen öffnen
        public void openNotiz(string open)
        {
            NotizBox.Text = "";
            string[] x = File.ReadAllLines(open);
            notizname = open;
            for (int i = 0; i < x.Length; i++)
            {
                NotizBox.Text += x[i] +"\n";
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string item = listBox.SelectedItem.ToString();
                openNotiz(notizPath + listBox.SelectedItem.ToString());
                notizname = notizPath +
                 listBox.SelectedItem.ToString();
                Save_msg.Visibility = Visibility.Hidden;
                if (delitem == true)
                {
                    delete_item(item);
                    
                }
            }
        }
        
        public void delete_item(string item)
        {
            File.Delete(notizPath + item);
            notiz();
            delitem = false;
        }
        
        public void save(object sender, RoutedEventArgs e)
        {
            string text = NotizBox.Text;
            Debug.WriteLine(text);
            File.WriteAllText(notizname, text);
            Save_msg.Visibility = Visibility.Visible;
        }

        private void New_Notiz(object sender, RoutedEventArgs e)
        {
            Grid_new.Visibility = Visibility.Visible;
        }

        private void ok_create(object sender, RoutedEventArgs e)
        {
            string name = textBox_new.Text;
            Create(notizPath + name + ".txt", " ");
            textBox_new.Text = "";
            listBox.Items.Add(name+".txt");
            Grid_new.Visibility = Visibility.Hidden;
        }

        private void abbruch_create(object sender, RoutedEventArgs e)
        {
            textBox_new.Text = "";
            Grid_new.Visibility = Visibility.Hidden;
        
        }

        public async Task Create(string filePath, string text)
        {
            await File.WriteAllTextAsync(filePath, text);  
        }

        private void delete(object sender, RoutedEventArgs e)
        {
            if (delitem == false)
            {
                delitem = true;
            }else
            {
                delitem = false;
              //  listBox.IsEnabled = true;
            }
        }
        
        
        
    }
}
