using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace ChecksumChecker
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


        //public bool CheckChecksum()
        //{
        //    var test = System.Security.Cryptography.MD5.Create();




        //    string strResult = "";
        //    string strHashData = "";

        //    byte[] arrbytHashValue;
        //    System.IO.FileStream oFileStream = null;

        //    System.Security.Cryptography.MD5CryptoServiceProvider oMD5Hasher =
        //               new System.Security.Cryptography.MD5CryptoServiceProvider();

        //    try
        //    {
        //        oFileStream = GetFileStream(textBox2.Text);
        //        arrbytHashValue = oMD5Hasher.ComputeHash(oFileStream);
        //        oFileStream.Close();

        //        strHashData = System.BitConverter.ToString(arrbytHashValue);
        //        strHashData = strHashData.Replace("-", "");
        //        strResult = strHashData;
        //    }
        //    catch (System.Exception ex)
        //    {

        //    }

        //   // byte[] buff = new byte[20];

        //   //ar output = BitConverter.ToString(test.ComputeHash(buff));

        //    textBlock2.Text = strHashData;

        //    bool result = textBox1.Text.Equals(strHashData.ToLower(), StringComparison.CurrentCultureIgnoreCase);

        //    return result;

        //}

        //private void button1_Click(object sender, RoutedEventArgs e)
        //{

        //    if (CheckChecksum())
        //    {
        //        this.textBox1.Background = Brushes.Green;
        //    }
        //    else
        //    {
        //        this.textBox1.Background = Brushes.Red;
        //    }
        //}

        //private static FileStream GetFileStream(string pathName)
        //{
        //    return (new System.IO.FileStream(pathName, System.IO.FileMode.Open,
        //              System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite));
        //}
    }

}
