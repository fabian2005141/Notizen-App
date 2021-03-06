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
        static string openNotizName;
        static bool delitem = false;
 

        // Schaut nach ob es den Notizen ortner in der appdata gibt und erstellt den ortner wenn nötig
        static void if_file_exist()
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
            if_file_exist();
            notiz();    
        }

        //Importiert die Notizen aus dem Ortner
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
            openNotizName = open;
            for (int i = 0; i < x.Length; i++)
            {
                NotizBox.Text += x[i] +"\n";
            }
        }

        // Wird ausgefürt, wenn item aus der listBox gedrückt wird
        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                string item = listBox.SelectedItem.ToString();
                openNotiz(notizPath + listBox.SelectedItem.ToString());
                openNotizName = notizPath +
                 listBox.SelectedItem.ToString();
                Save_msg.Visibility = Visibility.Hidden;
                if (delitem == true)
                {
                    delete_item(item);
                    
                }
            }
        }
        
        // Löscht Notizen mit der endung .txt aus dem Notizenortner
        public void delete_item(string item)
        {
            File.Delete(notizPath + item);
            notiz();
            delitem = false;
        }
        
        // Funktionen von allen Buttons
        public void ButtonClick(object sender,RoutedEventArgs e)
        {
            Button button = sender as Button;

            switch (button.Name)
            {

                // Save Funktion
                case ("Save_Button"):
                    Debug.WriteLine("Button save");
                    string text = NotizBox.Text;
                    Debug.WriteLine(text);
                    File.WriteAllText(openNotizName, text);
                    Save_msg.Visibility = Visibility.Visible;
                    break;

                // Neue Notiz Funktion
                case ("New_Button"):
                    Grid_new.Visibility = Visibility.Visible;
                    break;

                // Lösch button
                case ("Delete_Button"):
                    if (delitem == false)
                    {
                        delitem = true;
                    }
                    else
                    {
                        delitem = false;
                        //  listBox.IsEnabled = true;
                    }
                    break;

                //Grid New:
                // OK Button
                case ("ok_button"):
                    string name = textBox_new.Text;
                    Create(notizPath + name + ".txt", " ");
                    textBox_new.Text = "";
                    listBox.Items.Add(name + ".txt");
                    Grid_new.Visibility = Visibility.Hidden;
                    break;

                // abbruch Button
                case ("abbruch_button"):
                    textBox_new.Text = "";
                    Grid_new.Visibility = Visibility.Hidden;
                    break;

                // Error 
                default:
                        Debug.WriteLine("Error, Button nicht gefunden");
                    break;

            }
            
        }

        //async Funktionen
        public async Task Create(string filePath, string text)
        {
            await File.WriteAllTextAsync(filePath, text);
        }


    }
}
