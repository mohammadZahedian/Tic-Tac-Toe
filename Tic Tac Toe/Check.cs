using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public static class Check
    {
        public static int winner(int[,,] situation, int length)
        {
            int sum;
            int isWin = -1;


            //rows
            for (int a = 0; a < 2; a++)
            {
                sum = 0;
                for (int i = 0; i < length; i++)
                {
                    sum = 0;
                    for (int j = 0; j < length; j++)
                    {   
                        //1st player
                        if (a == 0)
                        {
                            sum += situation[0, i, j];
                            if (sum == 3)
                            {
                                isWin = 0;
                            }
                        }

                        //2nd player
                        if (a == 1)
                        {
                            sum += situation[1, i, j];
                            if (sum == 3)
                            {
                                isWin = 1;
                            }
                        }

                    }
                }
            }


            //coluns
            for (int a = 0; a < 2; a++)
            {
                sum = 0;
                for (int i = 0; i < length; i++)
                {
                    sum = 0;
                    for (int j = 0; j < length; j++)
                    {  
                        //1st player
                        if (a == 0)
                        {
                            sum += situation[0, j, i];
                            if (sum == 3)
                            {
                                isWin = 0;
                            }
                        }

                        //2nd player
                        if (a == 1)
                        {
                            sum += situation[1, j, i];
                            if (sum == 3)
                            {
                                isWin = 1;
                            }
                        }

                    }
                }
            }

            //1st Diameter
            for (int a = 0; a < 2; a++)
            {
                sum = 0;
                for (int i = 0; i < length; i++)
                {
                    //1st player
                    if (a == 0)
                    {
                        sum += situation[0, i, length - 1  - i];
                        if (sum == 3)
                        {
                            isWin = 0;
                        }
                    }
                    //2nd player
                    if (a == 1)
                    {
                        sum += situation[1, i, length - 1 - i];
                        if (sum == 3)
                        {
                            isWin = 1;
                        }
                    }

                }
            }
            //2nd Diameter
            for (int a = 0; a < 2; a++)
            {
                sum = 0;
                for (int i = 0; i < length; i++)
                {
                    //1st player
                    if (a == 0)
                    {
                        sum += situation[0, i, i];
                        if (sum == 3)
                        {
                            isWin = 0;
                        }
                    }
                    //2nd player
                    if (a == 1)
                    {
                        sum += situation[1, i, i];
                        if (sum == 3)
                        {
                            isWin = 1;
                        }
                    }

                }
            }


            return isWin;
        }
    }
}
