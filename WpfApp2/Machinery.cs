using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    public class Machinery
    {
        /*------------------------------------------------------------------------------------------------------------------------*/
        /* Class Definitions */
        /*------------------------------------------------------------------------------------------------------------------------*/

        public class Rows
        {

            private int[] row1 = new int[9];
            private int[] row2 = new int[9];
            private int[] row3 = new int[9];
            private int[] row4 = new int[9];
            private int[] row5 = new int[9];
            private int[] row6 = new int[9];
            private int[] row7 = new int[9];
            private int[] row8 = new int[9];
            private int[] row9 = new int[9];

            public void setrows(int row_num, int[] row_with_num)
                    {          
                        int i = 0;
                        switch (row_num+1)
                        {
                            case 1:
                                while (i < 9)
                                {
                                    row1[i] = row_with_num[i];
                                    i += 1;
                                }
                                break;
                            case 2:
                                while (i < 9)
                                {
                                    row2[i] = row_with_num[i];
                                    i += 1;
                                }
                                break;
                            case 3:
                                while (i < 9)
                                {
                                    row3[i] = row_with_num[i];
                                    i += 1;
                                }
                                break;
                            case 4:
                                while (i < 9)
                                {
                                    row4[i] = row_with_num[i];
                                    i += 1;
                                }
                                break;
                            case 5:
                                while (i < 9)
                                {
                                    row5[i] = row_with_num[i];
                                    i += 1;
                                }
                                break;
                            case 6:
                                while (i < 9)
                                {
                                    row6[i] = row_with_num[i];
                                    i += 1;
                                }
                                break;
                            case 7:
                                while (i < 9)
                                {
                                    row7[i] = row_with_num[i];
                                    i += 1;
                                }
                                break;
                            case 8:
                                while (i < 9)
                                {
                                    row8[i] = row_with_num[i];
                                    i += 1;
                                }
                                break;
                            case 9:
                                while (i < 9)
                                {
                                    row9[i] = row_with_num[i];
                                    i += 1;
                                }
                                break;
                            default:
                                MessageBox.Show("Something went wrong in Rows.\n");
                                break;
                        }

                    }
            public int[] getrows(int row_num)
            {                                 
                switch (row_num+1)
                {
                    case 1:
                        return row1;
                    case 2:
                        return row2;
                    case 3:
                        return row3;
                    case 4:
                        return row4;
                    case 5:
                        return row5;
                    case 6:
                        return row6;
                    case 7:
                        return row7;
                    case 8:
                        return row8;
                    case 9:
                        return row9;
                    default:
                        MessageBox.Show("This is not good...RWOS\n");
                        return [0];
                }
            }
            public void printrows(int[] row_to_print)
            {                       
                MessageBox.Show(row_to_print[0] + "\n" +
                                row_to_print[1] + "\n" +
                                row_to_print[2] + "\n" +
                                row_to_print[3] + "\n" +
                                row_to_print[4] + "\n" +
                                row_to_print[5] + "\n" +
                                row_to_print[6] + "\n" +
                                row_to_print[7] + "\n" +
                                row_to_print[8] + "\n" +
                                "\nThe end!\n");
            }
            public int[][] getmatrix()
            {
                int[][] matrix = { row1, row2, row3, row4, row5, row6, row7, row8, row9 };
                return matrix;
            }
            public bool has_number(int number, int[] row_with_number) 
            {
                for (int i = 0; i < 9; i++) 
                { 
                    if (number == row_with_number[i])
                    {
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }

                return false;
            }
        };

        public class Cols
        {

            private int[] col1 = new int[9];
            private int[] col2 = new int[9];
            private int[] col3 = new int[9];
            private int[] col4 = new int[9];
            private int[] col5 = new int[9];
            private int[] col6 = new int[9];
            private int[] col7 = new int[9];
            private int[] col8 = new int[9];
            private int[] col9 = new int[9];

            public void setcols(int col_num, int[] col_with_num)
            {                                                           
                int i = 0;
                switch (col_num+1)
                {
                    case 1:
                        while (i < 9)
                        {
                            col1[i] = col_with_num[i];
                            i += 1;
                        }
                        break;
                    case 2:
                        while (i < 9)
                        {
                            col2[i] = col_with_num[i];
                            i += 1;
                        }
                        break;
                    case 3:
                        while (i < 9)
                        {
                            col3[i] = col_with_num[i];
                            i += 1;
                        }
                        break;
                    case 4:
                        while (i < 9)
                        {
                            col4[i] = col_with_num[i];
                            i += 1;
                        }
                        break;
                    case 5:
                        while (i < 9)
                        {
                            col5[i] = col_with_num[i];
                            i += 1;
                        }
                        break;
                    case 6:
                        while (i < 9)
                        {
                            col6[i] = col_with_num[i];
                            i += 1;
                        }
                        break;
                    case 7:
                        while (i < 9)
                        {
                            col7[i] = col_with_num[i];
                            i += 1;
                        }
                        break;
                    case 8:
                        while (i < 9)
                        {
                            col8[i] = col_with_num[i];
                            i += 1;
                        }
                        break;
                    case 9:
                        while (i < 9)
                        {
                            col9[i] = col_with_num[i];
                            i += 1;
                        }
                        break;
                    default:
                        MessageBox.Show("Something went wrong in Columns.\n");
                        break;
                }
            }
            public int[] getcols(int col_num)
            {                                 
                switch (col_num+1)
                {
                    case 1:
                        return col1;
                    case 2:
                        return col2;
                    case 3:
                        return col3;
                    case 4:
                        return col4;
                    case 5:
                        return col5;
                    case 6:
                        return col6;
                    case 7:
                        return col7;
                    case 8:
                        return col8;
                    case 9:
                        return col9;
                    default:
                        MessageBox.Show("This is not good...COLS\n");
                        return [0];
                }
            }
            public void printcols(int[] col_to_print)
            {                      
                MessageBox.Show(col_to_print[0] + "\n" +
                                col_to_print[1] + "\n" +
                                col_to_print[2] + "\n" +
                                col_to_print[3] + "\n" +
                                col_to_print[4] + "\n" +
                                col_to_print[5] + "\n" +
                                col_to_print[6] + "\n" +
                                col_to_print[7] + "\n" +
                                col_to_print[8] + "\n" +
                                "\nThe end!\n");
            }
            public int[][] getmatrix()
            {
                int[][] matrix = { col1, col2, col3, col4, col5, col6, col7, col8, col9 };
                return matrix;
            }
            public bool has_number(int number, int[] col_with_number)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (number == col_with_number[i])
                    {
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }

                return false;
            }
        };

        public class Boxs
        {

            private int[] box1 = new int[9];
            private int[] box2 = new int[9];
            private int[] box3 = new int[9];
            private int[] box4 = new int[9];
            private int[] box5 = new int[9];
            private int[] box6 = new int[9];
            private int[] box7 = new int[9];
            private int[] box8 = new int[9];
            private int[] box9 = new int[9];

            public void setboxs(int box_num, int[] box_with_num)
            {           
                int i = 0;
                switch (box_num+1)
                {
                    case 1:
                        while (i < 9)
                        {
                            box1[i] = box_with_num[i];
                            i += 1;
                        }
                        break;
                    case 2:
                        while (i < 9)
                        {
                            box2[i] = box_with_num[i];
                            i += 1;
                        }
                        break;
                    case 3:
                        while (i < 9)
                        {
                            box3[i] = box_with_num[i];
                            i += 1;
                        }
                        break;
                    case 4:
                        while (i < 9)
                        {
                            box4[i] = box_with_num[i];
                            i += 1;
                        }
                        break;
                    case 5:
                        while (i < 9)
                        {
                            box5[i] = box_with_num[i];
                            i += 1;
                        }
                        break;
                    case 6:
                        while (i < 9)
                        {
                            box6[i] = box_with_num[i];
                            i += 1;
                        }
                        break;
                    case 7:
                        while (i < 9)
                        {
                            box7[i] = box_with_num[i];
                            i += 1;
                        }
                        break;
                    case 8:
                        while (i < 9)
                        {
                            box8[i] = box_with_num[i];
                            i += 1;
                        }
                        break;
                    case 9:
                        while (i < 9)
                        {
                            box9[i] = box_with_num[i];
                            i += 1;
                        }
                        break;
                    default:
                        MessageBox.Show("Something went wrong in Boxes.\n");
                        break;
                }
            }
            public int[] getboxs(int box_num)
            {                                 
                switch (box_num+1)
                {
                    case 1:
                        return box1;
                    case 2:
                        return box2;
                    case 3:
                        return box3;
                    case 4:
                        return box4;
                    case 5:
                        return box5;
                    case 6:
                        return box6;
                    case 7:
                        return box7;
                    case 8:
                        return box8;
                    case 9:
                        return box9;
                    default:
                        MessageBox.Show("This is not good...BOXS\n");
                        return [0];
                }
            }
            public void printboxs(int[] box_to_print)
            {
                MessageBox.Show(box_to_print[0] + "\n" +
                                box_to_print[1] + "\n" +
                                box_to_print[2] + "\n" +
                                box_to_print[3] + "\n" +
                                box_to_print[4] + "\n" +
                                box_to_print[5] + "\n" +
                                box_to_print[6] + "\n" +
                                box_to_print[7] + "\n" +
                                box_to_print[8] + "\n" +
                                "\nThe end!\n");
            }
            public int[][] getmatrix()
            {
                int[][] matrix = { box1, box2, box3, box4, box5, box6, box7, box8, box9 };
                return matrix;
            }
            public bool has_number(int number, int[] box_with_number)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (number == box_with_number[i])
                    {
                        return true;
                    }
                    else
                    {
                        continue;
                    }
                }

                return false;
            }
        };

        /*------------------------------------------------------------------------------------------------------------------------*/
        /* Conversion Functions */
        /*------------------------------------------------------------------------------------------------------------------------*/

        public Cols rows_to_cols(Cols pcol, int[][] row_matrix)
        {
            int[] newcol1 = { row_matrix[0][0], row_matrix[1][0], row_matrix[2][0], row_matrix[3][0], row_matrix[4][0], row_matrix[5][0], row_matrix[6][0], row_matrix[7][0], row_matrix[8][0] };
            int[] newcol2 = { row_matrix[0][1], row_matrix[1][1], row_matrix[2][1], row_matrix[3][1], row_matrix[4][1], row_matrix[5][1], row_matrix[6][1], row_matrix[7][1], row_matrix[8][1] };
            int[] newcol3 = { row_matrix[0][2], row_matrix[1][2], row_matrix[2][2], row_matrix[3][2], row_matrix[4][2], row_matrix[5][2], row_matrix[6][2], row_matrix[7][2], row_matrix[8][2] };
            int[] newcol4 = { row_matrix[0][3], row_matrix[1][3], row_matrix[2][3], row_matrix[3][3], row_matrix[4][3], row_matrix[5][3], row_matrix[6][3], row_matrix[7][3], row_matrix[8][3] };
            int[] newcol5 = { row_matrix[0][4], row_matrix[1][4], row_matrix[2][4], row_matrix[3][4], row_matrix[4][4], row_matrix[5][4], row_matrix[6][4], row_matrix[7][4], row_matrix[8][4] };
            int[] newcol6 = { row_matrix[0][5], row_matrix[1][5], row_matrix[2][5], row_matrix[3][5], row_matrix[4][5], row_matrix[5][5], row_matrix[6][5], row_matrix[7][5], row_matrix[8][5] };
            int[] newcol7 = { row_matrix[0][6], row_matrix[1][6], row_matrix[2][6], row_matrix[3][6], row_matrix[4][6], row_matrix[5][6], row_matrix[6][6], row_matrix[7][6], row_matrix[8][6] };
            int[] newcol8 = { row_matrix[0][7], row_matrix[1][7], row_matrix[2][7], row_matrix[3][7], row_matrix[4][7], row_matrix[5][7], row_matrix[6][7], row_matrix[7][7], row_matrix[8][7] };
            int[] newcol9 = { row_matrix[0][8], row_matrix[1][8], row_matrix[2][8], row_matrix[3][8], row_matrix[4][8], row_matrix[5][8], row_matrix[6][8], row_matrix[7][8], row_matrix[8][8] };

            pcol.setcols(0, newcol1);
            pcol.setcols(1, newcol2);
            pcol.setcols(2, newcol3);
            pcol.setcols(3, newcol4);
            pcol.setcols(4, newcol5);
            pcol.setcols(5, newcol6);
            pcol.setcols(6, newcol7);
            pcol.setcols(7, newcol8);
            pcol.setcols(8, newcol9);

            return pcol;
        }

        public Boxs rows_to_boxs(Boxs pbox, int[][] row_matrix)
        {
            int[] newbox1 = { row_matrix[0][0], row_matrix[0][1], row_matrix[0][2], row_matrix[1][0], row_matrix[1][1], row_matrix[1][2], row_matrix[2][0], row_matrix[2][1], row_matrix[2][2] };
            int[] newbox2 = { row_matrix[0][3], row_matrix[0][4], row_matrix[0][5], row_matrix[1][3], row_matrix[1][4], row_matrix[1][5], row_matrix[2][3], row_matrix[2][4], row_matrix[2][5] };
            int[] newbox3 = { row_matrix[0][6], row_matrix[0][7], row_matrix[0][8], row_matrix[1][6], row_matrix[1][7], row_matrix[1][8], row_matrix[2][6], row_matrix[2][7], row_matrix[2][8] };
            int[] newbox4 = { row_matrix[3][0], row_matrix[3][1], row_matrix[3][2], row_matrix[4][0], row_matrix[4][1], row_matrix[4][2], row_matrix[5][0], row_matrix[5][1], row_matrix[5][2] };
            int[] newbox5 = { row_matrix[3][3], row_matrix[3][4], row_matrix[3][5], row_matrix[4][3], row_matrix[4][4], row_matrix[4][5], row_matrix[5][3], row_matrix[5][4], row_matrix[5][5] };
            int[] newbox6 = { row_matrix[3][6], row_matrix[3][7], row_matrix[3][8], row_matrix[4][6], row_matrix[4][7], row_matrix[4][8], row_matrix[5][6], row_matrix[5][7], row_matrix[5][8] };
            int[] newbox7 = { row_matrix[6][0], row_matrix[6][1], row_matrix[6][2], row_matrix[7][0], row_matrix[7][1], row_matrix[7][2], row_matrix[8][0], row_matrix[8][1], row_matrix[8][2] };
            int[] newbox8 = { row_matrix[6][3], row_matrix[6][4], row_matrix[6][5], row_matrix[7][3], row_matrix[7][4], row_matrix[7][5], row_matrix[8][3], row_matrix[8][4], row_matrix[8][5] };
            int[] newbox9 = { row_matrix[6][6], row_matrix[6][7], row_matrix[6][8], row_matrix[7][6], row_matrix[7][7], row_matrix[7][8], row_matrix[8][6], row_matrix[8][7], row_matrix[8][8] };

            pbox.setboxs(0, newbox1);
            pbox.setboxs(1, newbox2);
            pbox.setboxs(2, newbox3);
            pbox.setboxs(3, newbox4);
            pbox.setboxs(4, newbox5);
            pbox.setboxs(5, newbox6);
            pbox.setboxs(6, newbox7);
            pbox.setboxs(7, newbox8);
            pbox.setboxs(8, newbox9);

            return pbox;
        }

        public Rows cols_to_rows(Rows prow, int[][] col_matrix)
        {
            int[] newrow1 = { col_matrix[0][0], col_matrix[1][0], col_matrix[2][0], col_matrix[3][0], col_matrix[4][0], col_matrix[5][0], col_matrix[6][0], col_matrix[7][0], col_matrix[8][0] };
            int[] newrow2 = { col_matrix[0][1], col_matrix[1][1], col_matrix[2][1], col_matrix[3][1], col_matrix[4][1], col_matrix[5][1], col_matrix[6][1], col_matrix[7][1], col_matrix[8][1] };
            int[] newrow3 = { col_matrix[0][2], col_matrix[1][2], col_matrix[2][2], col_matrix[3][2], col_matrix[4][2], col_matrix[5][2], col_matrix[6][2], col_matrix[7][2], col_matrix[8][2] };
            int[] newrow4 = { col_matrix[0][3], col_matrix[1][3], col_matrix[2][3], col_matrix[3][3], col_matrix[4][3], col_matrix[5][3], col_matrix[6][3], col_matrix[7][3], col_matrix[8][3] };
            int[] newrow5 = { col_matrix[0][4], col_matrix[1][4], col_matrix[2][4], col_matrix[3][4], col_matrix[4][4], col_matrix[5][4], col_matrix[6][4], col_matrix[7][4], col_matrix[8][4] };
            int[] newrow6 = { col_matrix[0][5], col_matrix[1][5], col_matrix[2][5], col_matrix[3][5], col_matrix[4][5], col_matrix[5][5], col_matrix[6][5], col_matrix[7][5], col_matrix[8][5] };
            int[] newrow7 = { col_matrix[0][6], col_matrix[1][6], col_matrix[2][6], col_matrix[3][6], col_matrix[4][6], col_matrix[5][6], col_matrix[6][6], col_matrix[7][6], col_matrix[8][6] };
            int[] newrow8 = { col_matrix[0][7], col_matrix[1][7], col_matrix[2][7], col_matrix[3][7], col_matrix[4][7], col_matrix[5][7], col_matrix[6][7], col_matrix[7][7], col_matrix[8][7] };
            int[] newrow9 = { col_matrix[0][8], col_matrix[1][8], col_matrix[2][8], col_matrix[3][8], col_matrix[4][8], col_matrix[5][8], col_matrix[6][8], col_matrix[7][8], col_matrix[8][8] };

            prow.setrows(0, newrow1);
            prow.setrows(1, newrow2);
            prow.setrows(2, newrow3);
            prow.setrows(3, newrow4);
            prow.setrows(4, newrow5);
            prow.setrows(5, newrow6);
            prow.setrows(6, newrow7);
            prow.setrows(7, newrow8);
            prow.setrows(8, newrow9);

            return prow;
        }

        public Boxs cols_to_boxs(Boxs pbox, int[][] col_matrix)
        {
            int[] newbox1 = { col_matrix[0][0], col_matrix[1][0], col_matrix[2][0], col_matrix[0][1], col_matrix[1][1], col_matrix[2][1], col_matrix[0][2], col_matrix[1][2], col_matrix[2][2] };
            int[] newbox2 = { col_matrix[3][0], col_matrix[4][0], col_matrix[5][0], col_matrix[3][1], col_matrix[4][1], col_matrix[5][1], col_matrix[3][2], col_matrix[4][2], col_matrix[5][2] };
            int[] newbox3 = { col_matrix[6][0], col_matrix[7][0], col_matrix[8][0], col_matrix[6][1], col_matrix[7][1], col_matrix[8][1], col_matrix[6][2], col_matrix[7][2], col_matrix[8][2] };
            int[] newbox4 = { col_matrix[0][3], col_matrix[1][3], col_matrix[2][3], col_matrix[0][4], col_matrix[1][4], col_matrix[2][4], col_matrix[0][5], col_matrix[1][5], col_matrix[2][5] };
            int[] newbox5 = { col_matrix[3][3], col_matrix[4][3], col_matrix[5][3], col_matrix[3][4], col_matrix[4][4], col_matrix[5][4], col_matrix[3][5], col_matrix[4][5], col_matrix[5][5] };
            int[] newbox6 = { col_matrix[6][3], col_matrix[7][3], col_matrix[8][3], col_matrix[6][4], col_matrix[7][4], col_matrix[8][4], col_matrix[6][5], col_matrix[7][5], col_matrix[8][5] };
            int[] newbox7 = { col_matrix[0][6], col_matrix[1][6], col_matrix[2][6], col_matrix[0][7], col_matrix[1][7], col_matrix[2][7], col_matrix[0][8], col_matrix[1][8], col_matrix[2][8] };
            int[] newbox8 = { col_matrix[3][6], col_matrix[4][6], col_matrix[5][6], col_matrix[3][7], col_matrix[4][7], col_matrix[5][7], col_matrix[3][8], col_matrix[4][8], col_matrix[5][8] };
            int[] newbox9 = { col_matrix[6][6], col_matrix[7][6], col_matrix[8][6], col_matrix[6][7], col_matrix[7][7], col_matrix[8][7], col_matrix[6][8], col_matrix[7][8], col_matrix[8][8] };

            pbox.setboxs(0, newbox1);
            pbox.setboxs(1, newbox2);
            pbox.setboxs(2, newbox3);
            pbox.setboxs(3, newbox4);
            pbox.setboxs(4, newbox5);
            pbox.setboxs(5, newbox6);
            pbox.setboxs(6, newbox7);
            pbox.setboxs(7, newbox8);
            pbox.setboxs(8, newbox9);

            return pbox;
        }

        public Rows boxs_to_rows(Rows prow, int[][] box_matrix)
        {
            int[] newrow1 = { box_matrix[0][0], box_matrix[0][1], box_matrix[0][2], box_matrix[1][0], box_matrix[1][1], box_matrix[1][2], box_matrix[2][0], box_matrix[2][1], box_matrix[2][2] };
            int[] newrow2 = { box_matrix[0][3], box_matrix[0][4], box_matrix[0][5], box_matrix[1][3], box_matrix[1][4], box_matrix[1][5], box_matrix[2][3], box_matrix[2][4], box_matrix[2][5] };
            int[] newrow3 = { box_matrix[0][6], box_matrix[0][7], box_matrix[0][8], box_matrix[1][6], box_matrix[1][7], box_matrix[1][8], box_matrix[2][6], box_matrix[2][7], box_matrix[2][8] };
            int[] newrow4 = { box_matrix[3][0], box_matrix[3][1], box_matrix[3][2], box_matrix[4][0], box_matrix[4][1], box_matrix[4][2], box_matrix[5][0], box_matrix[5][1], box_matrix[5][2] };
            int[] newrow5 = { box_matrix[3][3], box_matrix[3][4], box_matrix[3][5], box_matrix[4][3], box_matrix[4][4], box_matrix[4][5], box_matrix[5][3], box_matrix[5][4], box_matrix[5][5] };
            int[] newrow6 = { box_matrix[3][6], box_matrix[3][7], box_matrix[3][8], box_matrix[4][6], box_matrix[4][7], box_matrix[4][8], box_matrix[5][6], box_matrix[5][7], box_matrix[5][8] };
            int[] newrow7 = { box_matrix[6][0], box_matrix[6][1], box_matrix[6][2], box_matrix[7][0], box_matrix[7][1], box_matrix[7][2], box_matrix[8][0], box_matrix[8][1], box_matrix[8][2] };
            int[] newrow8 = { box_matrix[6][3], box_matrix[6][4], box_matrix[6][5], box_matrix[7][3], box_matrix[7][4], box_matrix[7][5], box_matrix[8][3], box_matrix[8][4], box_matrix[8][5] };
            int[] newrow9 = { box_matrix[6][6], box_matrix[6][7], box_matrix[6][8], box_matrix[7][6], box_matrix[7][7], box_matrix[7][8], box_matrix[8][6], box_matrix[8][7], box_matrix[8][8] };

            prow.setrows(0, newrow1);
            prow.setrows(1, newrow2);
            prow.setrows(2, newrow3);
            prow.setrows(3, newrow4);
            prow.setrows(4, newrow5);
            prow.setrows(5, newrow6);
            prow.setrows(6, newrow7);
            prow.setrows(7, newrow8);
            prow.setrows(8, newrow9);

            return prow;
        }

        public Cols boxs_to_cols(Cols pcol, int[][] box_matrix)
        {
            int[] newcol1 = { box_matrix[0][0], box_matrix[0][3], box_matrix[0][6], box_matrix[3][0], box_matrix[3][3], box_matrix[3][6], box_matrix[6][0], box_matrix[6][3], box_matrix[6][6] };
            int[] newcol2 = { box_matrix[0][1], box_matrix[0][4], box_matrix[0][7], box_matrix[3][1], box_matrix[3][4], box_matrix[3][7], box_matrix[6][1], box_matrix[6][4], box_matrix[6][7] };
            int[] newcol3 = { box_matrix[0][2], box_matrix[0][5], box_matrix[0][8], box_matrix[3][2], box_matrix[3][5], box_matrix[3][8], box_matrix[6][2], box_matrix[6][5], box_matrix[6][8] };
            int[] newcol4 = { box_matrix[1][0], box_matrix[1][3], box_matrix[1][6], box_matrix[4][0], box_matrix[4][3], box_matrix[4][6], box_matrix[7][0], box_matrix[7][3], box_matrix[7][6] };
            int[] newcol5 = { box_matrix[1][1], box_matrix[1][4], box_matrix[1][7], box_matrix[4][1], box_matrix[4][4], box_matrix[4][7], box_matrix[7][1], box_matrix[7][4], box_matrix[7][7] };
            int[] newcol6 = { box_matrix[1][2], box_matrix[1][5], box_matrix[1][8], box_matrix[4][2], box_matrix[4][5], box_matrix[4][8], box_matrix[7][2], box_matrix[7][5], box_matrix[7][8] };
            int[] newcol7 = { box_matrix[2][0], box_matrix[2][3], box_matrix[2][6], box_matrix[5][0], box_matrix[5][3], box_matrix[5][6], box_matrix[8][0], box_matrix[8][3], box_matrix[8][6] };
            int[] newcol8 = { box_matrix[2][1], box_matrix[2][4], box_matrix[2][7], box_matrix[5][1], box_matrix[5][4], box_matrix[5][7], box_matrix[8][1], box_matrix[8][4], box_matrix[8][7] };
            int[] newcol9 = { box_matrix[2][2], box_matrix[2][5], box_matrix[2][8], box_matrix[5][2], box_matrix[5][5], box_matrix[5][8], box_matrix[8][2], box_matrix[8][5], box_matrix[8][8] };

            pcol.setcols(0, newcol1);
            pcol.setcols(1, newcol2);
            pcol.setcols(2, newcol3);
            pcol.setcols(3, newcol4);
            pcol.setcols(4, newcol5);
            pcol.setcols(5, newcol6);
            pcol.setcols(6, newcol7);
            pcol.setcols(7, newcol8);
            pcol.setcols(8, newcol9);

            return pcol;
        }

        /*------------------------------------------------------------------------------------------------------------------------*/
        /* Utility Functions */
        /*------------------------------------------------------------------------------------------------------------------------*/

        public bool has_zeros(int[] vect)
        {
            /* 
             * This checks if an array (row/box/column) has any zeros in it.
             */

            if (vect[0] + vect[1] + vect[2] + vect[3] + vect[4] + vect[5] + vect[6] + vect[7] + vect[8] == 45)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int count_zeros(int[] vect)
        {
            /*
             * This counts how many zeros are in an array (row/box/column).
             */

            int count = 0;
            for (int a = 0; a < 9; a++)
            {
                if (vect[a] == 0)
                {
                    count += 1;
                }
                else
                {
                    continue;
                }
            }
            return count;
        }

        public int[] where_zeros(int[] vect)
        {
            /*
             * This looks for where in an array (row/box/column) the zeros are.
             */

            int[] zero_loc = new int[9];

            for (int a = 0; a < 9; a++)
            {
                if (vect[a] == 0)
                {
                    zero_loc[a] = 1;
                }
                else
                {
                    zero_loc[a] = 0;
                }
            }

            return zero_loc;
        }

        public int[] find_important(Rows fakerow, Cols fakecol, Boxs fakebox, int skiprow, int skipcol)
        {
            /*
             * This looks for any zeros, and compares them to any it has already looked at.
             * When we find a new zero, it returns an array with the new zero's row, column, and box number.
             */

            for (int i = 0; i < 9; i++)
            {
                int[] row = fakerow.getrows(i);      // This variable reduces the number of function calls.

                if (!has_zeros(row))                 // First check if this row has zeros. If not, just move on.
                {
                    continue;
                }
                else                                                  // If so, find the important row/column/box for analysis
                {
                    int important_row = i;                            // important row number is given by the i value containing a zero.
                    int important_col = 0;
                    int important_box = 0;

                    bool change = false;

                    for (int j = 0; j < 9; j++)
                    {
                        if (row[j] == 0)                              // Important col number is given by the j value containing a zero.
                        {
                            switch (j + 1)
                            {
                                case 1:
                                    important_col = 0;
                                    if ((important_row < skiprow) || (important_col <= skipcol))       // Skip this zero if we've looked at it before.
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        switch (i)                        // Important box number depends on i and j.
                                        {
                                            case 0:
                                            case 1:
                                            case 2:
                                                important_box = 0;
                                                change = true;
                                                break;
                                            case 3:
                                            case 4:
                                            case 5:
                                                important_box = 3;
                                                change = true;
                                                break;
                                            case 6:
                                            case 7:
                                            case 8:
                                                important_box = 6;
                                                change = true;
                                                break;
                                            default:
                                                MessageBox.Show("Something is wrong with Linking");
                                                break;
                                        }
                                        break;
                                    }
                                case 2:
                                    important_col = 1;
                                    if ((important_row < skiprow) || (important_col <= skipcol))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        switch (i)
                                        {
                                            case 0:
                                            case 1:
                                            case 2:
                                                important_box = 0;
                                                change = true;
                                                break;
                                            case 3:
                                            case 4:
                                            case 5:
                                                important_box = 3;
                                                change = true;
                                                break;
                                            case 6:
                                            case 7:
                                            case 8:
                                                important_box = 6;
                                                change = true;
                                                break;
                                            default:
                                                MessageBox.Show("Something is wrong with Linking");
                                                break;
                                        }
                                        break;
                                    }
                                case 3:
                                    important_col = 2;
                                    if ((important_row < skiprow) || (important_col <= skipcol))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        switch (i)
                                        {
                                            case 0:
                                            case 1:
                                            case 2:
                                                important_box = 0;
                                                change = true;
                                                break;
                                            case 3:
                                            case 4:
                                            case 5:
                                                important_box = 3;
                                                change = true;
                                                break;
                                            case 6:
                                            case 7:
                                            case 8:
                                                important_box = 6;
                                                change = true;
                                                break;
                                            default:
                                                MessageBox.Show("Something is wrong with Linking");
                                                break;
                                        }
                                        break;
                                    }
                                case 4:
                                    important_col = 3;
                                    if ((important_row < skiprow) || (important_col <= skipcol))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        switch (i)
                                        {
                                            case 0:
                                            case 1:
                                            case 2:
                                                important_box = 1;
                                                change = true;
                                                break;
                                            case 3:
                                            case 4:
                                            case 5:
                                                important_box = 4;
                                                change = true;
                                                break;
                                            case 6:
                                            case 7:
                                            case 8:
                                                important_box = 7;
                                                change = true;
                                                break;
                                            default:
                                                MessageBox.Show("Something is wrong with Linking");
                                                break;
                                        }
                                        break;
                                    }
                                case 5:
                                    important_col = 4;
                                    if ((important_row < skiprow) || (important_col <= skipcol))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        switch (i)
                                        {
                                            case 0:
                                            case 1:
                                            case 2:
                                                important_box = 1;
                                                change = true;
                                                break;
                                            case 3:
                                            case 4:
                                            case 5:
                                                important_box = 4;
                                                change = true;
                                                break;
                                            case 6:
                                            case 7:
                                            case 8:
                                                important_box = 7;
                                                change = true;
                                                break;
                                            default:
                                                MessageBox.Show("Something is wrong with Linking");
                                                break;
                                        }
                                        break;
                                    }
                                case 6:
                                    important_col = 5;
                                    if ((important_row < skiprow) || (important_col <= skipcol))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        switch (i)
                                        {
                                            case 0:
                                            case 1:
                                            case 2:
                                                important_box = 1;
                                                change = true;
                                                break;
                                            case 3:
                                            case 4:
                                            case 5:
                                                important_box = 4;
                                                change = true;
                                                break;
                                            case 6:
                                            case 7:
                                            case 8:
                                                important_box = 7;
                                                change = true;
                                                break;
                                            default:
                                                MessageBox.Show("Something is wrong with Linking");
                                                break;
                                        }
                                        break;
                                    }
                                case 7:
                                    important_col = 6;
                                    if ((important_row < skiprow) || (important_col <= skipcol))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        switch (i)
                                        {
                                            case 0:
                                            case 1:
                                            case 2:
                                                important_box = 2;
                                                change = true;
                                                break;
                                            case 3:
                                            case 4:
                                            case 5:
                                                important_box = 5;
                                                change = true;
                                                break;
                                            case 6:
                                            case 7:
                                            case 8:
                                                important_box = 8;
                                                change = true;
                                                break;
                                            default:
                                                MessageBox.Show("Something is wrong with Linking");
                                                break;
                                        }
                                        break;
                                    }
                                case 8:
                                    important_col = 7;
                                    if ((important_row < skiprow) || (important_col <= skipcol))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        switch (i)
                                        {
                                            case 0:
                                            case 1:
                                            case 2:
                                                important_box = 2;
                                                change = true;
                                                break;
                                            case 3:
                                            case 4:
                                            case 5:
                                                important_box = 5;
                                                change = true;
                                                break;
                                            case 6:
                                            case 7:
                                            case 8:
                                                important_box = 8;
                                                change = true;
                                                break;
                                            default:
                                                MessageBox.Show("Something is wrong with Linking");
                                                break;
                                        }
                                        break;
                                    }
                                case 9:
                                    important_col = 8;
                                    if ((important_row < skiprow) || (important_col <= skipcol))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        switch (i)
                                        {
                                            case 0:
                                            case 1:
                                            case 2:
                                                important_box = 2;
                                                change = true;
                                                break;
                                            case 3:
                                            case 4:
                                            case 5:
                                                important_box = 5;
                                                change = true;
                                                break;
                                            case 6:
                                            case 7:
                                            case 8:
                                                important_box = 8;
                                                change = true;
                                                break;
                                            default:
                                                MessageBox.Show("Something is wrong with Linking");
                                                break;
                                        }
                                        break;
                                    }
                                default:
                                    MessageBox.Show("What is going on here?");
                                    break;
                            }

                            switch (change)
                            {
                                case true:
                                    return [important_row, important_col, important_box];       // Once we honed in on the zero, return the relevant numbers.
                                default:
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }

            return [0, 0, 0];                   // If there are no zeros, return false.
        }

        public (bool, int) basic_value_insert(int[] vect)
        {
            /*
             * This will insert a value into an array (row/box/column) assuming the array is only missing one number.
             * If the array is missing multiple numbers, or if it is already full, it will do nothing.
             */

            bool hzv = has_zeros(vect);             // These two variables exist to reduce the number of function calls.
            int czv = count_zeros(vect);

            if ((hzv != false) && (czv == 1))
            {
                int place = 0;
                int summa = vect[0] + vect[1] + vect[2] + vect[3] + vect[4] + vect[5] + vect[6] + vect[7] + vect[8];

                for (int a = 0; a < 9; a++)
                {
                    if (vect[a] == 0)
                    {
                        vect[a] = 45 - summa;
                        place = a;
                    }
                    else
                    {
                        continue;
                    }
                }

                return (true, vect[place]);
            }
            else if (hzv == false)
            {
                return (false, 0);
            }
            else if (czv < 1)
            {
                return (false, 0);
            }
            else if (czv > 1)
            {
                return (false, 0);
            }
            else
            {
                MessageBox.Show("Something is wonky with the basic replacement algorithm.\n");
                return (false, 0);
            }

        }

        public (bool, int) basic_value_checking(Rows fakerow, int row_num, Cols fakecol, int col_num, Boxs fakebox, int box_num)
        {
            /*
             * This checks what values an individual zero can be.
             * If the zero can only be one value (a 2 or a 5, etc) it returns true, and the number that the 0 must be.
             * If the zero can be multiple things, it returns false.
             */

            // We need to know if a spot can be a one, a two, etc.
            bool one = false;                   
            bool two = false;
            bool three = false;
            bool four = false;
            bool five = false;
            bool six = false;
            bool seven = false;
            bool eight = false;
            bool nine = false;

            // Check if the row/column/box already has each number. ("Does this row/column/box already have a 1? Do they have a 2?, etc")
            // As named, these variables save time by reducing function calls dramatically.
            int[] row_time_saver = fakerow.getrows(row_num);            
            int[] col_time_saver = fakecol.getcols(col_num);
            int[] box_time_saver = fakebox.getboxs(box_num);
            
            one = (fakerow.has_number(1, row_time_saver) || fakecol.has_number(1, col_time_saver) || fakebox.has_number(1, box_time_saver));
            two = (fakerow.has_number(2, row_time_saver) || fakecol.has_number(2, col_time_saver) || fakebox.has_number(2, box_time_saver));
            three = (fakerow.has_number(3, row_time_saver) || fakecol.has_number(3, col_time_saver) || fakebox.has_number(3, box_time_saver));
            four = (fakerow.has_number(4, row_time_saver) || fakecol.has_number(4, col_time_saver) || fakebox.has_number(4, box_time_saver));
            five = (fakerow.has_number(5, row_time_saver) || fakecol.has_number(5, col_time_saver) || fakebox.has_number(5, box_time_saver));
            six = (fakerow.has_number(6, row_time_saver) || fakecol.has_number(6, col_time_saver) || fakebox.has_number(6, box_time_saver));
            seven = (fakerow.has_number(7, row_time_saver) || fakecol.has_number(7, col_time_saver) || fakebox.has_number(7, box_time_saver));
            eight = (fakerow.has_number(8, row_time_saver) || fakecol.has_number(8, col_time_saver) || fakebox.has_number(8, box_time_saver));
            nine = (fakerow.has_number(9, row_time_saver) || fakecol.has_number(9, col_time_saver) || fakebox.has_number(9, box_time_saver));

            // Identify if only one number is possible. ("Can this spot only be a 1? Can it only be a two? etc").
            // If multiple or none are possible, each new bool we create ends up false.
            bool a = (!one && (two && three && four && five && six && seven && eight && nine));
            bool b = (!two && (one && three && four && five && six && seven && eight && nine));
            bool c = (!three && (one && two && four && five && six && seven && eight && nine));
            bool d = (!four && (one && two && three && five && six && seven && eight && nine));
            bool e = (!five && (one && two && three && four && six && seven && eight && nine));
            bool f = (!six && (one && two && three && four && five && seven && eight && nine));
            bool g = (!seven && (one && two && three && four && five && six && eight && nine));
            bool h = (!eight && (one && two && three && four && five && six && seven && nine));
            bool i = (!nine && (one && two && three && four && five && six && seven && eight));

            // Organize an array for looping through, for reusability.
            bool[] exchange = { a, b, c, d, e, f, g, h, i };

            // Identify which number is possible. If only one is possible, return true and which number it is. Otherwise, false.
            for (int check = 0; check < 9;  check++) 
            {
                switch (exchange[check])
                {
                    case true:
                        return (true, check);
                    case false:
                        continue;
                }
            }
                return (false, 0);
        }

        public (bool, int[][]) basic_value_solving(int[][] mat, int[][] mat2, int[][] mat3)
        {
            /*
             * This takes every zero in the Sudoku and solves for each square based on what each square can be.
             * It does not take sets into account. It only says "this row already has a 1, this box already has a 2", etc.
             * It does not eliminate based on what a set must include, it eliminates only what a sqaure's three sets already have.
             * 
             * If it does a replacement, it returns true and the new matrix. If not, it returns false.
             */

            /* Setup dummy objects so that we can use their tools. */
            Rows fakerow = new Rows();
            Cols fakecol = new Cols();
            Boxs fakebox = new Boxs();

            /* Populate the dummies with the correct information. */
            for (int fake = 0; fake < 9; fake++)
            {
                fakerow.setrows(fake, mat[fake]);
                fakecol.setcols(fake, mat2[fake]);
                fakebox.setboxs(fake, mat3[fake]);
            }

            /* Find the important row/column/box numbers (the first or next zero we find) and analyze them. */
            int[] important = new int[3];
            important = [-1, -1, -1];
            int skiprow = -1;
            int skipcol = -1;

            int count = 0;
            bool act = false;

            do
            {

                important = find_important(fakerow, fakecol, fakebox, skiprow, skipcol);

                if (important[0] > skiprow)
                {
                    skipcol = -1;
                }
                else
                {
                    skipcol = important[1];
                }

                skiprow = important[0];

                (bool verify, int loc_minus_1) = basic_value_checking(fakerow, important[0], fakecol, important[1], fakebox, important[2]);

                if (verify)
                {
                    int[] newrow = fakerow.getrows(important[0]);
                    newrow[important[1]] = loc_minus_1 + 1;
                    fakerow.setrows(important[0], newrow);
                    act = true;
                    count++;
                }

                else
                {
                    count++;
                    if (count == 81)
                    {
                        // MessageBox.Show("We are maxing out basic solver.");
                    }
                    continue;
                }
            }
            while ((act == false) && (count < 81));

            return (act, fakerow.getmatrix());
        }

        public (bool, Rows) intermediate_row_value_checking(Rows fakerow, int row_num, Cols fakecol, Boxs fakebox)
        {
            /* 
             * This is the checker for rows, to see what each zero within a row can be,
             * If it can solve for a particular square, it adds the number and returns the new Row set.
             * If it cannot solve anything, it returns the original Row set.
             */

            // We need to find all the zeros in our row, and know their location.
            // As named, the time saver variables save time by reducing function calls dramatically.
            int[] row_time_saver = fakerow.getrows(row_num);

            int num_zeros = count_zeros(row_time_saver);
            int[] zero_loc = where_zeros(row_time_saver);

            // We now have the number and locations of each zero.
            // Create and control the size of the possibility-tracking matrix.
            bool[][] possibilities = new bool[9][];
            possibilities[0] = new bool[9];
            possibilities[1] = new bool[9];
            possibilities[2] = new bool[9];
            possibilities[3] = new bool[9];
            possibilities[4] = new bool[9];
            possibilities[5] = new bool[9];
            possibilities[6] = new bool[9];
            possibilities[7] = new bool[9];
            possibilities[8] = new bool[9];

            bool change = false;

            // We need to set if a zero can be a one, a two, etc.
            bool one = false;
            bool two = false;
            bool three = false;
            bool four = false;
            bool five = false;
            bool six = false;
            bool seven = false;
            bool eight = false;
            bool nine = false;

            for (int w = 0; w < 9; w++)
            {
                if (zero_loc[w] != 1)
                {
                    continue;
                }
                else
                {
                    int[] col_time_saver = fakecol.getcols(w);
                    int[] box_time_saver = new int[9];

                    switch (row_num)
                    {
                        case 0:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(0);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(1);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(2);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;
                                
                            }
                            break;
                        case 1:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(0);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(1);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(2);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 2:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(0);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(1);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(2);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 3:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(3);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(4);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(5);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 4:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(3);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(4);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(5);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 5:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(3);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(4);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(5);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 6:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(6);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(7);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(8);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 7:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(6);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(7);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(8);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 8:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(6);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(7);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(8);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                    } 

                    // Check if the row/column/box already has each number. ("Does this row/column/box already have a 1? Do they have a 2?", etc)
                    one = (fakerow.has_number(1, row_time_saver) || fakecol.has_number(1, col_time_saver) || fakebox.has_number(1, box_time_saver));
                    two = (fakerow.has_number(2, row_time_saver) || fakecol.has_number(2, col_time_saver) || fakebox.has_number(2, box_time_saver));
                    three = (fakerow.has_number(3, row_time_saver) || fakecol.has_number(3, col_time_saver) || fakebox.has_number(3, box_time_saver));
                    four = (fakerow.has_number(4, row_time_saver) || fakecol.has_number(4, col_time_saver) || fakebox.has_number(4, box_time_saver));
                    five = (fakerow.has_number(5, row_time_saver) || fakecol.has_number(5, col_time_saver) || fakebox.has_number(5, box_time_saver));
                    six = (fakerow.has_number(6, row_time_saver) || fakecol.has_number(6, col_time_saver) || fakebox.has_number(6, box_time_saver));
                    seven = (fakerow.has_number(7, row_time_saver) || fakecol.has_number(7, col_time_saver) || fakebox.has_number(7, box_time_saver));
                    eight = (fakerow.has_number(8, row_time_saver) || fakecol.has_number(8, col_time_saver) || fakebox.has_number(8, box_time_saver));
                    nine = (fakerow.has_number(9, row_time_saver) || fakecol.has_number(9, col_time_saver) || fakebox.has_number(9, box_time_saver));

                    // Set the matrix of possbilities for each zero in our box.
                    possibilities[w] = [!one, !two, !three, !four, !five, !six, !seven, !eight, !nine];
                }
            }

            // Determine the number of zeros that can be a given number (3 zeros could be a 1, 1 zero could be a 4, etc).
            int alpha = 0;
            int beta = 0;
            int gamma = 0;
            int delta = 0;
            int epsilon = 0;
            int zeta = 0;
            int eta = 0;
            int theta = 0;
            int iota = 0;

            for (int e = 0; e < 9; e++)
            {
                if (possibilities[e][0])
                {
                    alpha += 1;
                }
                if (possibilities[e][1])
                {
                    beta += 1;
                }
                if (possibilities[e][2])
                {
                    gamma += 1;
                }
                if (possibilities[e][3])
                {
                    delta += 1;
                }
                if (possibilities[e][4])
                {
                    epsilon += 1;
                }
                if (possibilities[e][5])
                {
                    zeta += 1;
                }
                if (possibilities[e][6])
                {
                    eta += 1;
                }
                if (possibilities[e][7])
                {
                    theta += 1;
                }
                if (possibilities[e][8])
                {
                    iota += 1;
                }
            }

            // Replace anything that can only be one thing.
            if (alpha == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][0])
                    {
                        row_time_saver[r] = 1;
                        fakerow.setrows(row_num, row_time_saver);
                        change = true;
                    }
                }
            }
            if (beta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][1])
                    {
                        row_time_saver[r] = 2;
                        fakerow.setrows(row_num, row_time_saver);
                        change = true;
                    }
                }
            }
            if (gamma == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][2])
                    {
                        row_time_saver[r] = 3;
                        fakerow.setrows(row_num, row_time_saver);
                        change = true;
                    }
                }
            }
            if (delta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][3])
                    {
                        row_time_saver[r] = 4;
                        fakerow.setrows(row_num, row_time_saver);
                        change = true;
                    }
                }
            }
            if (epsilon == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][4])
                    {
                        row_time_saver[r] = 5;
                        fakerow.setrows(row_num, row_time_saver);
                        change = true;
                    }
                }
            }
            if (zeta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][5])
                    {
                        row_time_saver[r] = 6;
                        fakerow.setrows(row_num, row_time_saver);
                        change = true;
                    }
                }
            }
            if (eta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][6])
                    {
                        row_time_saver[r] = 7;
                        fakerow.setrows(row_num, row_time_saver);
                        change = true;
                    }
                }
            }
            if (theta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][7])
                    {
                        row_time_saver[r] = 8;
                        fakerow.setrows(row_num, row_time_saver);
                        change = true;
                    }
                }
            }
            if (iota == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][8])
                    {
                        row_time_saver[r] = 9;
                        fakerow.setrows(row_num, row_time_saver);
                        change = true;
                    }
                }
            }

            if (change == true)
            {
                return (true, fakerow);
            }
            else
            {
                return (false, fakerow);
            }
        }

        public (bool, Cols) intermediate_col_value_checking(Rows fakerow, Cols fakecol, int col_num, Boxs fakebox)
        {
            /* 
             * This is the checker for columns, to see what each zero within a column can be,
             * If it can solve for a particular square, it adds the number and returns the new Column set.
             * If it cannot solve anything, it returns the original Column set.
             */

            // We need to find all the zeros in our column, and know their location.
            // As named, the time saver variables save time by reducing function calls dramatically.
            int[] col_time_saver = fakecol.getcols(col_num);

            int num_zeros = count_zeros(col_time_saver);
            int[] zero_loc = where_zeros(col_time_saver);

            // We now have the number and locations of each zero.
            // Create and control the size of the possibility-tracking matrix.
            bool[][] possibilities = new bool[9][];
            possibilities[0] = new bool[9];
            possibilities[1] = new bool[9];
            possibilities[2] = new bool[9];
            possibilities[3] = new bool[9];
            possibilities[4] = new bool[9];
            possibilities[5] = new bool[9];
            possibilities[6] = new bool[9];
            possibilities[7] = new bool[9];
            possibilities[8] = new bool[9];

            bool change = false;

            // We need to set if a zero can be a one, a two, etc.
            bool one = false;
            bool two = false;
            bool three = false;
            bool four = false;
            bool five = false;
            bool six = false;
            bool seven = false;
            bool eight = false;
            bool nine = false;

            for (int w = 0; w < 9; w++)
            {
                if (zero_loc[w] != 1)
                {
                    continue;
                }
                else
                {
                    int[] row_time_saver = fakerow.getrows(w);
                    int[] box_time_saver = new int[9];

                    switch (col_num)
                    {
                        case 0:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(0);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(3);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(6);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 1:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(0);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(3);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(6);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 2:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(0);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(3);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(6);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 3:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(1);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(4);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(7);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 4:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(1);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(4);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(7);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 5:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(1);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(4);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(7);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 6:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(2);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(5);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(8);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 7:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(2);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(5);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(8);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                        case 8:
                            switch (w)
                            {
                                case 0:
                                case 1:
                                case 2:
                                    box_time_saver = fakebox.getboxs(2);
                                    break;
                                case 3:
                                case 4:
                                case 5:
                                    box_time_saver = fakebox.getboxs(5);
                                    break;
                                case 6:
                                case 7:
                                case 8:
                                    box_time_saver = fakebox.getboxs(8);
                                    break;
                                default:
                                    MessageBox.Show("Something is very wrong with assinging box values.");
                                    break;

                            }
                            break;
                    }

                    // Check if the row/column/box already has each number. ("Does this row/column/box already have a 1? Do they have a 2?", etc)
                    one = (fakerow.has_number(1, row_time_saver) || fakecol.has_number(1, col_time_saver) || fakebox.has_number(1, box_time_saver));
                    two = (fakerow.has_number(2, row_time_saver) || fakecol.has_number(2, col_time_saver) || fakebox.has_number(2, box_time_saver));
                    three = (fakerow.has_number(3, row_time_saver) || fakecol.has_number(3, col_time_saver) || fakebox.has_number(3, box_time_saver));
                    four = (fakerow.has_number(4, row_time_saver) || fakecol.has_number(4, col_time_saver) || fakebox.has_number(4, box_time_saver));
                    five = (fakerow.has_number(5, row_time_saver) || fakecol.has_number(5, col_time_saver) || fakebox.has_number(5, box_time_saver));
                    six = (fakerow.has_number(6, row_time_saver) || fakecol.has_number(6, col_time_saver) || fakebox.has_number(6, box_time_saver));
                    seven = (fakerow.has_number(7, row_time_saver) || fakecol.has_number(7, col_time_saver) || fakebox.has_number(7, box_time_saver));
                    eight = (fakerow.has_number(8, row_time_saver) || fakecol.has_number(8, col_time_saver) || fakebox.has_number(8, box_time_saver));
                    nine = (fakerow.has_number(9, row_time_saver) || fakecol.has_number(9, col_time_saver) || fakebox.has_number(9, box_time_saver));

                    // Set the matrix of possbilities for each zero in our box.
                    possibilities[w] = [!one, !two, !three, !four, !five, !six, !seven, !eight, !nine];
                }
            }

            // Determine the number of zeros that can be a given number (3 zeros could be a 1, 1 zero could be a 4, etc).
            int alpha = 0;
            int beta = 0;
            int gamma = 0;
            int delta = 0;
            int epsilon = 0;
            int zeta = 0;
            int eta = 0;
            int theta = 0;
            int iota = 0;

            for (int e = 0; e < 9; e++)
            {
                if (possibilities[e][0])
                {
                    alpha += 1;
                }
                if (possibilities[e][1])
                {
                    beta += 1;
                }
                if (possibilities[e][2])
                {
                    gamma += 1;
                }
                if (possibilities[e][3])
                {
                    delta += 1;
                }
                if (possibilities[e][4])
                {
                    epsilon += 1;
                }
                if (possibilities[e][5])
                {
                    zeta += 1;
                }
                if (possibilities[e][6])
                {
                    eta += 1;
                }
                if (possibilities[e][7])
                {
                    theta += 1;
                }
                if (possibilities[e][8])
                {
                    iota += 1;
                }
            }

            // Replace anything that can only be one thing.
            if (alpha == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][0])
                    {
                        col_time_saver[r] = 1;
                        fakecol.setcols(col_num, col_time_saver);
                        change = true;
                    }
                }
            }
            if (beta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][1])
                    {
                        col_time_saver[r] = 2;
                        fakecol.setcols(col_num, col_time_saver);
                        change = true;
                    }
                }
            }
            if (gamma == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][2])
                    {
                        col_time_saver[r] = 3;
                        fakecol.setcols(col_num, col_time_saver);
                        change = true;
                    }
                }
            }
            if (delta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][3])
                    {
                        col_time_saver[r] = 4;
                        fakecol.setcols(col_num, col_time_saver);
                        change = true;
                    }
                }
            }
            if (epsilon == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][4])
                    {
                        col_time_saver[r] = 5;
                        fakecol.setcols(col_num, col_time_saver);
                        change = true;
                    }
                }
            }
            if (zeta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][5])
                    {
                        col_time_saver[r] = 6;
                        fakecol.setcols(col_num, col_time_saver);
                        change = true;
                    }
                }
            }
            if (eta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][6])
                    {
                        col_time_saver[r] = 7;
                        fakecol.setcols(col_num, col_time_saver);
                        change = true;
                    }
                }
            }
            if (theta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][7])
                    {
                        col_time_saver[r] = 8;
                        fakecol.setcols(col_num, col_time_saver);
                        change = true;
                    }
                }
            }
            if (iota == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][8])
                    {
                        col_time_saver[r] = 9;
                        fakecol.setcols(col_num, col_time_saver);
                        change = true;
                    }
                }
            }

            if (change == true)
            {
                return (true, fakecol);
            }
            else
            {
                return (false, fakecol);
            }
        }

        public (bool, Boxs) intermediate_box_value_checking(Rows fakerow, Cols fakecol, Boxs fakebox, int box_num)
        {
            /* 
             * This is the checker for boxes, to see what each zero within a box can be,
             * If it can solve for a particular square, it adds the number and returns the new Box set.
             * If it cannot solve anything, it returns the original Box set.
             */

            // We need to find all the zeros in our box, and know their location.
            // As named, the time saver variables save time by reducing function calls dramatically.
            int[] box_time_saver = fakebox.getboxs(box_num);

            int num_zeros = count_zeros(box_time_saver);
            int[] zero_loc = where_zeros(box_time_saver);

            int[] r_index = new int[9];
            int[] c_index = new int[9];

            r_index = [9, 9, 9, 9, 9, 9, 9, 9, 9];
            c_index = [9, 9, 9, 9, 9, 9, 9, 9, 9];

            switch (box_num)
            {
                case 0:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 0;
                                    c_index[q] = 0;
                                    break;
                                case 1:
                                    r_index[q] = 0;
                                    c_index[q] = 1;
                                    break;
                                case 2:
                                    r_index[q] = 0;
                                    c_index[q] = 2;
                                    break;
                                case 3:
                                    r_index[q] = 1;
                                    c_index[q] = 0;
                                    break;
                                case 4:
                                    r_index[q] = 1;
                                    c_index[q] = 1;
                                    break;
                                case 5:
                                    r_index[q] = 1;
                                    c_index[q] = 2;
                                    break;
                                case 6:
                                    r_index[q] = 2;
                                    c_index[q] = 0;
                                    break;
                                case 7:
                                    r_index[q] = 2;
                                    c_index[q] = 1;
                                    break;
                                case 8:
                                    r_index[q] = 2;
                                    c_index[q] = 2;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 1:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 0;
                                    c_index[q] = 3;
                                    break;
                                case 1:
                                    r_index[q] = 0;
                                    c_index[q] = 4;
                                    break;
                                case 2:
                                    r_index[q] = 0;
                                    c_index[q] = 5;
                                    break;
                                case 3:
                                    r_index[q] = 1;
                                    c_index[q] = 3;
                                    break;
                                case 4:
                                    r_index[q] = 1;
                                    c_index[q] = 4;
                                    break;
                                case 5:
                                    r_index[q] = 1;
                                    c_index[q] = 5;
                                    break;
                                case 6:
                                    r_index[q] = 2;
                                    c_index[q] = 3;
                                    break;
                                case 7:
                                    r_index[q] = 2;
                                    c_index[q] = 4;
                                    break;
                                case 8:
                                    r_index[q] = 2;
                                    c_index[q] = 5;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 2:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 0;
                                    c_index[q] = 6;
                                    break;
                                case 1:
                                    r_index[q] = 0;
                                    c_index[q] = 7;
                                    break;
                                case 2:
                                    r_index[q] = 0;
                                    c_index[q] = 8;
                                    break;
                                case 3:
                                    r_index[q] = 1;
                                    c_index[q] = 6;
                                    break;
                                case 4:
                                    r_index[q] = 1;
                                    c_index[q] = 7;
                                    break;
                                case 5:
                                    r_index[q] = 1;
                                    c_index[q] = 8;
                                    break;
                                case 6:
                                    r_index[q] = 2;
                                    c_index[q] = 6;
                                    break;
                                case 7:
                                    r_index[q] = 2;
                                    c_index[q] = 7;
                                    break;
                                case 8:
                                    r_index[q] = 2;
                                    c_index[q] = 8;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 3:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 3;
                                    c_index[q] = 0;
                                    break;
                                case 1:
                                    r_index[q] = 3;
                                    c_index[q] = 1;
                                    break;
                                case 2:
                                    r_index[q] = 3;
                                    c_index[q] = 2;
                                    break;
                                case 3:
                                    r_index[q] = 4;
                                    c_index[q] = 0;
                                    break;
                                case 4:
                                    r_index[q] = 4;
                                    c_index[q] = 1;
                                    break;
                                case 5:
                                    r_index[q] = 4;
                                    c_index[q] = 2;
                                    break;
                                case 6:
                                    r_index[q] = 5;
                                    c_index[q] = 0;
                                    break;
                                case 7:
                                    r_index[q] = 5;
                                    c_index[q] = 1;
                                    break;
                                case 8:
                                    r_index[q] = 5;
                                    c_index[q] = 2;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 4:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 3;
                                    c_index[q] = 3;
                                    break;
                                case 1:
                                    r_index[q] = 3;
                                    c_index[q] = 4;
                                    break;
                                case 2:
                                    r_index[q] = 3;
                                    c_index[q] = 5;
                                    break;
                                case 3:
                                    r_index[q] = 4;
                                    c_index[q] = 3;
                                    break;
                                case 4:
                                    r_index[q] = 4;
                                    c_index[q] = 4;
                                    break;
                                case 5:
                                    r_index[q] = 4;
                                    c_index[q] = 5;
                                    break;
                                case 6:
                                    r_index[q] = 5;
                                    c_index[q] = 3;
                                    break;
                                case 7:
                                    r_index[q] = 5;
                                    c_index[q] = 4;
                                    break;
                                case 8:
                                    r_index[q] = 5;
                                    c_index[q] = 5;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 5:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 3;
                                    c_index[q] = 6;
                                    break;
                                case 1:
                                    r_index[q] = 3;
                                    c_index[q] = 7;
                                    break;
                                case 2:
                                    r_index[q] = 3;
                                    c_index[q] = 8;
                                    break;
                                case 3:
                                    r_index[q] = 4;
                                    c_index[q] = 6;
                                    break;
                                case 4:
                                    r_index[q] = 4;
                                    c_index[q] = 7;
                                    break;
                                case 5:
                                    r_index[q] = 4;
                                    c_index[q] = 8;
                                    break;
                                case 6:
                                    r_index[q] = 5;
                                    c_index[q] = 6;
                                    break;
                                case 7:
                                    r_index[q] = 5;
                                    c_index[q] = 7;
                                    break;
                                case 8:
                                    r_index[q] = 5;
                                    c_index[q] = 8;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 6:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 6;
                                    c_index[q] = 0;
                                    break;
                                case 1:
                                    r_index[q] = 6;
                                    c_index[q] = 1;
                                    break;
                                case 2:
                                    r_index[q] = 6;
                                    c_index[q] = 2;
                                    break;
                                case 3:
                                    r_index[q] = 7;
                                    c_index[q] = 0;
                                    break;
                                case 4:
                                    r_index[q] = 7;
                                    c_index[q] = 1;
                                    break;
                                case 5:
                                    r_index[q] = 7;
                                    c_index[q] = 2;
                                    break;
                                case 6:
                                    r_index[q] = 8;
                                    c_index[q] = 0;
                                    break;
                                case 7:
                                    r_index[q] = 8;
                                    c_index[q] = 1;
                                    break;
                                case 8:
                                    r_index[q] = 8;
                                    c_index[q] = 2;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 7:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 6;
                                    c_index[q] = 3;
                                    break;
                                case 1:
                                    r_index[q] = 6;
                                    c_index[q] = 4;
                                    break;
                                case 2:
                                    r_index[q] = 6;
                                    c_index[q] = 5;
                                    break;
                                case 3:
                                    r_index[q] = 7;
                                    c_index[q] = 3;
                                    break;
                                case 4:
                                    r_index[q] = 7;
                                    c_index[q] = 4;
                                    break;
                                case 5:
                                    r_index[q] = 7;
                                    c_index[q] = 5;
                                    break;
                                case 6:
                                    r_index[q] = 8;
                                    c_index[q] = 3;
                                    break;
                                case 7:
                                    r_index[q] = 8;
                                    c_index[q] = 4;
                                    break;
                                case 8:
                                    r_index[q] = 8;
                                    c_index[q] = 5;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 8:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 6;
                                    c_index[q] = 6;
                                    break;
                                case 1:
                                    r_index[q] = 6;
                                    c_index[q] = 7;
                                    break;
                                case 2:
                                    r_index[q] = 6;
                                    c_index[q] = 8;
                                    break;
                                case 3:
                                    r_index[q] = 7;
                                    c_index[q] = 6;
                                    break;
                                case 4:
                                    r_index[q] = 7;
                                    c_index[q] = 7;
                                    break;
                                case 5:
                                    r_index[q] = 7;
                                    c_index[q] = 8;
                                    break;
                                case 6:
                                    r_index[q] = 8;
                                    c_index[q] = 6;
                                    break;
                                case 7:
                                    r_index[q] = 8;
                                    c_index[q] = 7;
                                    break;
                                case 8:
                                    r_index[q] = 8;
                                    c_index[q] = 8;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Box number is impossible.");
                    break;
            }

            // We now have the number and locations of each zero.
            // Create and control the size of the possibility-tracking matrix.
            bool[][] possibilities = new bool[9][];
            possibilities[0] = new bool[9];
            possibilities[1] = new bool[9];
            possibilities[2] = new bool[9];
            possibilities[3] = new bool[9];
            possibilities[4] = new bool[9];
            possibilities[5] = new bool[9];
            possibilities[6] = new bool[9];
            possibilities[7] = new bool[9];
            possibilities[8] = new bool[9];

            bool change = false;

            // We need to set if a zero can be a one, a two, etc.
            bool one = false;
            bool two = false;
            bool three = false;
            bool four = false;
            bool five = false;
            bool six = false;
            bool seven = false;
            bool eight = false;
            bool nine = false;

            for (int w = 0; w < 9; w++)
            {
                if (zero_loc[w] != 1)
                {
                    continue;
                }
                else
                {
                    int[] row_time_saver = fakerow.getrows(r_index[w]);
                    int[] col_time_saver = fakecol.getcols(c_index[w]);

                    // Check if the row/column/box already has each number. ("Does this row/column/box already have a 1? Do they have a 2?", etc)
                    one = (fakerow.has_number(1, row_time_saver) || fakecol.has_number(1, col_time_saver) || fakebox.has_number(1, box_time_saver));
                    two = (fakerow.has_number(2, row_time_saver) || fakecol.has_number(2, col_time_saver) || fakebox.has_number(2, box_time_saver));
                    three = (fakerow.has_number(3, row_time_saver) || fakecol.has_number(3, col_time_saver) || fakebox.has_number(3, box_time_saver));
                    four = (fakerow.has_number(4, row_time_saver) || fakecol.has_number(4, col_time_saver) || fakebox.has_number(4, box_time_saver));
                    five = (fakerow.has_number(5, row_time_saver) || fakecol.has_number(5, col_time_saver) || fakebox.has_number(5, box_time_saver));
                    six = (fakerow.has_number(6, row_time_saver) || fakecol.has_number(6, col_time_saver) || fakebox.has_number(6, box_time_saver));
                    seven = (fakerow.has_number(7, row_time_saver) || fakecol.has_number(7, col_time_saver) || fakebox.has_number(7, box_time_saver));
                    eight = (fakerow.has_number(8, row_time_saver) || fakecol.has_number(8, col_time_saver) || fakebox.has_number(8, box_time_saver));
                    nine = (fakerow.has_number(9, row_time_saver) || fakecol.has_number(9, col_time_saver) || fakebox.has_number(9, box_time_saver));

                    // Set the matrix of possbilities for each zero in our box.
                    possibilities[w] = [!one, !two, !three, !four, !five, !six, !seven, !eight, !nine];
                }
            }

            // Determine the number of zeros that can be a given number (3 zeros could be a 1, 1 zero could be a 4, etc).
            int alpha = 0;
            int beta = 0;
            int gamma = 0;
            int delta = 0;
            int epsilon = 0;
            int zeta = 0;
            int eta = 0;
            int theta = 0;
            int iota = 0;

            for (int e = 0; e < 9; e++)
            {
                if (possibilities[e][0])
                {
                    alpha += 1;
                }
                if (possibilities[e][1])
                {
                    beta += 1;
                }
                if (possibilities[e][2])
                {
                    gamma += 1;
                }
                if (possibilities[e][3])
                {
                    delta += 1;
                }
                if (possibilities[e][4])
                {
                    epsilon += 1;
                }
                if (possibilities[e][5])
                {
                    zeta += 1;
                }
                if (possibilities[e][6])
                {
                    eta += 1;
                }
                if (possibilities[e][7])
                {
                    theta += 1;
                }
                if (possibilities[e][8])
                {
                    iota += 1;
                }
            }

            // Replace anything that can only be one thing.
            if (alpha == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][0])
                    {
                        box_time_saver[r] = 1;
                        fakebox.setboxs(box_num, box_time_saver);
                        change = true;
                    }
                }
            }
            if (beta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][1])
                    {
                        box_time_saver[r] = 2;
                        fakebox.setboxs(box_num, box_time_saver);
                        change = true;
                    }
                }
            }
            if (gamma == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][2])
                    {
                        box_time_saver[r] = 3;
                        fakebox.setboxs(box_num, box_time_saver);
                        change = true;
                    }
                }
            }
            if (delta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][3])
                    {
                        box_time_saver[r] = 4;
                        fakebox.setboxs(box_num, box_time_saver);
                        change = true;
                    }
                }
            }
            if (epsilon == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][4])
                    {
                        box_time_saver[r] = 5;
                        fakebox.setboxs(box_num, box_time_saver);
                        change = true;
                    }
                }
            }
            if (zeta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][5])
                    {
                        box_time_saver[r] = 6;
                        fakebox.setboxs(box_num, box_time_saver);
                        change = true;
                    }
                }
            }
            if (eta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][6])
                    {
                        box_time_saver[r] = 7;
                        fakebox.setboxs(box_num, box_time_saver);
                        change = true;
                    }
                }
            }
            if (theta == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][7])
                    {
                        box_time_saver[r] = 8;
                        fakebox.setboxs(box_num, box_time_saver);
                        change = true;
                    }
                }
            }
            if (iota == 1)
            {
                for (int r = 0; r < 9; r++)
                {
                    if (possibilities[r][8])
                    {
                        box_time_saver[r] = 9;
                        fakebox.setboxs(box_num, box_time_saver);
                        change = true;
                    }
                }
            }

            if (change == true)
            {
                return (true, fakebox);
            }
            else
            {
                return (false, fakebox);
            }
        }

        public (bool, int[][]) intermediate_inference_checking(Rows fakerow, Cols fakecol, Boxs fakebox, int box_num)
        {
            /*
             * This is designed to check via inferred knowledge.
             * Let's say only the last row of a box can be a 3, then we use that inferred 3 to check other boxes
             * horizontal to the first. If only the middle column of a box can be a 5, then we use that inferred 
             * 5 to check other boxes vertical to the first.
             */

            // Create a box to contain our assertion, and give it all the values of a real box.
            Boxs throwawaybox = new Boxs();

            for (int i = 0; i < 9; i++)
            {
                throwawaybox.setboxs(i, fakebox.getboxs(i));
            }

            // Determine what assertion to make, and assign it to the first element. Actual location doesn't matter.
            // This begins with finding possibilities.
            int[] box_time_saver = throwawaybox.getboxs(box_num);

            int num_zeros = count_zeros(box_time_saver);
            int[] zero_loc = where_zeros(box_time_saver);

            int[] r_index = new int[9];
            int[] c_index = new int[9];

            r_index = [9, 9, 9, 9, 9, 9, 9, 9, 9];
            c_index = [9, 9, 9, 9, 9, 9, 9, 9, 9];

            switch (box_num)
            {
                case 0:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 0;
                                    c_index[q] = 0;
                                    break;
                                case 1:
                                    r_index[q] = 0;
                                    c_index[q] = 1;
                                    break;
                                case 2:
                                    r_index[q] = 0;
                                    c_index[q] = 2;
                                    break;
                                case 3:
                                    r_index[q] = 1;
                                    c_index[q] = 0;
                                    break;
                                case 4:
                                    r_index[q] = 1;
                                    c_index[q] = 1;
                                    break;
                                case 5:
                                    r_index[q] = 1;
                                    c_index[q] = 2;
                                    break;
                                case 6:
                                    r_index[q] = 2;
                                    c_index[q] = 0;
                                    break;
                                case 7:
                                    r_index[q] = 2;
                                    c_index[q] = 1;
                                    break;
                                case 8:
                                    r_index[q] = 2;
                                    c_index[q] = 2;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 1:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 0;
                                    c_index[q] = 3;
                                    break;
                                case 1:
                                    r_index[q] = 0;
                                    c_index[q] = 4;
                                    break;
                                case 2:
                                    r_index[q] = 0;
                                    c_index[q] = 5;
                                    break;
                                case 3:
                                    r_index[q] = 1;
                                    c_index[q] = 3;
                                    break;
                                case 4:
                                    r_index[q] = 1;
                                    c_index[q] = 4;
                                    break;
                                case 5:
                                    r_index[q] = 1;
                                    c_index[q] = 5;
                                    break;
                                case 6:
                                    r_index[q] = 2;
                                    c_index[q] = 3;
                                    break;
                                case 7:
                                    r_index[q] = 2;
                                    c_index[q] = 4;
                                    break;
                                case 8:
                                    r_index[q] = 2;
                                    c_index[q] = 5;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 2:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 0;
                                    c_index[q] = 6;
                                    break;
                                case 1:
                                    r_index[q] = 0;
                                    c_index[q] = 7;
                                    break;
                                case 2:
                                    r_index[q] = 0;
                                    c_index[q] = 8;
                                    break;
                                case 3:
                                    r_index[q] = 1;
                                    c_index[q] = 6;
                                    break;
                                case 4:
                                    r_index[q] = 1;
                                    c_index[q] = 7;
                                    break;
                                case 5:
                                    r_index[q] = 1;
                                    c_index[q] = 8;
                                    break;
                                case 6:
                                    r_index[q] = 2;
                                    c_index[q] = 6;
                                    break;
                                case 7:
                                    r_index[q] = 2;
                                    c_index[q] = 7;
                                    break;
                                case 8:
                                    r_index[q] = 2;
                                    c_index[q] = 8;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 3:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 3;
                                    c_index[q] = 0;
                                    break;
                                case 1:
                                    r_index[q] = 3;
                                    c_index[q] = 1;
                                    break;
                                case 2:
                                    r_index[q] = 3;
                                    c_index[q] = 2;
                                    break;
                                case 3:
                                    r_index[q] = 4;
                                    c_index[q] = 0;
                                    break;
                                case 4:
                                    r_index[q] = 4;
                                    c_index[q] = 1;
                                    break;
                                case 5:
                                    r_index[q] = 4;
                                    c_index[q] = 2;
                                    break;
                                case 6:
                                    r_index[q] = 5;
                                    c_index[q] = 0;
                                    break;
                                case 7:
                                    r_index[q] = 5;
                                    c_index[q] = 1;
                                    break;
                                case 8:
                                    r_index[q] = 5;
                                    c_index[q] = 2;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 4:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 3;
                                    c_index[q] = 3;
                                    break;
                                case 1:
                                    r_index[q] = 3;
                                    c_index[q] = 4;
                                    break;
                                case 2:
                                    r_index[q] = 3;
                                    c_index[q] = 5;
                                    break;
                                case 3:
                                    r_index[q] = 4;
                                    c_index[q] = 3;
                                    break;
                                case 4:
                                    r_index[q] = 4;
                                    c_index[q] = 4;
                                    break;
                                case 5:
                                    r_index[q] = 4;
                                    c_index[q] = 5;
                                    break;
                                case 6:
                                    r_index[q] = 5;
                                    c_index[q] = 3;
                                    break;
                                case 7:
                                    r_index[q] = 5;
                                    c_index[q] = 4;
                                    break;
                                case 8:
                                    r_index[q] = 5;
                                    c_index[q] = 5;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 5:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 3;
                                    c_index[q] = 6;
                                    break;
                                case 1:
                                    r_index[q] = 3;
                                    c_index[q] = 7;
                                    break;
                                case 2:
                                    r_index[q] = 3;
                                    c_index[q] = 8;
                                    break;
                                case 3:
                                    r_index[q] = 4;
                                    c_index[q] = 6;
                                    break;
                                case 4:
                                    r_index[q] = 4;
                                    c_index[q] = 7;
                                    break;
                                case 5:
                                    r_index[q] = 4;
                                    c_index[q] = 8;
                                    break;
                                case 6:
                                    r_index[q] = 5;
                                    c_index[q] = 6;
                                    break;
                                case 7:
                                    r_index[q] = 5;
                                    c_index[q] = 7;
                                    break;
                                case 8:
                                    r_index[q] = 5;
                                    c_index[q] = 8;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 6:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 6;
                                    c_index[q] = 0;
                                    break;
                                case 1:
                                    r_index[q] = 6;
                                    c_index[q] = 1;
                                    break;
                                case 2:
                                    r_index[q] = 6;
                                    c_index[q] = 2;
                                    break;
                                case 3:
                                    r_index[q] = 7;
                                    c_index[q] = 0;
                                    break;
                                case 4:
                                    r_index[q] = 7;
                                    c_index[q] = 1;
                                    break;
                                case 5:
                                    r_index[q] = 7;
                                    c_index[q] = 2;
                                    break;
                                case 6:
                                    r_index[q] = 8;
                                    c_index[q] = 0;
                                    break;
                                case 7:
                                    r_index[q] = 8;
                                    c_index[q] = 1;
                                    break;
                                case 8:
                                    r_index[q] = 8;
                                    c_index[q] = 2;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 7:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 6;
                                    c_index[q] = 3;
                                    break;
                                case 1:
                                    r_index[q] = 6;
                                    c_index[q] = 4;
                                    break;
                                case 2:
                                    r_index[q] = 6;
                                    c_index[q] = 5;
                                    break;
                                case 3:
                                    r_index[q] = 7;
                                    c_index[q] = 3;
                                    break;
                                case 4:
                                    r_index[q] = 7;
                                    c_index[q] = 4;
                                    break;
                                case 5:
                                    r_index[q] = 7;
                                    c_index[q] = 5;
                                    break;
                                case 6:
                                    r_index[q] = 8;
                                    c_index[q] = 3;
                                    break;
                                case 7:
                                    r_index[q] = 8;
                                    c_index[q] = 4;
                                    break;
                                case 8:
                                    r_index[q] = 8;
                                    c_index[q] = 5;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                case 8:
                    for (int q = 0; q < 9; q++)
                    {
                        if (zero_loc[q] == 1)
                        {
                            switch (q)
                            {
                                case 0:
                                    r_index[q] = 6;
                                    c_index[q] = 6;
                                    break;
                                case 1:
                                    r_index[q] = 6;
                                    c_index[q] = 7;
                                    break;
                                case 2:
                                    r_index[q] = 6;
                                    c_index[q] = 8;
                                    break;
                                case 3:
                                    r_index[q] = 7;
                                    c_index[q] = 6;
                                    break;
                                case 4:
                                    r_index[q] = 7;
                                    c_index[q] = 7;
                                    break;
                                case 5:
                                    r_index[q] = 7;
                                    c_index[q] = 8;
                                    break;
                                case 6:
                                    r_index[q] = 8;
                                    c_index[q] = 6;
                                    break;
                                case 7:
                                    r_index[q] = 8;
                                    c_index[q] = 7;
                                    break;
                                case 8:
                                    r_index[q] = 8;
                                    c_index[q] = 8;
                                    break;
                                default:
                                    MessageBox.Show("potential checking okashii.");
                                    break;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Box number is impossible.");
                    break;
            }

            // We now have the number and locations of each zero.
            // Create and control the size of the possibility-tracking matrix.
            bool[][] possibilities = new bool[9][];
            possibilities[0] = new bool[9];
            possibilities[1] = new bool[9];
            possibilities[2] = new bool[9];
            possibilities[3] = new bool[9];
            possibilities[4] = new bool[9];
            possibilities[5] = new bool[9];
            possibilities[6] = new bool[9];
            possibilities[7] = new bool[9];
            possibilities[8] = new bool[9];

            bool change = false;
            bool r_assert = false;
            bool c_assert = false;

            // We need to set if a zero can be a one, a two, etc.
            bool one = false;
            bool two = false;
            bool three = false;
            bool four = false;
            bool five = false;
            bool six = false;
            bool seven = false;
            bool eight = false;
            bool nine = false;

            for (int w = 0; w < 9; w++)
            {
                if (zero_loc[w] != 1)
                {
                    continue;
                }
                else
                {
                    int[] row_time_saver = fakerow.getrows(r_index[w]);
                    int[] col_time_saver = fakecol.getcols(c_index[w]);

                    // Check if the row/column/box already has each number. ("Does this row/column/box already have a 1? Do they have a 2?", etc)
                    one = (fakerow.has_number(1, row_time_saver) || fakecol.has_number(1, col_time_saver) || fakebox.has_number(1, box_time_saver));
                    two = (fakerow.has_number(2, row_time_saver) || fakecol.has_number(2, col_time_saver) || fakebox.has_number(2, box_time_saver));
                    three = (fakerow.has_number(3, row_time_saver) || fakecol.has_number(3, col_time_saver) || fakebox.has_number(3, box_time_saver));
                    four = (fakerow.has_number(4, row_time_saver) || fakecol.has_number(4, col_time_saver) || fakebox.has_number(4, box_time_saver));
                    five = (fakerow.has_number(5, row_time_saver) || fakecol.has_number(5, col_time_saver) || fakebox.has_number(5, box_time_saver));
                    six = (fakerow.has_number(6, row_time_saver) || fakecol.has_number(6, col_time_saver) || fakebox.has_number(6, box_time_saver));
                    seven = (fakerow.has_number(7, row_time_saver) || fakecol.has_number(7, col_time_saver) || fakebox.has_number(7, box_time_saver));
                    eight = (fakerow.has_number(8, row_time_saver) || fakecol.has_number(8, col_time_saver) || fakebox.has_number(8, box_time_saver));
                    nine = (fakerow.has_number(9, row_time_saver) || fakecol.has_number(9, col_time_saver) || fakebox.has_number(9, box_time_saver));

                    // Set the matrix of possbilities for each zero in our box.
                    possibilities[w] = [!one, !two, !three, !four, !five, !six, !seven, !eight, !nine];
                }
            }

            // Determine if any possibilities are restricted to a single row. If so, make the appropriate row assertion.
            if ((possibilities[0][0] == true || possibilities[1][0] == true || possibilities[2][0] == true) && possibilities[3][0] == false && possibilities[4][0] == false && possibilities[5][0] == false && possibilities[6][0] == false && possibilities[7][0] == false && possibilities[8][0] == false)
            {
                box_time_saver[0] = 1;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][0] == false && possibilities[1][0] == false && possibilities[2][0] == false && (possibilities[3][0] == true || possibilities[4][0] == true || possibilities[5][0] == true) && possibilities[6][0] == false && possibilities[7][0] == false && possibilities[8][0] == false)
            {
                box_time_saver[3] = 1;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][0] == false && possibilities[1][0] == false && possibilities[2][0] == false && possibilities[3][0] == false && possibilities[4][0] == false && possibilities[5][0] == false && (possibilities[6][0] == true || possibilities[7][0] == true || possibilities[8][0] == true))
            {
                box_time_saver[6] = 1;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if ((possibilities[0][1] == true || possibilities[1][1] == true || possibilities[2][1] == true) && possibilities[3][1] == false && possibilities[4][1] == false && possibilities[5][1] == false && possibilities[6][1] == false && possibilities[7][1] == false && possibilities[8][1] == false)
            {
                box_time_saver[0] = 2;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][1] == false && possibilities[1][1] == false && possibilities[2][1] == false && (possibilities[3][1] == true || possibilities[4][1] == true || possibilities[5][1] == true) && possibilities[6][1] == false && possibilities[7][1] == false && possibilities[8][1] == false)
            {
                box_time_saver[3] = 2;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][1] == false && possibilities[1][1] == false && possibilities[2][1] == false && possibilities[3][1] == false && possibilities[4][1] == false && possibilities[5][1] == false && (possibilities[6][1] == true || possibilities[7][1] == true || possibilities[8][1] == true))
            {
                box_time_saver[6] = 2;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if ((possibilities[0][2] == true || possibilities[1][2] == true || possibilities[2][2] == true) && possibilities[3][2] == false && possibilities[4][2] == false && possibilities[5][2] == false && possibilities[6][2] == false && possibilities[7][2] == false && possibilities[8][2] == false)
            {
                box_time_saver[0] = 3;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][2] == false && possibilities[1][2] == false && possibilities[2][2] == false && (possibilities[3][2] == true || possibilities[4][2] == true || possibilities[5][2] == true) && possibilities[6][2] == false && possibilities[7][2] == false && possibilities[8][2] == false)
            {
                box_time_saver[3] = 3;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][2] == false && possibilities[1][2] == false && possibilities[2][2] == false && possibilities[3][2] == false && possibilities[4][2] == false && possibilities[5][2] == false && (possibilities[6][2] == true || possibilities[7][2] == true || possibilities[8][2] == true))
            {
                box_time_saver[6] = 3;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if ((possibilities[0][3] == true || possibilities[1][3] == true || possibilities[2][3] == true) && possibilities[3][3] == false && possibilities[4][3] == false && possibilities[5][3] == false && possibilities[6][3] == false && possibilities[7][3] == false && possibilities[8][3] == false)
            {
                box_time_saver[0] = 4;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][3] == false && possibilities[1][3] == false && possibilities[2][3] == false && (possibilities[3][3] == true || possibilities[4][3] == true || possibilities[5][3] == true) && possibilities[6][3] == false && possibilities[7][3] == false && possibilities[8][3] == false)
            {
                box_time_saver[3] = 4;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][3] == false && possibilities[1][3] == false && possibilities[2][3] == false && possibilities[3][3] == false && possibilities[4][3] == false && possibilities[5][3] == false && (possibilities[6][3] == true || possibilities[7][3] == true || possibilities[8][3] == true))
            {
                box_time_saver[6] = 4;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if ((possibilities[0][4] == true || possibilities[1][4] == true || possibilities[2][4] == true) && possibilities[3][4] == false && possibilities[4][4] == false && possibilities[5][4] == false && possibilities[6][4] == false && possibilities[7][4] == false && possibilities[8][4] == false)
            {
                box_time_saver[0] = 5;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][4] == false && possibilities[1][4] == false && possibilities[2][4] == false && (possibilities[3][4] == true || possibilities[4][4] == true || possibilities[5][4] == true) && possibilities[6][4] == false && possibilities[7][4] == false && possibilities[8][4] == false)
            {
                box_time_saver[3] = 5;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][4] == false && possibilities[1][4] == false && possibilities[2][4] == false && possibilities[3][4] == false && possibilities[4][4] == false && possibilities[5][4] == false && (possibilities[6][4] == true || possibilities[7][4] == true || possibilities[8][4] == true))
            {
                box_time_saver[6] = 5;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if ((possibilities[0][5] == true || possibilities[1][5] == true || possibilities[2][5] == true) && possibilities[3][5] == false && possibilities[4][5] == false && possibilities[5][5] == false && possibilities[6][5] == false && possibilities[7][5] == false && possibilities[8][5] == false)
            {
                box_time_saver[0] = 6;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][5] == false && possibilities[1][5] == false && possibilities[2][5] == false && (possibilities[3][5] == true || possibilities[4][5] == true || possibilities[5][5] == true) && possibilities[6][5] == false && possibilities[7][5] == false && possibilities[8][5] == false)
            {
                box_time_saver[3] = 6;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][5] == false && possibilities[1][5] == false && possibilities[2][5] == false && possibilities[3][5] == false && possibilities[4][5] == false && possibilities[5][5] == false && (possibilities[6][5] == true || possibilities[7][5] == true || possibilities[8][5] == true))
            {
                box_time_saver[6] = 6;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if ((possibilities[0][6] == true || possibilities[1][6] == true || possibilities[2][6] == true) && possibilities[3][6] == false && possibilities[4][6] == false && possibilities[5][6] == false && possibilities[6][6] == false && possibilities[7][6] == false && possibilities[8][6] == false)
            {
                box_time_saver[0] = 7;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][6] == false && possibilities[1][6] == false && possibilities[2][6] == false && (possibilities[3][6] == true || possibilities[4][6] == true || possibilities[5][6] == true) && possibilities[6][6] == false && possibilities[7][6] == false && possibilities[8][6] == false)
            {
                box_time_saver[3] = 7;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][6] == false && possibilities[1][6] == false && possibilities[2][6] == false && possibilities[3][6] == false && possibilities[4][6] == false && possibilities[5][6] == false && (possibilities[6][6] == true || possibilities[7][6] == true || possibilities[8][6] == true))
            {
                box_time_saver[6] = 7;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if ((possibilities[0][7] == true || possibilities[1][7] == true || possibilities[2][7] == true) && possibilities[3][7] == false && possibilities[4][7] == false && possibilities[5][7] == false && possibilities[6][7] == false && possibilities[7][7] == false && possibilities[8][7] == false)
            {
                box_time_saver[0] = 8;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][7] == false && possibilities[1][7] == false && possibilities[2][7] == false && (possibilities[3][7] == true || possibilities[4][7] == true || possibilities[5][7] == true) && possibilities[6][7] == false && possibilities[7][7] == false && possibilities[8][7] == false)
            {
                box_time_saver[3] = 8;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][7] == false && possibilities[1][7] == false && possibilities[2][7] == false && possibilities[3][7] == false && possibilities[4][7] == false && possibilities[5][7] == false && (possibilities[6][7] == true || possibilities[7][7] == true || possibilities[8][7] == true))
            {
                box_time_saver[6] = 8;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if ((possibilities[0][8] == true || possibilities[1][8] == true || possibilities[2][8] == true) && possibilities[3][8] == false && possibilities[4][8] == false && possibilities[5][8] == false && possibilities[6][8] == false && possibilities[7][8] == false && possibilities[8][8] == false)
            {
                box_time_saver[0] = 9;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][8] == false && possibilities[1][8] == false && possibilities[2][8] == false && (possibilities[3][8] == true || possibilities[4][8] == true || possibilities[5][8] == true) && possibilities[6][8] == false && possibilities[7][8] == false && possibilities[8][8] == false)
            {
                box_time_saver[3] = 9;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }
            else if (possibilities[0][8] == false && possibilities[1][8] == false && possibilities[2][8] == false && possibilities[3][8] == false && possibilities[4][8] == false && possibilities[5][8] == false && (possibilities[6][8] == true || possibilities[7][8] == true || possibilities[8][8] == true))
            {
                box_time_saver[6] = 9;
                throwawaybox.setboxs(box_num, box_time_saver);
                r_assert = true;
            }

            // If we can make a row assertion, then check the other boxes horizontal to ours.
            if (r_assert)
            {
                switch (box_num)
                {
                    case 0:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 1);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 2);
                            break;
                        }
                    case 1:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 0);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 2);
                            break;
                        }
                    case 2:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 0);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 1);
                            break;
                        }
                    case 3:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 4);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 5);
                            break;
                        }
                    case 4:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 3);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 5);
                            break;
                        }
                    case 5:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 3);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 4);
                            break;
                        }
                    case 6:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 7);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 8);
                            break;
                        }
                    case 7:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 6);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 8);
                            break;
                        }
                    case 8:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 6);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 7);
                            break;
                        }
                    default:
                        MessageBox.Show("Something is weird with inference row checking.");
                        break;
                }

                if (change)
                {
                    if ((possibilities[0][0] == true || possibilities[1][0] == true || possibilities[2][0] == true) && possibilities[3][0] == false && possibilities[4][0] == false && possibilities[5][0] == false && possibilities[6][0] == false && possibilities[7][0] == false && possibilities[8][0] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][0] == false && possibilities[1][0] == false && possibilities[2][0] == false && (possibilities[3][0] == true || possibilities[4][0] == true || possibilities[5][0] == true) && possibilities[6][0] == false && possibilities[7][0] == false && possibilities[8][0] == false)
                    {
                        box_time_saver[3] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][0] == false && possibilities[1][0] == false && possibilities[2][0] == false && possibilities[3][0] == false && possibilities[4][0] == false && possibilities[5][0] == false && (possibilities[6][0] == true || possibilities[7][0] == true || possibilities[8][0] == true))
                    {
                        box_time_saver[6] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][1] == true || possibilities[1][1] == true || possibilities[2][1] == true) && possibilities[3][1] == false && possibilities[4][1] == false && possibilities[5][1] == false && possibilities[6][1] == false && possibilities[7][1] == false && possibilities[8][1] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][1] == false && possibilities[1][1] == false && possibilities[2][1] == false && (possibilities[3][1] == true || possibilities[4][1] == true || possibilities[5][1] == true) && possibilities[6][1] == false && possibilities[7][1] == false && possibilities[8][1] == false)
                    {
                        box_time_saver[3] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][1] == false && possibilities[1][1] == false && possibilities[2][1] == false && possibilities[3][1] == false && possibilities[4][1] == false && possibilities[5][1] == false && (possibilities[6][1] == true || possibilities[7][1] == true || possibilities[8][1] == true))
                    {
                        box_time_saver[6] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][2] == true || possibilities[1][2] == true || possibilities[2][2] == true) && possibilities[3][2] == false && possibilities[4][2] == false && possibilities[5][2] == false && possibilities[6][2] == false && possibilities[7][2] == false && possibilities[8][2] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][2] == false && possibilities[1][2] == false && possibilities[2][2] == false && (possibilities[3][2] == true || possibilities[4][2] == true || possibilities[5][2] == true) && possibilities[6][2] == false && possibilities[7][2] == false && possibilities[8][2] == false)
                    {
                        box_time_saver[3] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][2] == false && possibilities[1][2] == false && possibilities[2][2] == false && possibilities[3][2] == false && possibilities[4][2] == false && possibilities[5][2] == false && (possibilities[6][2] == true || possibilities[7][2] == true || possibilities[8][2] == true))
                    {
                        box_time_saver[6] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][3] == true || possibilities[1][3] == true || possibilities[2][3] == true) && possibilities[3][3] == false && possibilities[4][3] == false && possibilities[5][3] == false && possibilities[6][3] == false && possibilities[7][3] == false && possibilities[8][3] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][3] == false && possibilities[1][3] == false && possibilities[2][3] == false && (possibilities[3][3] == true || possibilities[4][3] == true || possibilities[5][3] == true) && possibilities[6][3] == false && possibilities[7][3] == false && possibilities[8][3] == false)
                    {
                        box_time_saver[3] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][3] == false && possibilities[1][3] == false && possibilities[2][3] == false && possibilities[3][3] == false && possibilities[4][3] == false && possibilities[5][3] == false && (possibilities[6][3] == true || possibilities[7][3] == true || possibilities[8][3] == true))
                    {
                        box_time_saver[6] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][4] == true || possibilities[1][4] == true || possibilities[2][4] == true) && possibilities[3][4] == false && possibilities[4][4] == false && possibilities[5][4] == false && possibilities[6][4] == false && possibilities[7][4] == false && possibilities[8][4] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][4] == false && possibilities[1][4] == false && possibilities[2][4] == false && (possibilities[3][4] == true || possibilities[4][4] == true || possibilities[5][4] == true) && possibilities[6][4] == false && possibilities[7][4] == false && possibilities[8][4] == false)
                    {
                        box_time_saver[3] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][4] == false && possibilities[1][4] == false && possibilities[2][4] == false && possibilities[3][4] == false && possibilities[4][4] == false && possibilities[5][4] == false && (possibilities[6][4] == true || possibilities[7][4] == true || possibilities[8][4] == true))
                    {
                        box_time_saver[6] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][5] == true || possibilities[1][5] == true || possibilities[2][5] == true) && possibilities[3][5] == false && possibilities[4][5] == false && possibilities[5][5] == false && possibilities[6][5] == false && possibilities[7][5] == false && possibilities[8][5] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][5] == false && possibilities[1][5] == false && possibilities[2][5] == false && (possibilities[3][5] == true || possibilities[4][5] == true || possibilities[5][5] == true) && possibilities[6][5] == false && possibilities[7][5] == false && possibilities[8][5] == false)
                    {
                        box_time_saver[3] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][5] == false && possibilities[1][5] == false && possibilities[2][5] == false && possibilities[3][5] == false && possibilities[4][5] == false && possibilities[5][5] == false && (possibilities[6][5] == true || possibilities[7][5] == true || possibilities[8][5] == true))
                    {
                        box_time_saver[6] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][6] == true || possibilities[1][6] == true || possibilities[2][6] == true) && possibilities[3][6] == false && possibilities[4][6] == false && possibilities[5][6] == false && possibilities[6][6] == false && possibilities[7][6] == false && possibilities[8][6] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][6] == false && possibilities[1][6] == false && possibilities[2][6] == false && (possibilities[3][6] == true || possibilities[4][6] == true || possibilities[5][6] == true) && possibilities[6][6] == false && possibilities[7][6] == false && possibilities[8][6] == false)
                    {
                        box_time_saver[3] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][6] == false && possibilities[1][6] == false && possibilities[2][6] == false && possibilities[3][6] == false && possibilities[4][6] == false && possibilities[5][6] == false && (possibilities[6][6] == true || possibilities[7][6] == true || possibilities[8][6] == true))
                    {
                        box_time_saver[6] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][7] == true || possibilities[1][7] == true || possibilities[2][7] == true) && possibilities[3][7] == false && possibilities[4][7] == false && possibilities[5][7] == false && possibilities[6][7] == false && possibilities[7][7] == false && possibilities[8][7] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][7] == false && possibilities[1][7] == false && possibilities[2][7] == false && (possibilities[3][7] == true || possibilities[4][7] == true || possibilities[5][7] == true) && possibilities[6][7] == false && possibilities[7][7] == false && possibilities[8][7] == false)
                    {
                        box_time_saver[3] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][7] == false && possibilities[1][7] == false && possibilities[2][7] == false && possibilities[3][7] == false && possibilities[4][7] == false && possibilities[5][7] == false && (possibilities[6][7] == true || possibilities[7][7] == true || possibilities[8][7] == true))
                    {
                        box_time_saver[6] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][8] == true || possibilities[1][8] == true || possibilities[2][8] == true) && possibilities[3][8] == false && possibilities[4][8] == false && possibilities[5][8] == false && possibilities[6][8] == false && possibilities[7][8] == false && possibilities[8][8] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][8] == false && possibilities[1][8] == false && possibilities[2][8] == false && (possibilities[3][8] == true || possibilities[4][8] == true || possibilities[5][8] == true) && possibilities[6][8] == false && possibilities[7][8] == false && possibilities[8][8] == false)
                    {
                        box_time_saver[3] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][8] == false && possibilities[1][8] == false && possibilities[2][8] == false && possibilities[3][8] == false && possibilities[4][8] == false && possibilities[5][8] == false && (possibilities[6][8] == true || possibilities[7][8] == true || possibilities[8][8] == true))
                    {
                        box_time_saver[6] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                }
            }

            // Determine if any possibilities are restricted to a single column. If so, make the appropriate column assertion.
            if ((possibilities[0][0] == true || possibilities[3][0] == true || possibilities[6][0] == true) && possibilities[1][0] == false && possibilities[2][0] == false && possibilities[4][0] == false && possibilities[5][0] == false && possibilities[7][0] == false && possibilities[8][0] == false)
            {
                box_time_saver[0] = 1;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][0] == false && possibilities[2][0] == false && possibilities[3][0] == false && (possibilities[1][0] == true || possibilities[4][0] == true || possibilities[7][0] == true) && possibilities[5][0] == false && possibilities[6][0] == false && possibilities[8][0] == false)
            {
                box_time_saver[1] = 1;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][0] == false && possibilities[1][0] == false && possibilities[3][0] == false && possibilities[4][0] == false && possibilities[6][0] == false && possibilities[7][0] == false && (possibilities[2][0] == true || possibilities[5][0] == true || possibilities[8][0] == true))
            {
                box_time_saver[2] = 1;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if ((possibilities[0][1] == true || possibilities[3][1] == true || possibilities[6][1] == true) && possibilities[1][1] == false && possibilities[2][1] == false && possibilities[4][1] == false && possibilities[5][1] == false && possibilities[7][1] == false && possibilities[8][1] == false)
            {
                box_time_saver[0] = 2;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][1] == false && possibilities[2][1] == false && possibilities[3][1] == false && (possibilities[1][1] == true || possibilities[4][1] == true || possibilities[7][1] == true) && possibilities[5][1] == false && possibilities[6][1] == false && possibilities[8][1] == false)
            {
                box_time_saver[1] = 2;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][1] == false && possibilities[1][1] == false && possibilities[3][1] == false && possibilities[4][1] == false && possibilities[6][1] == false && possibilities[7][1] == false && (possibilities[2][1] == true || possibilities[5][1] == true || possibilities[8][1] == true))
            {
                box_time_saver[2] = 2;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if ((possibilities[0][2] == true || possibilities[3][2] == true || possibilities[6][2] == true) && possibilities[1][2] == false && possibilities[2][2] == false && possibilities[4][2] == false && possibilities[5][2] == false && possibilities[7][2] == false && possibilities[8][2] == false)
            {
                box_time_saver[0] = 3;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][2] == false && possibilities[2][2] == false && possibilities[3][2] == false && (possibilities[1][2] == true || possibilities[4][2] == true || possibilities[7][2] == true) && possibilities[5][2] == false && possibilities[6][2] == false && possibilities[8][2] == false)
            {
                box_time_saver[1] = 3;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][2] == false && possibilities[1][2] == false && possibilities[3][2] == false && possibilities[4][2] == false && possibilities[6][2] == false && possibilities[7][2] == false && (possibilities[2][2] == true || possibilities[5][2] == true || possibilities[8][2] == true))
            {
                box_time_saver[2] = 3;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if ((possibilities[0][3] == true || possibilities[3][3] == true || possibilities[6][3] == true) && possibilities[1][3] == false && possibilities[2][3] == false && possibilities[4][3] == false && possibilities[5][3] == false && possibilities[7][3] == false && possibilities[8][3] == false)
            {
                box_time_saver[0] = 4;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][3] == false && possibilities[2][3] == false && possibilities[3][3] == false && (possibilities[1][3] == true || possibilities[4][3] == true || possibilities[7][3] == true) && possibilities[5][3] == false && possibilities[6][3] == false && possibilities[8][3] == false)
            {
                box_time_saver[1] = 4;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][3] == false && possibilities[1][3] == false && possibilities[3][3] == false && possibilities[4][3] == false && possibilities[6][3] == false && possibilities[7][3] == false && (possibilities[2][3] == true || possibilities[5][3] == true || possibilities[8][3] == true))
            {
                box_time_saver[2] = 4;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if ((possibilities[0][4] == true || possibilities[3][4] == true || possibilities[6][4] == true) && possibilities[1][4] == false && possibilities[2][4] == false && possibilities[4][4] == false && possibilities[5][4] == false && possibilities[7][4] == false && possibilities[8][4] == false)
            {
                box_time_saver[0] = 5;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][4] == false && possibilities[2][4] == false && possibilities[3][4] == false && (possibilities[1][4] == true || possibilities[4][4] == true || possibilities[7][4] == true) && possibilities[5][4] == false && possibilities[6][4] == false && possibilities[8][4] == false)
            {
                box_time_saver[1] = 5;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][4] == false && possibilities[1][4] == false && possibilities[3][4] == false && possibilities[4][4] == false && possibilities[6][4] == false && possibilities[7][4] == false && (possibilities[2][4] == true || possibilities[5][4] == true || possibilities[8][4] == true))
            {
                box_time_saver[2] = 5;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if ((possibilities[0][5] == true || possibilities[3][5] == true || possibilities[6][5] == true) && possibilities[1][5] == false && possibilities[2][5] == false && possibilities[4][5] == false && possibilities[5][5] == false && possibilities[7][5] == false && possibilities[8][5] == false)
            {
                box_time_saver[0] = 6;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][5] == false && possibilities[2][5] == false && possibilities[3][5] == false && (possibilities[1][5] == true || possibilities[4][5] == true || possibilities[7][5] == true) && possibilities[5][5] == false && possibilities[6][5] == false && possibilities[8][5] == false)
            {
                box_time_saver[1] = 6;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][5] == false && possibilities[1][5] == false && possibilities[3][5] == false && possibilities[4][5] == false && possibilities[6][5] == false && possibilities[7][5] == false && (possibilities[2][5] == true || possibilities[5][5] == true || possibilities[8][5] == true))
            {
                box_time_saver[2] = 6;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if ((possibilities[0][6] == true || possibilities[3][6] == true || possibilities[6][6] == true) && possibilities[1][6] == false && possibilities[2][6] == false && possibilities[4][6] == false && possibilities[5][6] == false && possibilities[7][6] == false && possibilities[8][6] == false)
            {
                box_time_saver[0] = 7;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][6] == false && possibilities[2][6] == false && possibilities[3][6] == false && (possibilities[1][6] == true || possibilities[4][6] == true || possibilities[7][6] == true) && possibilities[5][6] == false && possibilities[6][6] == false && possibilities[8][6] == false)
            {
                box_time_saver[1] = 7;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][6] == false && possibilities[1][6] == false && possibilities[3][6] == false && possibilities[4][6] == false && possibilities[6][6] == false && possibilities[7][6] == false && (possibilities[2][6] == true || possibilities[5][6] == true || possibilities[8][6] == true))
            {
                box_time_saver[2] = 7;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if ((possibilities[0][7] == true || possibilities[3][7] == true || possibilities[6][7] == true) && possibilities[1][7] == false && possibilities[2][7] == false && possibilities[4][7] == false && possibilities[5][7] == false && possibilities[7][7] == false && possibilities[8][7] == false)
            {
                box_time_saver[0] = 8;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][7] == false && possibilities[2][7] == false && possibilities[3][7] == false && (possibilities[1][7] == true || possibilities[4][7] == true || possibilities[7][7] == true) && possibilities[5][7] == false && possibilities[6][7] == false && possibilities[8][7] == false)
            {
                box_time_saver[1] = 8;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][7] == false && possibilities[1][7] == false && possibilities[3][7] == false && possibilities[4][7] == false && possibilities[6][7] == false && possibilities[7][7] == false && (possibilities[2][7] == true || possibilities[5][7] == true || possibilities[8][7] == true))
            {
                box_time_saver[2] = 8;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if ((possibilities[0][8] == true || possibilities[3][8] == true || possibilities[6][8] == true) && possibilities[1][8] == false && possibilities[2][8] == false && possibilities[4][8] == false && possibilities[5][8] == false && possibilities[7][8] == false && possibilities[8][8] == false)
            {
                box_time_saver[0] = 9;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][8] == false && possibilities[2][8] == false && possibilities[3][8] == false && (possibilities[1][8] == true || possibilities[4][8] == true || possibilities[7][8] == true) && possibilities[5][8] == false && possibilities[6][8] == false && possibilities[8][8] == false)
            {
                box_time_saver[1] = 9;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }
            else if (possibilities[0][8] == false && possibilities[1][8] == false && possibilities[3][8] == false && possibilities[4][8] == false && possibilities[6][8] == false && possibilities[7][8] == false && (possibilities[2][8] == true || possibilities[5][8] == true || possibilities[8][8] == true))
            {
                box_time_saver[2] = 9;
                throwawaybox.setboxs(box_num, box_time_saver);
                c_assert = true;
            }

            // If we can make a column assertion, then check the other boxes vertical to ours.
            if (c_assert)
            {
                switch (box_num)
                {
                    case 0:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 3);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 6);
                            break;
                        }
                    case 1:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 4);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 7);
                            break;
                        }
                    case 2:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 5);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 8);
                            break;
                        }
                    case 3:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 0);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 6);
                            break;
                        }
                    case 4:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 1);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 7);
                            break;
                        }
                    case 5:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 2);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 8);
                            break;
                        }
                    case 6:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 0);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 3);
                            break;
                        }
                    case 7:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 1);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 4);
                            break;
                        }
                    case 8:
                        (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 2);
                        if (change)
                        {
                            break;
                        }
                        else
                        {
                            (change, throwawaybox) = intermediate_box_value_checking(fakerow, fakecol, throwawaybox, 5);
                            break;
                        }
                    default:
                        MessageBox.Show("Something is weird with inference column checking.");
                        break;
                }

                if (change)
                {
                    if ((possibilities[0][0] == true || possibilities[3][0] == true || possibilities[6][0] == true) && possibilities[1][0] == false && possibilities[2][0] == false && possibilities[4][0] == false && possibilities[5][0] == false && possibilities[7][0] == false && possibilities[8][0] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][0] == false && possibilities[2][0] == false && possibilities[3][0] == false && (possibilities[1][0] == true || possibilities[4][0] == true || possibilities[7][0] == true) && possibilities[5][0] == false && possibilities[6][0] == false && possibilities[8][0] == false)
                    {
                        box_time_saver[1] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][0] == false && possibilities[1][0] == false && possibilities[3][0] == false && possibilities[4][0] == false && possibilities[6][0] == false && possibilities[7][0] == false && (possibilities[2][0] == true || possibilities[5][0] == true || possibilities[8][0] == true))
                    {
                        box_time_saver[2] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][1] == true || possibilities[3][1] == true || possibilities[6][1] == true) && possibilities[1][1] == false && possibilities[2][1] == false && possibilities[4][1] == false && possibilities[5][1] == false && possibilities[7][1] == false && possibilities[8][1] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][1] == false && possibilities[2][1] == false && possibilities[3][1] == false && (possibilities[1][1] == true || possibilities[4][1] == true || possibilities[7][1] == true) && possibilities[5][1] == false && possibilities[6][1] == false && possibilities[8][1] == false)
                    {
                        box_time_saver[1] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][1] == false && possibilities[1][1] == false && possibilities[3][1] == false && possibilities[4][1] == false && possibilities[6][1] == false && possibilities[7][1] == false && (possibilities[2][1] == true || possibilities[5][1] == true || possibilities[8][1] == true))
                    {
                        box_time_saver[2] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][2] == true || possibilities[3][2] == true || possibilities[6][2] == true) && possibilities[1][2] == false && possibilities[2][2] == false && possibilities[4][2] == false && possibilities[5][2] == false && possibilities[7][2] == false && possibilities[8][2] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][2] == false && possibilities[2][2] == false && possibilities[3][2] == false && (possibilities[1][2] == true || possibilities[4][2] == true || possibilities[7][2] == true) && possibilities[5][2] == false && possibilities[6][2] == false && possibilities[8][2] == false)
                    {
                        box_time_saver[1] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][2] == false && possibilities[1][2] == false && possibilities[3][2] == false && possibilities[4][2] == false && possibilities[6][2] == false && possibilities[7][2] == false && (possibilities[2][2] == true || possibilities[5][2] == true || possibilities[8][2] == true))
                    {
                        box_time_saver[2] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][3] == true || possibilities[3][3] == true || possibilities[6][3] == true) && possibilities[1][3] == false && possibilities[2][3] == false && possibilities[4][3] == false && possibilities[5][3] == false && possibilities[7][3] == false && possibilities[8][3] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][3] == false && possibilities[2][3] == false && possibilities[3][3] == false && (possibilities[1][3] == true || possibilities[4][3] == true || possibilities[7][3] == true) && possibilities[5][3] == false && possibilities[6][3] == false && possibilities[8][3] == false)
                    {
                        box_time_saver[1] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][3] == false && possibilities[1][3] == false && possibilities[3][3] == false && possibilities[4][3] == false && possibilities[6][3] == false && possibilities[7][3] == false && (possibilities[2][3] == true || possibilities[5][3] == true || possibilities[8][3] == true))
                    {
                        box_time_saver[2] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][4] == true || possibilities[3][4] == true || possibilities[6][4] == true) && possibilities[1][4] == false && possibilities[2][4] == false && possibilities[4][4] == false && possibilities[5][4] == false && possibilities[7][4] == false && possibilities[8][4] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][4] == false && possibilities[2][4] == false && possibilities[3][4] == false && (possibilities[1][4] == true || possibilities[4][4] == true || possibilities[7][4] == true) && possibilities[5][4] == false && possibilities[6][4] == false && possibilities[8][4] == false)
                    {
                        box_time_saver[1] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][4] == false && possibilities[1][4] == false && possibilities[3][4] == false && possibilities[4][4] == false && possibilities[6][4] == false && possibilities[7][4] == false && (possibilities[2][4] == true || possibilities[5][4] == true || possibilities[8][4] == true))
                    {
                        box_time_saver[2] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][5] == true || possibilities[3][5] == true || possibilities[6][5] == true) && possibilities[1][5] == false && possibilities[2][5] == false && possibilities[4][5] == false && possibilities[5][5] == false && possibilities[7][5] == false && possibilities[8][5] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][5] == false && possibilities[2][5] == false && possibilities[3][5] == false && (possibilities[1][5] == true || possibilities[4][5] == true || possibilities[7][5] == true) && possibilities[5][5] == false && possibilities[6][5] == false && possibilities[8][5] == false)
                    {
                        box_time_saver[1] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][5] == false && possibilities[1][5] == false && possibilities[3][5] == false && possibilities[4][5] == false && possibilities[6][5] == false && possibilities[7][5] == false && (possibilities[2][5] == true || possibilities[5][5] == true || possibilities[8][5] == true))
                    {
                        box_time_saver[2] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][6] == true || possibilities[3][6] == true || possibilities[6][6] == true) && possibilities[1][6] == false && possibilities[2][6] == false && possibilities[4][6] == false && possibilities[5][6] == false && possibilities[7][6] == false && possibilities[8][6] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][6] == false && possibilities[2][6] == false && possibilities[3][6] == false && (possibilities[1][6] == true || possibilities[4][6] == true || possibilities[7][6] == true) && possibilities[5][6] == false && possibilities[6][6] == false && possibilities[8][6] == false)
                    {
                        box_time_saver[1] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][6] == false && possibilities[1][6] == false && possibilities[3][6] == false && possibilities[4][6] == false && possibilities[6][6] == false && possibilities[7][6] == false && (possibilities[2][6] == true || possibilities[5][6] == true || possibilities[8][6] == true))
                    {
                        box_time_saver[2] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][7] == true || possibilities[3][7] == true || possibilities[6][7] == true) && possibilities[1][7] == false && possibilities[2][7] == false && possibilities[4][7] == false && possibilities[5][7] == false && possibilities[7][7] == false && possibilities[8][7] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][7] == false && possibilities[2][7] == false && possibilities[3][7] == false && (possibilities[1][7] == true || possibilities[4][7] == true || possibilities[7][7] == true) && possibilities[5][7] == false && possibilities[6][7] == false && possibilities[8][7] == false)
                    {
                        box_time_saver[1] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][7] == false && possibilities[1][7] == false && possibilities[3][7] == false && possibilities[4][7] == false && possibilities[6][7] == false && possibilities[7][7] == false && (possibilities[2][7] == true || possibilities[5][7] == true || possibilities[8][7] == true))
                    {
                        box_time_saver[2] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if ((possibilities[0][8] == true || possibilities[3][8] == true || possibilities[6][8] == true) && possibilities[1][8] == false && possibilities[2][8] == false && possibilities[4][8] == false && possibilities[5][8] == false && possibilities[7][8] == false && possibilities[8][8] == false)
                    {
                        box_time_saver[0] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][8] == false && possibilities[2][8] == false && possibilities[3][8] == false && (possibilities[1][8] == true || possibilities[4][8] == true || possibilities[7][8] == true) && possibilities[5][8] == false && possibilities[6][8] == false && possibilities[8][8] == false)
                    {
                        box_time_saver[1] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                    else if (possibilities[0][8] == false && possibilities[1][8] == false && possibilities[3][8] == false && possibilities[4][8] == false && possibilities[6][8] == false && possibilities[7][8] == false && (possibilities[2][8] == true || possibilities[5][8] == true || possibilities[8][8] == true))
                    {
                        box_time_saver[2] = 0;
                        throwawaybox.setboxs(box_num, box_time_saver);
                    }
                }
            }

            // If we changed something, return what we learned.
            if (change)
            {
                for (int i = 0; i < 9; i++)
                {
                    fakebox.setboxs(i, throwawaybox.getboxs(i));
                }
                return (true, fakebox.getmatrix());
            }
            else
            {
                return (false, fakebox.getmatrix());
            }

        }

        public (bool, int[][]) intermediate_value_solving(int[][] mat, int[][] mat2, int[][] mat3)
        {
            /* 
             * This looks at whether there are unique possbilities within a set.
             * For instance, a box has three 0s, but only one of them can be a 1.
             * Therefore that 0 must be a 1, and we set it as such.
             * 
             * Because it is a set-based approach, we need unique solvers to look at each set type.
             */

            /* Setup dummy objects so that we can use their tools. */
            Rows fakerow = new Rows();
            Cols fakecol = new Cols();
            Boxs fakebox = new Boxs();

            /* Populate the dummies with the correct information. */
            for (int fake = 0; fake < 9; fake++)
            {
                fakerow.setrows(fake, mat[fake]);
                fakecol.setcols(fake, mat2[fake]);
                fakebox.setboxs(fake, mat3[fake]);
            }

            /* Find the important row/column/box numbers (the first or next zero we find) and analyze them. */           
            int[] important = new int[3];
            important = [-1, -1, -1];
            int skiprow = -1;
            int skipcol = -1;

            int count = 0;
            bool act = false;

            do
            {

                important = find_important(fakerow, fakecol, fakebox, skiprow, skipcol);

                if (important[0] > skiprow)
                {
                    skipcol = -1;
                }
                else
                {
                    skipcol = important[1];
                }

                skiprow = important[0];

                (bool verify1, Rows newFakerow) = intermediate_row_value_checking(fakerow, important[0], fakecol, fakebox);
                (bool verify2, Cols newFakecol) = intermediate_col_value_checking(fakerow, fakecol, important[1], fakebox);
                (bool verify3, Boxs newFakebox) = intermediate_box_value_checking(fakerow, fakecol, fakebox, important[2]);

                if (verify1)
                {
                    fakerow.setrows(important[0], newFakerow.getrows(important[0]));
                    fakecol = rows_to_cols(fakecol, fakerow.getmatrix());
                    fakebox = rows_to_boxs(fakebox, fakerow.getmatrix());
                    act = true;
                    count++;
                }

                else if (verify2)
                {
                    fakecol.setcols(important[1], newFakecol.getcols(important[1]));
                    fakerow = cols_to_rows(fakerow, fakecol.getmatrix());
                    fakebox = cols_to_boxs(fakebox, fakecol.getmatrix());
                    act = true;
                    count++;
                }

                else if (verify3)
                {
                    fakebox.setboxs(important[2], newFakebox.getboxs(important[2]));
                    fakerow = boxs_to_rows(fakerow, fakebox.getmatrix());
                    fakecol = boxs_to_cols(fakecol, fakebox.getmatrix());
                    act = true;
                    count++;
                }

                // If direct analysis doesn't work, see if we can infer a value and solve with that.
                else
                {
                    (act, int[][] mat4) = intermediate_inference_checking(fakerow, fakecol, fakebox, important[2]);

                    if (act)
                    {
                        for (int fake = 0; fake < 9; fake++)
                        {
                            fakebox.setboxs(fake, mat4[fake]);
                        }

                        fakerow = boxs_to_rows(fakerow, fakebox.getmatrix());
                        fakecol = boxs_to_cols(fakecol, fakebox.getmatrix());
                    }

                    count++;
                    if (count == 81)
                    {
                        // MessageBox.Show("We are maxing out intermediate solver.");
                    }
                }
            }
            while ((act == false) && (count < 81));

            return (act, fakerow.getmatrix());
        }

        
    }
}
