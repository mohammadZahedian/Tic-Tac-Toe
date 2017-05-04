using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{

    public static class Check
    {

        public static string Last_Location_checked;
        public static int Last_ROW_checked;
        public static int Last_COLUMN_checked;
        public static int winner(int[,,] situation, int length)
        {
            int over3 = length - 3;
            //int numberOfCheck = (over3 + 1) * (over3 + 1);

            return winner3X3(situation, over3);


        }


        public static string[] Winner_line_location()
        {
            if (Last_Location_checked == "Row")
            {

                string[] a = new string[3]
                {
                Last_ROW_checked.ToString()+","+ Last_COLUMN_checked.ToString() ,
                Last_ROW_checked.ToString()+","+ (Last_COLUMN_checked - 1).ToString(),
                Last_ROW_checked.ToString()+"," +(Last_COLUMN_checked - 2).ToString()
                };
        return a;
            }
            if (Last_Location_checked == "Column")
            {
                string[] a = new string[3]
             {
                Last_ROW_checked.ToString()+","+ Last_COLUMN_checked.ToString() ,
                (Last_ROW_checked-1).ToString()+","+ (Last_COLUMN_checked ).ToString(),
                (Last_ROW_checked-2).ToString()+"," +(Last_COLUMN_checked ).ToString()
             };
                return a;
            }
            if (Last_Location_checked == "R_Diameter")
            {
                string[] a = new string[3]
             {
                Last_ROW_checked.ToString()+","+ Last_COLUMN_checked.ToString() ,
                (Last_ROW_checked-1).ToString()+","+ (Last_COLUMN_checked+1 ).ToString(),
                (Last_ROW_checked-2).ToString()+"," +(Last_COLUMN_checked +2).ToString()
             };
                return a;
            }
            if (Last_Location_checked == "L_Diameter")
            {
                string[] a = new string[3]
             {
                Last_ROW_checked.ToString()+","+ Last_COLUMN_checked.ToString() ,
                (Last_ROW_checked-1).ToString()+","+ (Last_COLUMN_checked-1 ).ToString(),
                (Last_ROW_checked-2).ToString()+"," +(Last_COLUMN_checked -2).ToString()
             };
                return a;
            }
            string[] s = new string[2] { "a", "d" };
            return s;

        }

        public static int winner3X3(int[,,] situation, int over3)
        {
            int sum;
            int isWin = -1;

            for (int ExRow = 0; ExRow <= over3; ExRow++)
            {
                for (int Excolumn = 0; Excolumn <= over3; Excolumn++)
                {

                    //rows
                    for (int a = 0; a < 2; a++)
                    {
                        sum = 0;
                        for (int i = 0 + ExRow; i < 3 + ExRow; i++)
                        {
                            sum = 0;
                            for (int j = 0 + Excolumn; j < 3 + Excolumn; j++)
                            {
                                //1st player
                                if (a == 0)
                                {
                                    sum += situation[0, i, j];
                                    if (sum == 3)
                                    {
                                        Last_Location_checked = "Row";
                                        Last_ROW_checked = i;
                                        Last_COLUMN_checked = j;
                                        isWin = 0;
                                        return isWin;
                                    }
                                }

                                //2nd player
                                if (a == 1)
                                {
                                    sum += situation[1, i, j];
                                    if (sum == 3)
                                    {
                                        Last_Location_checked = "Row";
                                        Last_ROW_checked = i;
                                        Last_COLUMN_checked = j;
                                        isWin = 1;
                                        return isWin;
                                    }
                                }

                            }
                        }
                    }


                    //coluns
                    for (int a = 0; a < 2; a++)
                    {
                        sum = 0;
                        for (int i = 0 + ExRow; i < 3 + ExRow; i++)
                        {
                            sum = 0;
                            for (int j = 0 + Excolumn; j < 3 + Excolumn; j++)
                            {
                                //1st player
                                if (a == 0)
                                {
                                    sum += situation[0, j, i];
                                    if (sum == 3)
                                    {
                                        Last_ROW_checked = j;
                                        Last_COLUMN_checked = i;
                                        Last_Location_checked = "Column";
                                        isWin = 0;
                                        return isWin;
                                    }
                                }

                                //2nd player
                                if (a == 1)
                                {

                                    sum += situation[1, j, i];
                                    if (sum == 3)
                                    {
                                        Last_Location_checked = "Column";
                                        Last_ROW_checked = j;
                                        Last_COLUMN_checked = i;
                                        isWin = 1;
                                        return isWin;
                                    }
                                }

                            }
                        }
                    }

                    //1st Diameter
                    for (int a = 0; a < 2; a++)
                    {
                        sum = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            //1st player
                            if (a == 0)
                            {
                                sum += situation[0, i + ExRow, 3 - 1 - i + Excolumn];
                                if (sum == 3)
                                {
                                    Last_Location_checked = "R_Diameter";
                                    Last_ROW_checked = i + ExRow;
                                    Last_COLUMN_checked = 3 - 1 - i + Excolumn;
                                    isWin = 0;
                                    return isWin;
                                }
                            }
                            //2nd player
                            if (a == 1)
                            {
                                sum += situation[1, i + ExRow, 3 - 1 - i + Excolumn];
                                if (sum == 3)
                                {
                                    Last_Location_checked = "R_Diameter";
                                    Last_ROW_checked = i + ExRow;
                                    Last_COLUMN_checked = 3 - 1 - i + Excolumn;
                                    isWin = 1;
                                    return isWin;
                                }
                            }

                        }
                    }
                    //2nd Diameter
                    for (int a = 0; a < 2; a++)
                    {
                        sum = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            //1st player
                            if (a == 0)
                            {
                                sum += situation[0, i + ExRow, i + Excolumn];
                                if (sum == 3)
                                {
                                    Last_Location_checked = "L_Diameter";
                                    Last_ROW_checked = i + ExRow;
                                    Last_COLUMN_checked = i + Excolumn;
                                    isWin = 0;
                                    return isWin;
                                }
                            }
                            //2nd player
                            if (a == 1)
                            {
                                sum += situation[1, i + ExRow, i + Excolumn];
                                if (sum == 3)
                                {
                                    Last_Location_checked = "L_Diameter";
                                    Last_ROW_checked = i + ExRow;
                                    Last_COLUMN_checked = i + Excolumn;
                                    isWin = 1;
                                    return isWin;
                                }
                            }

                        }
                    }
                }
            }
            return isWin;

        }
    }
}
