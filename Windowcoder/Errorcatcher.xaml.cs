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
using System.Windows.Shapes;

namespace Windowcoder
{
    /// <summary>
    /// errorcatcher.xaml 的交互逻辑
    /// </summary>
    public partial class errorcatcher : Window
    {
        string errorurl = "";
        public errorcatcher(Exception exception)
        {
            InitializeComponent();
            this.haveerror.Text += exception.GetType().ToString();
            this.errortext.Text += exception.Message;
            this.errortype.Text+= exception.GetType().ToString();
            this.errorinner.Text += "NULL";
            this.errorhelpurl.Text += exception.HelpLink;
            errorurl = exception.HelpLink;
        }

        private void copyit(object sender, RoutedEventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(this.errorurl, true);
                MessageBox.Show("粘贴成功");
            }
            catch (Exception ex)
            {
                errorcatcher newerrorcatcher = new errorcatcher(ex);
                newerrorcatcher.Show();
            }
            
        }
    }
}
