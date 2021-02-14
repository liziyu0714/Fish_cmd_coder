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
using Windowcoder.Pages;
using System.Threading;

namespace Windowcoder
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            
            Loadpage myloadpage = new Loadpage();
            myloadpage.Show();
            Random random = new Random();
            Thread.Sleep(random.Next(1000, 4000));
            myloadpage.Close();
            InitializeComponent();
            

        }

        

        private void gotohelp(object sender, RoutedEventArgs e)
        {
            Exception exception = new FishErrors.Functions_tobe_developed_Error("尚未开发");
            exception.HelpLink = "https://github.com/liziyu0714/Fish_cmd_coder/wiki/%E9%94%99%E8%AF%AF%EF%BC%9AFishErrors.Functions_tobe_developed_Error%EF%BC%9A%E5%B0%9A%E6%9C%AA%E5%BC%80%E5%8F%91";
            errorcatcher myerrorcatcher = new errorcatcher(exception);
            myerrorcatcher.Show();
        }
    }
}
