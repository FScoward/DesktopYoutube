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

namespace DesktopYoutube
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private String initializeText= "input keyword...";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Search(object sender, RoutedEventArgs e)
        {
            // 検索処理
            
            // ListViewのウィンドウを開く
            ResultListWindow rlw = new ResultListWindow();
            rlw.Show();
        }

        // マウスが検索ボックスに当たった時の処理
        private void SearchBox_MouseEnter(object sender, MouseEventArgs e)
        {
            // 検索ボックスの値が初期値であれば空に
            if (SearchBox.Text == initializeText) {
                SearchBox.Text = "";
            }
            
        }

        // マウスが検索ボックスから離れた時の処理
        private void SearchBox_MouseLeave(object sender, MouseEventArgs e)
        {
            // 検索ボックスが空であれば初期値を再表示
            if (SearchBox.Text.Length == 0)
            {
                SearchBox.Text = initializeText;
            }
        }


    }
}
