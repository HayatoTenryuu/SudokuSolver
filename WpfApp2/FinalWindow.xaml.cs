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
            
            SolidColorBrush BlueBrush = new SolidColorBrush(Colors.DodgerBlue);

            R11_OG.Text = OG_Matrix[0][0].ToString();
            if (R11_OG.Text == "0") { R11_OG.Text = ""; }

            R12_OG.Text = OG_Matrix[0][1].ToString();
            if (R12_OG.Text == "0") { R12_OG.Text = ""; }

            R13_OG.Text = OG_Matrix[0][2].ToString();
            if (R13_OG.Text == "0") { R13_OG.Text = ""; }

            R14_OG.Text = OG_Matrix[0][3].ToString();
            if (R14_OG.Text == "0") { R14_OG.Text = ""; }

            R15_OG.Text = OG_Matrix[0][4].ToString();
            if (R15_OG.Text == "0") { R15_OG.Text = ""; }

            R16_OG.Text = OG_Matrix[0][5].ToString();
            if (R16_OG.Text == "0") { R16_OG.Text = ""; }

            R17_OG.Text = OG_Matrix[0][6].ToString();
            if (R17_OG.Text == "0") { R17_OG.Text = ""; }

            R18_OG.Text = OG_Matrix[0][7].ToString();
            if (R18_OG.Text == "0") { R18_OG.Text = ""; }

            R19_OG.Text = OG_Matrix[0][8].ToString();
            if (R19_OG.Text == "0") { R19_OG.Text = ""; }

            R21_OG.Text = OG_Matrix[1][0].ToString();
            if (R21_OG.Text == "0") { R21_OG.Text = ""; }

            R22_OG.Text = OG_Matrix[1][1].ToString();
            if (R22_OG.Text == "0") { R22_OG.Text = ""; }

            R23_OG.Text = OG_Matrix[1][2].ToString();
            if (R23_OG.Text == "0") { R23_OG.Text = ""; }

            R24_OG.Text = OG_Matrix[1][3].ToString();
            if (R24_OG.Text == "0") { R24_OG.Text = ""; }

            R25_OG.Text = OG_Matrix[1][4].ToString();
            if (R25_OG.Text == "0") { R25_OG.Text = ""; }

            R26_OG.Text = OG_Matrix[1][5].ToString();
            if (R26_OG.Text == "0") { R26_OG.Text = ""; }

            R27_OG.Text = OG_Matrix[1][6].ToString();
            if (R27_OG.Text == "0") { R27_OG.Text = ""; }

            R28_OG.Text = OG_Matrix[1][7].ToString();
            if (R28_OG.Text == "0") { R28_OG.Text = ""; }

            R29_OG.Text = OG_Matrix[1][8].ToString();
            if (R29_OG.Text == "0") { R29_OG.Text = ""; }

            R31_OG.Text = OG_Matrix[2][0].ToString();
            if (R31_OG.Text == "0") { R31_OG.Text = ""; }

            R32_OG.Text = OG_Matrix[2][1].ToString();
            if (R32_OG.Text == "0") { R32_OG.Text = ""; }

            R33_OG.Text = OG_Matrix[2][2].ToString();
            if (R33_OG.Text == "0") { R33_OG.Text = ""; }

            R34_OG.Text = OG_Matrix[2][3].ToString();
            if (R34_OG.Text == "0") { R34_OG.Text = ""; }

            R35_OG.Text = OG_Matrix[2][4].ToString();
            if (R35_OG.Text == "0") { R35_OG.Text = ""; }

            R36_OG.Text = OG_Matrix[2][5].ToString();
            if (R36_OG.Text == "0") { R36_OG.Text = ""; }

            R37_OG.Text = OG_Matrix[2][6].ToString();
            if (R37_OG.Text == "0") { R37_OG.Text = ""; }

            R38_OG.Text = OG_Matrix[2][7].ToString();
            if (R38_OG.Text == "0") { R38_OG.Text = ""; }

            R39_OG.Text = OG_Matrix[2][8].ToString();
            if (R39_OG.Text == "0") { R39_OG.Text = ""; }

            R41_OG.Text = OG_Matrix[3][0].ToString();
            if (R41_OG.Text == "0") { R41_OG.Text = ""; }

            R42_OG.Text = OG_Matrix[3][1].ToString();
            if (R42_OG.Text == "0") { R42_OG.Text = ""; }

            R43_OG.Text = OG_Matrix[3][2].ToString();
            if (R43_OG.Text == "0") { R43_OG.Text = ""; }

            R44_OG.Text = OG_Matrix[3][3].ToString();
            if (R44_OG.Text == "0") { R44_OG.Text = ""; }

            R45_OG.Text = OG_Matrix[3][4].ToString();
            if (R45_OG.Text == "0") { R45_OG.Text = ""; }

            R46_OG.Text = OG_Matrix[3][5].ToString();
            if (R46_OG.Text == "0") { R46_OG.Text = ""; }

            R47_OG.Text = OG_Matrix[3][6].ToString();
            if (R47_OG.Text == "0") { R47_OG.Text = ""; }

            R48_OG.Text = OG_Matrix[3][7].ToString();
            if (R48_OG.Text == "0") { R48_OG.Text = ""; }

            R49_OG.Text = OG_Matrix[3][8].ToString();
            if (R49_OG.Text == "0") { R49_OG.Text = ""; }

            R51_OG.Text = OG_Matrix[4][0].ToString();
            if (R51_OG.Text == "0") { R51_OG.Text = ""; }

            R52_OG.Text = OG_Matrix[4][1].ToString();
            if (R52_OG.Text == "0") { R52_OG.Text = ""; }

            R53_OG.Text = OG_Matrix[4][2].ToString();
            if (R53_OG.Text == "0") { R53_OG.Text = ""; }

            R54_OG.Text = OG_Matrix[4][3].ToString();
            if (R54_OG.Text == "0") { R54_OG.Text = ""; }

            R55_OG.Text = OG_Matrix[4][4].ToString();
            if (R55_OG.Text == "0") { R55_OG.Text = ""; }

            R56_OG.Text = OG_Matrix[4][5].ToString();
            if (R56_OG.Text == "0") { R56_OG.Text = ""; }

            R57_OG.Text = OG_Matrix[4][6].ToString();
            if (R57_OG.Text == "0") { R57_OG.Text = ""; }

            R58_OG.Text = OG_Matrix[4][7].ToString();
            if (R58_OG.Text == "0") { R58_OG.Text = ""; }

            R59_OG.Text = OG_Matrix[4][8].ToString();
            if (R59_OG.Text == "0") { R59_OG.Text = ""; }

            R61_OG.Text = OG_Matrix[5][0].ToString(); 
            if (R61_OG.Text == "0") { R61_OG.Text = ""; }

            R62_OG.Text = OG_Matrix[5][1].ToString();
            if (R62_OG.Text == "0") { R62_OG.Text = ""; }

            R63_OG.Text = OG_Matrix[5][2].ToString();
            if (R63_OG.Text == "0") { R63_OG.Text = ""; }

            R64_OG.Text = OG_Matrix[5][3].ToString();
            if (R64_OG.Text == "0") { R64_OG.Text = ""; }

            R65_OG.Text = OG_Matrix[5][4].ToString();
            if (R65_OG.Text == "0") { R65_OG.Text = ""; }

            R66_OG.Text = OG_Matrix[5][5].ToString();
            if (R66_OG.Text == "0") { R66_OG.Text = ""; }

            R67_OG.Text = OG_Matrix[5][6].ToString();
            if (R67_OG.Text == "0") { R67_OG.Text = ""; }

            R68_OG.Text = OG_Matrix[5][7].ToString();
            if (R68_OG.Text == "0") { R68_OG.Text = ""; }

            R69_OG.Text = OG_Matrix[5][8].ToString();
            if (R69_OG.Text == "0") { R69_OG.Text = ""; }

            R71_OG.Text = OG_Matrix[6][0].ToString();
            if (R71_OG.Text == "0") { R71_OG.Text = ""; }

            R72_OG.Text = OG_Matrix[6][1].ToString();
            if (R72_OG.Text == "0") { R72_OG.Text = ""; }

            R73_OG.Text = OG_Matrix[6][2].ToString();
            if (R73_OG.Text == "0") { R73_OG.Text = ""; }

            R74_OG.Text = OG_Matrix[6][3].ToString();
            if (R74_OG.Text == "0") { R74_OG.Text = ""; }

            R75_OG.Text = OG_Matrix[6][4].ToString();
            if (R75_OG.Text == "0") { R75_OG.Text = ""; }

            R76_OG.Text = OG_Matrix[6][5].ToString();
            if (R76_OG.Text == "0") { R76_OG.Text = ""; }

            R77_OG.Text = OG_Matrix[6][6].ToString();
            if (R77_OG.Text == "0") { R77_OG.Text = ""; }

            R78_OG.Text = OG_Matrix[6][7].ToString();
            if (R78_OG.Text == "0") { R78_OG.Text = ""; }

            R79_OG.Text = OG_Matrix[6][8].ToString();
            if (R79_OG.Text == "0") { R79_OG.Text = ""; }

            R81_OG.Text = OG_Matrix[7][0].ToString();
            if (R81_OG.Text == "0") { R81_OG.Text = ""; }

            R82_OG.Text = OG_Matrix[7][1].ToString();
            if (R82_OG.Text == "0") { R82_OG.Text = ""; }

            R83_OG.Text = OG_Matrix[7][2].ToString();
            if (R83_OG.Text == "0") { R83_OG.Text = ""; }

            R84_OG.Text = OG_Matrix[7][3].ToString();
            if (R84_OG.Text == "0") { R84_OG.Text = ""; }

            R85_OG.Text = OG_Matrix[7][4].ToString();
            if (R85_OG.Text == "0") { R85_OG.Text = ""; }

            R86_OG.Text = OG_Matrix[7][5].ToString();
            if (R86_OG.Text == "0") { R86_OG.Text = ""; }

            R87_OG.Text = OG_Matrix[7][6].ToString();
            if (R87_OG.Text == "0") { R87_OG.Text = ""; }

            R88_OG.Text = OG_Matrix[7][7].ToString();
            if (R88_OG.Text == "0") { R88_OG.Text = ""; }

            R89_OG.Text = OG_Matrix[7][8].ToString();
            if (R89_OG.Text == "0") { R89_OG.Text = ""; }

            R91_OG.Text = OG_Matrix[8][0].ToString();
            if (R91_OG.Text == "0") { R91_OG.Text = ""; }

            R92_OG.Text = OG_Matrix[8][1].ToString();
            if (R92_OG.Text == "0") { R92_OG.Text = ""; }

            R93_OG.Text = OG_Matrix[8][2].ToString();
            if (R93_OG.Text == "0") { R93_OG.Text = ""; }

            R94_OG.Text = OG_Matrix[8][3].ToString();
            if (R94_OG.Text == "0") { R94_OG.Text = ""; }

            R95_OG.Text = OG_Matrix[8][4].ToString();
            if (R95_OG.Text == "0") { R95_OG.Text = ""; }

            R96_OG.Text = OG_Matrix[8][5].ToString();
            if (R96_OG.Text == "0") { R96_OG.Text = ""; }

            R97_OG.Text = OG_Matrix[8][6].ToString(); 
            if (R97_OG.Text == "0") { R97_OG.Text = ""; }

            R98_OG.Text = OG_Matrix[8][7].ToString();
            if (R98_OG.Text == "0") { R98_OG.Text = ""; }

            R99_OG.Text = OG_Matrix[8][8].ToString(); 
            if (R99_OG.Text == "0") { R99_OG.Text = ""; }

            R11.Text = new_Matrix[0][0].ToString();
            if (R11_OG.Text == "") { R11.Foreground = BlueBrush; }

            R12.Text = new_Matrix[0][1].ToString();
            if (R12_OG.Text == "") { R12.Foreground = BlueBrush; }

            R13.Text = new_Matrix[0][2].ToString();
            if (R13_OG.Text == "") { R13.Foreground = BlueBrush; }

            R14.Text = new_Matrix[0][3].ToString();
            if (R14_OG.Text == "") { R14.Foreground = BlueBrush; }

            R15.Text = new_Matrix[0][4].ToString();
            if (R15_OG.Text == "") { R15.Foreground = BlueBrush; }

            R16.Text = new_Matrix[0][5].ToString();
            if (R16_OG.Text == "") { R16.Foreground = BlueBrush; }

            R17.Text = new_Matrix[0][6].ToString();
            if (R17_OG.Text == "") { R17.Foreground = BlueBrush; }

            R18.Text = new_Matrix[0][7].ToString();
            if (R18_OG.Text == "") { R18.Foreground = BlueBrush; }

            R19.Text = new_Matrix[0][8].ToString();
            if (R19_OG.Text == "") { R19.Foreground = BlueBrush; }

            R21.Text = new_Matrix[1][0].ToString();
            if (R21_OG.Text == "") { R21.Foreground = BlueBrush; }

            R22.Text = new_Matrix[1][1].ToString();
            if (R22_OG.Text == "") { R22.Foreground = BlueBrush; }

            R23.Text = new_Matrix[1][2].ToString();
            if (R23_OG.Text == "") { R23.Foreground = BlueBrush; }

            R24.Text = new_Matrix[1][3].ToString();
            if (R24_OG.Text == "") { R24.Foreground = BlueBrush; }

            R25.Text = new_Matrix[1][4].ToString();
            if (R25_OG.Text == "") { R25.Foreground = BlueBrush; }

            R26.Text = new_Matrix[1][5].ToString();
            if (R26_OG.Text == "") { R26.Foreground = BlueBrush; }

            R27.Text = new_Matrix[1][6].ToString();
            if (R27_OG.Text == "") { R27.Foreground = BlueBrush; }

            R28.Text = new_Matrix[1][7].ToString();
            if (R28_OG.Text == "") { R28.Foreground = BlueBrush; }

            R29.Text = new_Matrix[1][8].ToString();
            if (R29_OG.Text == "") { R29.Foreground = BlueBrush; }

            R31.Text = new_Matrix[2][0].ToString();
            if (R31_OG.Text == "") { R31.Foreground = BlueBrush; }

            R32.Text = new_Matrix[2][1].ToString();
            if (R32_OG.Text == "") { R32.Foreground = BlueBrush; }

            R33.Text = new_Matrix[2][2].ToString();
            if (R33_OG.Text == "") { R33.Foreground = BlueBrush; }

            R34.Text = new_Matrix[2][3].ToString();
            if (R34_OG.Text == "") { R34.Foreground = BlueBrush; }

            R35.Text = new_Matrix[2][4].ToString();
            if (R35_OG.Text == "") { R35.Foreground = BlueBrush; }

            R36.Text = new_Matrix[2][5].ToString();
            if (R36_OG.Text == "") { R36.Foreground = BlueBrush; }

            R37.Text = new_Matrix[2][6].ToString();
            if (R37_OG.Text == "") { R37.Foreground = BlueBrush; }

            R38.Text = new_Matrix[2][7].ToString();
            if (R38_OG.Text == "") { R38.Foreground = BlueBrush; }

            R39.Text = new_Matrix[2][8].ToString();
            if (R39_OG.Text == "") { R39.Foreground = BlueBrush; }

            R41.Text = new_Matrix[3][0].ToString();
            if (R41_OG.Text == "") { R41.Foreground = BlueBrush; }

            R42.Text = new_Matrix[3][1].ToString();
            if (R42_OG.Text == "") { R42.Foreground = BlueBrush; }

            R43.Text = new_Matrix[3][2].ToString();
            if (R43_OG.Text == "") { R43.Foreground = BlueBrush; }

            R44.Text = new_Matrix[3][3].ToString();
            if (R44_OG.Text == "") { R44.Foreground = BlueBrush; }

            R45.Text = new_Matrix[3][4].ToString();
            if (R45_OG.Text == "") { R45.Foreground = BlueBrush; }

            R46.Text = new_Matrix[3][5].ToString();
            if (R46_OG.Text == "") { R46.Foreground = BlueBrush; }

            R47.Text = new_Matrix[3][6].ToString();
            if (R47_OG.Text == "") { R47.Foreground = BlueBrush; }

            R48.Text = new_Matrix[3][7].ToString();
            if (R48_OG.Text == "") { R48.Foreground = BlueBrush; }

            R49.Text = new_Matrix[3][8].ToString();
            if (R49_OG.Text == "") { R49.Foreground = BlueBrush; }

            R51.Text = new_Matrix[4][0].ToString();
            if (R51_OG.Text == "") { R51.Foreground = BlueBrush; }

            R52.Text = new_Matrix[4][1].ToString();
            if (R52_OG.Text == "") { R52.Foreground = BlueBrush; }

            R53.Text = new_Matrix[4][2].ToString();
            if (R53_OG.Text == "") { R53.Foreground = BlueBrush; }

            R54.Text = new_Matrix[4][3].ToString();
            if (R54_OG.Text == "") { R54.Foreground = BlueBrush; }

            R55.Text = new_Matrix[4][4].ToString();
            if (R55_OG.Text == "") { R55.Foreground = BlueBrush; }

            R56.Text = new_Matrix[4][5].ToString();
            if (R56_OG.Text == "") { R56.Foreground = BlueBrush; }

            R57.Text = new_Matrix[4][6].ToString();
            if (R57_OG.Text == "") { R57.Foreground = BlueBrush; }

            R58.Text = new_Matrix[4][7].ToString();
            if (R58_OG.Text == "") { R58.Foreground = BlueBrush; }

            R59.Text = new_Matrix[4][8].ToString();
            if (R59_OG.Text == "") { R59.Foreground = BlueBrush; }

            R61.Text = new_Matrix[5][0].ToString();
            if (R61_OG.Text == "") { R61.Foreground = BlueBrush; }

            R62.Text = new_Matrix[5][1].ToString();
            if (R62_OG.Text == "") { R62.Foreground = BlueBrush; }

            R63.Text = new_Matrix[5][2].ToString();
            if (R63_OG.Text == "") { R63.Foreground = BlueBrush; }

            R64.Text = new_Matrix[5][3].ToString(); 
            if (R64_OG.Text == "") { R64.Foreground = BlueBrush; }

            R65.Text = new_Matrix[5][4].ToString();
            if (R65_OG.Text == "") { R65.Foreground = BlueBrush; }

            R66.Text = new_Matrix[5][5].ToString();
            if (R66_OG.Text == "") { R66.Foreground = BlueBrush; }

            R67.Text = new_Matrix[5][6].ToString();
            if (R67_OG.Text == "") { R67.Foreground = BlueBrush; }

            R68.Text = new_Matrix[5][7].ToString();
            if (R68_OG.Text == "") { R68.Foreground = BlueBrush; }

            R69.Text = new_Matrix[5][8].ToString();
            if (R69_OG.Text == "") { R69.Foreground = BlueBrush; }

            R71.Text = new_Matrix[6][0].ToString();
            if (R71_OG.Text == "") { R71.Foreground = BlueBrush; }

            R72.Text = new_Matrix[6][1].ToString();
            if (R72_OG.Text == "") { R72.Foreground = BlueBrush; }

            R73.Text = new_Matrix[6][2].ToString();
            if (R73_OG.Text == "") { R73.Foreground = BlueBrush; }

            R74.Text = new_Matrix[6][3].ToString();
            if (R74_OG.Text == "") { R74.Foreground = BlueBrush; }

            R75.Text = new_Matrix[6][4].ToString(); 
            if (R75_OG.Text == "") { R75.Foreground = BlueBrush; }

            R76.Text = new_Matrix[6][5].ToString();
            if (R76_OG.Text == "") { R76.Foreground = BlueBrush; }

            R77.Text = new_Matrix[6][6].ToString();
            if (R77_OG.Text == "") { R77.Foreground = BlueBrush; }

            R78.Text = new_Matrix[6][7].ToString();
            if (R78_OG.Text == "") { R78.Foreground = BlueBrush; }

            R79.Text = new_Matrix[6][8].ToString();
            if (R79_OG.Text == "") { R79.Foreground = BlueBrush; }

            R81.Text = new_Matrix[7][0].ToString();
            if (R81_OG.Text == "") { R81.Foreground = BlueBrush; }

            R82.Text = new_Matrix[7][1].ToString();
            if (R82_OG.Text == "") { R82.Foreground = BlueBrush; }

            R83.Text = new_Matrix[7][2].ToString();
            if (R83_OG.Text == "") { R83.Foreground = BlueBrush; }

            R84.Text = new_Matrix[7][3].ToString();
            if (R84_OG.Text == "") { R84.Foreground = BlueBrush; }

            R85.Text = new_Matrix[7][4].ToString();
            if (R85_OG.Text == "") { R85.Foreground = BlueBrush; }

            R86.Text = new_Matrix[7][5].ToString();
            if (R86_OG.Text == "") { R86.Foreground = BlueBrush; }

            R87.Text = new_Matrix[7][6].ToString();
            if (R87_OG.Text == "") { R87.Foreground = BlueBrush; }

            R88.Text = new_Matrix[7][7].ToString();
            if (R88_OG.Text == "") { R88.Foreground = BlueBrush; }

            R89.Text = new_Matrix[7][8].ToString();
            if (R89_OG.Text == "") { R89.Foreground = BlueBrush; }

            R91.Text = new_Matrix[8][0].ToString();
            if (R91_OG.Text == "") { R91.Foreground = BlueBrush; }

            R92.Text = new_Matrix[8][1].ToString(); 
            if (R92_OG.Text == "") { R92.Foreground = BlueBrush; }

            R93.Text = new_Matrix[8][2].ToString();
            if (R93_OG.Text == "") { R93.Foreground = BlueBrush; }

            R94.Text = new_Matrix[8][3].ToString();
            if (R94_OG.Text == "") { R94.Foreground = BlueBrush; }

            R95.Text = new_Matrix[8][4].ToString();
            if (R95_OG.Text == "") { R95.Foreground = BlueBrush; }

            R96.Text = new_Matrix[8][5].ToString();
            if (R96_OG.Text == "") { R96.Foreground = BlueBrush; }

            R97.Text = new_Matrix[8][6].ToString();
            if (R97_OG.Text == "") { R97.Foreground = BlueBrush; }

            R98.Text = new_Matrix[8][7].ToString();
            if (R98_OG.Text == "") { R98.Foreground = BlueBrush; }

            R99.Text = new_Matrix[8][8].ToString();
            if (R99_OG.Text == "") { R99.Foreground = BlueBrush; }
        }
    }
}
