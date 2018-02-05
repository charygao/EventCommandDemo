using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace EventCommandDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            #region 绑定数据和命令

            MainViewModel _viewmodel = null;
            this.Loaded += (sender, e) =>
            {
                if (_viewmodel == null)
                {
                    _viewmodel = new MainViewModel();
                    this.DataContext = _viewmodel;
                }
            };

            #endregion
          
        }

      }
}
