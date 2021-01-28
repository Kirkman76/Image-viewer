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
using Microsoft.Win32;
using System.Windows.Forms;
using ListBox = System.Windows.Controls.ListBox;

namespace ImageGallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        FileInfo[] selectedFiles;
        string selectedFolder;
        string rootFolderPath;
        void ShowProperties(FileInfo fg)
        {
            try
            {
                BitmapImage bmp = new BitmapImage(new Uri(fg.FullName));
                propertiesExp.Content = $"\nРазрешение:\n{bmp.PixelWidth} X {bmp.PixelHeight}\n\nРазмер: {fg.Length / 1024} КБ";
            }
            catch(NotSupportedException)
            {}
            
        }

        void FillFoldersList()
        {
            if(rootFolderPath?.Length > 3)
            {
                var folders = Directory.GetDirectories(rootFolderPath);
                foldersList.Items.Add("");
                foreach (string fi in folders)
                {
                    foldersList.Items.Add(fi.Remove(0, fi.LastIndexOf('\\') + 1));
                }
            }
        }

        void InitSlider(string folder)
        {
            imgSlider.Maximum = selectedFiles.Length - 1;
            imgSlider.Value = 0;
        }

        void InitFilesList(string folder)
        {
            DirectoryInfo df = new DirectoryInfo(rootFolderPath + "\\" + folder);
            List<FileInfo> tmp1 = df.GetFiles().ToList<FileInfo>();
            List<FileInfo> tmp2 = new List<FileInfo>();

            foreach(FileInfo fi in tmp1)
            {
                try
                {
                    BitmapImage bmp = new BitmapImage(new Uri(fi.FullName));
                    tmp2.Add(fi);
                }
                catch (NotSupportedException)
                {}
                catch (FileFormatException)
                {}
            }

            selectedFiles = tmp2.ToArray();

        }

        void ViewImage(int imageNum)
        {
            if (selectedFiles?.Count() > 0)
            {
                try
                    {
                    BitmapImage bmp = new BitmapImage(new Uri(selectedFiles[imageNum].FullName));
                    imageBig.Source = bmp;
                    imgContainer.Height = imageBig.Height;
                    imgContainer.Width = imageBig.Width;
                    }
                 catch(NotSupportedException)
                 {}
                 catch (FileFormatException)
                 {}

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillFoldersList();
            if (foldersList.Items.Count != 0)
            {
                foldersList.SelectedItem = foldersList.Items[1];
            }

        }

        private void FoldersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox foldersList = sender as ListBox;
            selectedFolder = foldersList.SelectedItem?.ToString();
            InitFilesList(selectedFolder);
            InitSlider(selectedFolder);
            if (selectedFiles?.Count() > 0)
            {
                ShowProperties(selectedFiles[0]);
            }
            ViewImage(0);
            imgNumTxtBox.Text = "1";
        }

        private void PrevBtn_Click(object sender, RoutedEventArgs e)
        {
            imgSlider.Value--;
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {
            imgSlider.Value++;
        }

        private void ImgSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ViewImage(Convert.ToInt32(e.NewValue));
            imgNumTxtBox.Text = (e.NewValue + 1).ToString();
            if (selectedFiles?.Count() > 0)
            {
                ShowProperties(selectedFiles[Convert.ToInt32(e.NewValue)]);
            }
        }
        private void ImgNumTxtBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                int res = 0;
                if (int.TryParse(imgNumTxtBox.Text, out res))
                {
                    if (res >= 0 && res <= selectedFiles.Length)
                    {
                        imgSlider.Value = res - 1;
                    }
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            var dr = fbd.ShowDialog();
            rootFolderPath = fbd.SelectedPath;

            foldersList.Items.Clear();


            FillFoldersList();
            if (foldersList.Items.Count != 0)
            {
                foldersList.SelectedItem = foldersList.Items[0];
            }

        }
    }
}
