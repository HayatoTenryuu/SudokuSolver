using Microsoft.VisualBasic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (((TextBox)sender).Text)        // Limit the characters to 1-9 only (Textbox set to single character entry, so "10" isn't a concern).
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    ((TextBox)sender).SelectAll();
                    break;
                default:
                    ((TextBox)sender).Text = "";
                    break;
            }

            if (((TextBox)sender).Text != "")
            {
                KeyEventArgs Tab_key = new KeyEventArgs(Keyboard.PrimaryDevice, Keyboard.PrimaryDevice.ActiveSource, 0, Key.Tab) { RoutedEvent = Keyboard.KeyDownEvent };
                InputManager.Current.ProcessInput(Tab_key);
            }

        }

        private void Background_TextChanged(object sender, TextChangedEventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        public void Solve_Button_Click(object sender, RoutedEventArgs e)
        {

            /* --------------------------------
             * Step 0: Get access to our tools.
             --------------------------------*/

            Machinery Machine = new Machinery();

            /* ----------------------------------------------------
             * Step 1: Set up the initial Matrix, as a set of Rows.
             ----------------------------------------------------*/

            Machinery.Rows rowset = new Machinery.Rows();
            int rando = 0;

            int[] ra1 = [ Int32.TryParse(R11.Text, out rando) ? Int32.Parse(R11.Text) : 0, 
                        Int32.TryParse(R12.Text, out rando) ? Int32.Parse(R12.Text) : 0, 
                        Int32.TryParse(R13.Text, out rando) ? Int32.Parse(R13.Text) : 0,
                        Int32.TryParse(R14.Text, out rando) ? Int32.Parse(R14.Text) : 0,
                        Int32.TryParse(R15.Text, out rando) ? Int32.Parse(R15.Text) : 0,
                        Int32.TryParse(R16.Text, out rando) ? Int32.Parse(R16.Text) : 0,
                        Int32.TryParse(R17.Text, out rando) ? Int32.Parse(R17.Text) : 0,
                        Int32.TryParse(R18.Text, out rando) ? Int32.Parse(R18.Text) : 0,
                        Int32.TryParse(R19.Text, out rando) ? Int32.Parse(R19.Text) : 0];
            rowset.setrows(0,ra1);

            int[] ra2 = [Int32.TryParse(R21.Text, out rando) ? Int32.Parse(R21.Text) : 0,
                        Int32.TryParse(R22.Text, out rando) ? Int32.Parse(R22.Text) : 0,
                        Int32.TryParse(R23.Text, out rando) ? Int32.Parse(R23.Text) : 0,
                        Int32.TryParse(R24.Text, out rando) ? Int32.Parse(R24.Text) : 0,
                        Int32.TryParse(R25.Text, out rando) ? Int32.Parse(R25.Text) : 0,
                        Int32.TryParse(R26.Text, out rando) ? Int32.Parse(R26.Text) : 0,
                        Int32.TryParse(R27.Text, out rando) ? Int32.Parse(R27.Text) : 0,
                        Int32.TryParse(R28.Text, out rando) ? Int32.Parse(R28.Text) : 0,
                        Int32.TryParse(R29.Text, out rando) ? Int32.Parse(R29.Text) : 0];
            rowset.setrows(1, ra2);

            int[] ra3 = [Int32.TryParse(R31.Text, out rando) ? Int32.Parse(R31.Text) : 0,
                        Int32.TryParse(R32.Text, out rando) ? Int32.Parse(R32.Text) : 0,
                        Int32.TryParse(R33.Text, out rando) ? Int32.Parse(R33.Text) : 0,
                        Int32.TryParse(R34.Text, out rando) ? Int32.Parse(R34.Text) : 0,
                        Int32.TryParse(R35.Text, out rando) ? Int32.Parse(R35.Text) : 0,
                        Int32.TryParse(R36.Text, out rando) ? Int32.Parse(R36.Text) : 0,
                        Int32.TryParse(R37.Text, out rando) ? Int32.Parse(R37.Text) : 0,
                        Int32.TryParse(R38.Text, out rando) ? Int32.Parse(R38.Text) : 0,
                        Int32.TryParse(R39.Text, out rando) ? Int32.Parse(R39.Text) : 0];
            rowset.setrows(2, ra3);

            int[] ra4 = [Int32.TryParse(R41.Text, out rando) ? Int32.Parse(R41.Text) : 0,
                        Int32.TryParse(R42.Text, out rando) ? Int32.Parse(R42.Text) : 0,
                        Int32.TryParse(R43.Text, out rando) ? Int32.Parse(R43.Text) : 0,
                        Int32.TryParse(R44.Text, out rando) ? Int32.Parse(R44.Text) : 0,
                        Int32.TryParse(R45.Text, out rando) ? Int32.Parse(R45.Text) : 0,
                        Int32.TryParse(R46.Text, out rando) ? Int32.Parse(R46.Text) : 0,
                        Int32.TryParse(R47.Text, out rando) ? Int32.Parse(R47.Text) : 0,
                        Int32.TryParse(R48.Text, out rando) ? Int32.Parse(R48.Text) : 0,
                        Int32.TryParse(R49.Text, out rando) ? Int32.Parse(R49.Text) : 0];
            rowset.setrows(3, ra4);

            int[] ra5 = [Int32.TryParse(R51.Text, out rando) ? Int32.Parse(R51.Text) : 0,
                        Int32.TryParse(R52.Text, out rando) ? Int32.Parse(R52.Text) : 0,
                        Int32.TryParse(R53.Text, out rando) ? Int32.Parse(R53.Text) : 0,
                        Int32.TryParse(R54.Text, out rando) ? Int32.Parse(R54.Text) : 0,
                        Int32.TryParse(R55.Text, out rando) ? Int32.Parse(R55.Text) : 0,
                        Int32.TryParse(R56.Text, out rando) ? Int32.Parse(R56.Text) : 0,
                        Int32.TryParse(R57.Text, out rando) ? Int32.Parse(R57.Text) : 0,
                        Int32.TryParse(R58.Text, out rando) ? Int32.Parse(R58.Text) : 0,
                        Int32.TryParse(R59.Text, out rando) ? Int32.Parse(R59.Text) : 0];
            rowset.setrows(4, ra5);

            int[] ra6 = [Int32.TryParse(R61.Text, out rando) ? Int32.Parse(R61.Text) : 0,
                        Int32.TryParse(R62.Text, out rando) ? Int32.Parse(R62.Text) : 0,
                        Int32.TryParse(R63.Text, out rando) ? Int32.Parse(R63.Text) : 0,
                        Int32.TryParse(R64.Text, out rando) ? Int32.Parse(R64.Text) : 0,
                        Int32.TryParse(R65.Text, out rando) ? Int32.Parse(R65.Text) : 0,
                        Int32.TryParse(R66.Text, out rando) ? Int32.Parse(R66.Text) : 0,
                        Int32.TryParse(R67.Text, out rando) ? Int32.Parse(R67.Text) : 0,
                        Int32.TryParse(R68.Text, out rando) ? Int32.Parse(R68.Text) : 0,
                        Int32.TryParse(R69.Text, out rando) ? Int32.Parse(R69.Text) : 0];
            rowset.setrows(5, ra6);

            int[] ra7 = [Int32.TryParse(R71.Text, out rando) ? Int32.Parse(R71.Text) : 0,
                        Int32.TryParse(R72.Text, out rando) ? Int32.Parse(R72.Text) : 0,
                        Int32.TryParse(R73.Text, out rando) ? Int32.Parse(R73.Text) : 0,
                        Int32.TryParse(R74.Text, out rando) ? Int32.Parse(R74.Text) : 0,
                        Int32.TryParse(R75.Text, out rando) ? Int32.Parse(R75.Text) : 0,
                        Int32.TryParse(R76.Text, out rando) ? Int32.Parse(R76.Text) : 0,
                        Int32.TryParse(R77.Text, out rando) ? Int32.Parse(R77.Text) : 0,
                        Int32.TryParse(R78.Text, out rando) ? Int32.Parse(R78.Text) : 0,
                        Int32.TryParse(R79.Text, out rando) ? Int32.Parse(R79.Text) : 0];
            rowset.setrows(6, ra7);

            int[] ra8 = [Int32.TryParse(R81.Text, out rando) ? Int32.Parse(R81.Text) : 0,
                        Int32.TryParse(R82.Text, out rando) ? Int32.Parse(R82.Text) : 0,
                        Int32.TryParse(R83.Text, out rando) ? Int32.Parse(R83.Text) : 0,
                        Int32.TryParse(R84.Text, out rando) ? Int32.Parse(R84.Text) : 0,
                        Int32.TryParse(R85.Text, out rando) ? Int32.Parse(R85.Text) : 0,
                        Int32.TryParse(R86.Text, out rando) ? Int32.Parse(R86.Text) : 0,
                        Int32.TryParse(R87.Text, out rando) ? Int32.Parse(R87.Text) : 0,
                        Int32.TryParse(R88.Text, out rando) ? Int32.Parse(R88.Text) : 0,
                        Int32.TryParse(R89.Text, out rando) ? Int32.Parse(R89.Text) : 0];
            rowset.setrows(7, ra8);

            int[] ra9 = [Int32.TryParse(R91.Text, out rando) ? Int32.Parse(R91.Text) : 0,
                        Int32.TryParse(R92.Text, out rando) ? Int32.Parse(R92.Text) : 0,
                        Int32.TryParse(R93.Text, out rando) ? Int32.Parse(R93.Text) : 0,
                        Int32.TryParse(R94.Text, out rando) ? Int32.Parse(R94.Text) : 0,
                        Int32.TryParse(R95.Text, out rando) ? Int32.Parse(R95.Text) : 0,
                        Int32.TryParse(R96.Text, out rando) ? Int32.Parse(R96.Text) : 0,
                        Int32.TryParse(R97.Text, out rando) ? Int32.Parse(R97.Text) : 0,
                        Int32.TryParse(R98.Text, out rando) ? Int32.Parse(R98.Text) : 0,
                        Int32.TryParse(R99.Text, out rando) ? Int32.Parse(R99.Text) : 0];
            rowset.setrows(8, ra9);


            /*--------------------------------------------
             * Step 2: Create Columns and Boxes from Rows.
             -------------------------------------------*/

            Machinery.Cols colset = new Machinery.Cols();
            colset = Machine.rows_to_cols(colset, rowset.getmatrix());

            Machinery.Boxs boxset = new Machinery.Boxs();
            boxset = Machine.rows_to_boxs(boxset, rowset.getmatrix());

            /*------------------------------------------------
             * Step 3: Create Dummy Matrix for the Final Page.
             -----------------------------------------------*/

            Machinery.Rows original_rowset = new Machinery.Rows();
            original_rowset = Machine.cols_to_rows(original_rowset, colset.getmatrix());

            /*----------------------
             * Step 4: Try to Solve.
             ---------------------*/

            try
            {
                bool a = false;
                bool b = false;
                bool c = false;
                int x = 0;
                int y = 0;
                int z = 0;

                bool checker = false;
                int loop_counter = 0;
                int[][] matrix = new int[9][];

                do
                {
                    for (int i = 0; i < 9; i++)
                    {
                        (a, x) = Machine.basic_value_insert(rowset.getrows(i));
                        if (a == true)
                        {
                            colset = Machine.rows_to_cols(colset, rowset.getmatrix());
                            boxset = Machine.rows_to_boxs(boxset, rowset.getmatrix());
                            break;
                        }
                    }

                    for (int i = 0; i < 9; i++)
                    {
                        (b, y) = Machine.basic_value_insert(colset.getcols(i));
                        if (b == true)
                        {
                            boxset = Machine.cols_to_boxs(boxset, colset.getmatrix());
                            rowset = Machine.cols_to_rows(rowset, colset.getmatrix());
                            break;
                        }
                    }

                    for (int i = 0; i < 9; i++)
                    {
                        (c, z) = Machine.basic_value_insert(boxset.getboxs(i));
                        if (c == true)
                        {
                            rowset = Machine.boxs_to_rows(rowset, boxset.getmatrix());
                            colset = Machine.boxs_to_cols(colset, boxset.getmatrix());
                            break;
                        }
                    }

                    (bool act, int[][] return_matrix) = Machine.basic_value_solving(rowset.getmatrix(), colset.getmatrix(), boxset.getmatrix());

                    for (int i = 0; i < 9; i++)
                    {
                        rowset.setrows(i, return_matrix[i]);
                    }

                    if (act == true)
                    {
                        colset = Machine.rows_to_cols(colset, rowset.getmatrix());
                        boxset = Machine.rows_to_boxs(boxset, rowset.getmatrix());
                    }
                    else
                    {
                        (act, matrix) = Machine.intermediate_value_solving(rowset.getmatrix(), colset.getmatrix(), boxset.getmatrix());
                        for (int i = 0; i < 9; i++)
                        {
                            rowset.setrows(i, matrix[i]);
                        }
                    }

                    if (act == true)
                    {
                        colset = Machine.rows_to_cols(colset, rowset.getmatrix());
                        boxset = Machine.rows_to_boxs(boxset, rowset.getmatrix());
                    }
                    else
                    {
                        (act, matrix) = Machine.advanced_value_solving(rowset.getmatrix(), colset.getmatrix(), boxset.getmatrix());
                        for (int i = 0; i < 9; i++)
                        {
                            rowset.setrows(i, matrix[i]);
                        }
                    }

                    checker = (Machine.has_zeros(rowset.getrows(0)) || Machine.has_zeros(rowset.getrows(1)) ||
                               Machine.has_zeros(rowset.getrows(2)) || Machine.has_zeros(rowset.getrows(3)) ||
                               Machine.has_zeros(rowset.getrows(4)) || Machine.has_zeros(rowset.getrows(5)) ||
                               Machine.has_zeros(rowset.getrows(6)) || Machine.has_zeros(rowset.getrows(7)) ||
                               Machine.has_zeros(rowset.getrows(8)));

                    loop_counter++;
                    
                    /* MessageBox.Show(loop_counter.ToString()); */ 
                    
                    if (loop_counter > 1000)
                    {
                        throw new Exception("I cannot solve this.");
                    }

                    /*rowset.printrows(rowset.getrows(0));
                    rowset.printrows(rowset.getrows(1));
                    rowset.printrows(rowset.getrows(2));
                    rowset.printrows(rowset.getrows(3));
                    rowset.printrows(rowset.getrows(4));
                    rowset.printrows(rowset.getrows(5));
                    rowset.printrows(rowset.getrows(6));
                    rowset.printrows(rowset.getrows(7));
                    rowset.printrows(rowset.getrows(8));*/
                }
                while (checker);

                MessageBox.Show("All Done!");

                FinalWindow ending = new FinalWindow(original_rowset, rowset);
                ending.Height = 540;
                ending.Width = 1020;
                ending.Show();
                ending.Activate();

                R11.Text = "";
                R12.Text = "";
                R13.Text = "";
                R14.Text = "";
                R15.Text = "";
                R16.Text = "";
                R17.Text = "";
                R18.Text = "";
                R19.Text = "";
                R21.Text = "";
                R22.Text = "";
                R23.Text = "";
                R24.Text = "";
                R25.Text = "";
                R26.Text = "";
                R27.Text = "";
                R28.Text = "";
                R29.Text = "";
                R31.Text = "";
                R32.Text = "";
                R33.Text = "";
                R34.Text = "";
                R35.Text = "";
                R36.Text = "";
                R37.Text = "";
                R38.Text = "";
                R39.Text = "";
                R41.Text = "";
                R42.Text = "";
                R43.Text = "";
                R44.Text = "";
                R45.Text = "";
                R46.Text = "";
                R47.Text = "";
                R48.Text = "";
                R49.Text = "";
                R51.Text = "";
                R52.Text = "";
                R53.Text = "";
                R54.Text = "";
                R55.Text = "";
                R56.Text = "";
                R57.Text = "";
                R58.Text = "";
                R59.Text = "";
                R61.Text = "";
                R62.Text = "";
                R63.Text = "";
                R64.Text = "";
                R65.Text = "";
                R66.Text = "";
                R67.Text = "";
                R68.Text = "";
                R69.Text = "";
                R71.Text = "";
                R72.Text = "";
                R73.Text = "";
                R74.Text = "";
                R75.Text = "";
                R76.Text = "";
                R77.Text = "";
                R78.Text = "";
                R79.Text = "";
                R81.Text = "";
                R82.Text = "";
                R83.Text = "";
                R84.Text = "";
                R85.Text = "";
                R86.Text = "";
                R87.Text = "";
                R88.Text = "";
                R89.Text = "";
                R91.Text = "";
                R92.Text = "";
                R93.Text = "";
                R94.Text = "";
                R95.Text = "";
                R96.Text = "";
                R97.Text = "";
                R98.Text = "";
                R99.Text = "";
            }

            catch (Exception ex) 
            {
                MessageBox.Show("Something has gone wrong, please contact your local administrator for help.\n\n" +
                    "Error Message: " + ex);
                MessageBox.Show("Also, please be sure you typed in the problem correctly, because I can't solve unsolvable problems.");

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Insert the Sudoku puzzle you would like solved.\n\n" +
                "You can either click the individual squares you want to fill in, " +
                "or you can start at the top left square and tab through them all. " +
                "When you type a number, it will auto-tab for you to speed up and simplify the process.\n\n" +
                "Any numbers you don't know just leave blank.\n\n" +
                "There are some advanced puzzles this solver can't solve, so if you " +
                "have an error pop up, you will need to solve the puzzle by hand or wait until the next release to try again.", "Help");   
        }
    }
}