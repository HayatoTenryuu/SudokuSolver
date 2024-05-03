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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for FinalWindow.xaml
    /// </summary>
    public partial class FinalWindow : Window
    {
        public FinalWindow(Machinery.Rows alpha, Machinery.Rows omega)
        {
            InitializeComponent();

            int[][] OG_Matrix = alpha.getmatrix();
            int[][] new_Matrix = omega.getmatrix();

            R11_OG.Text = OG_Matrix[0][0].ToString();
        }
    }
}
