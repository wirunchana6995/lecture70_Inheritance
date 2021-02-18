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

namespace Lecture70_Inheritance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Cat cat = new Cat(); // new object เอาพิมพ์เขียวมาใช้ในชื่อของ cat
            MessageBox.Show(cat.cry()); //user method from sub class(ตัวลูก)
            MessageBox.Show(cat.breat()); //user method from super class -> ตัวล
        }
    }
}
