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
            int over3 = length - 3;
            int numberOfCheck = (over3 + 1) * (over3 + 1);

            return winner3X3(situation, over3);


        }

        public static int winner3X3(int[,,] situation, int over3)
        {
            int sum;
            int isWin = -1;
            int counter = 0;

            for (int ExRow = 0; ExRow <= over3; ExRow++)
            {
                for (int ExCloun = 0; ExCloun <= over3; ExCloun++)
                {




                    //rows
                    for (int a = 0; a < 2; a++)
                    {
                        sum = 0;
                        for (int i = 0 + ExRow; i < 3 + ExRow; i++)
                        {
                            sum = 0;
                            for (int j = 0 + ExCloun; j < 3 + ExCloun; j++)
                            {
                                //1st player
                                if (a == 0)
                                {
                                    sum += situation[0, i, j];
                                    if (sum == 3)
                                    {
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
                            for (int j = 0 + ExCloun; j < 3 + ExCloun; j++)
                            {
                                //1st player
                                if (a == 0)
                                {
                                    sum += situation[0, j, i];
                                    if (sum == 3)
                                    {
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
                                sum += situation[0, i, 3 - 1 - i];
                                if (sum == 3)
                                {
                                    isWin = 0;
                                    return isWin;
                                }
                            }
                            //2nd player
                            if (a == 1)
                            {
                                sum += situation[1, i, 3 - 1 - i];
                                if (sum == 3)
                                {
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
                        for (int i = 0 + ExCloun; i < 3 + ExCloun; i++)
                        {
                            //1st player
                            if (a == 0)
                            {
                                sum += situation[0, i, i];
                                if (sum == 3)
                                {
                                    isWin = 0;
                                    return isWin;
                                }
                            }
                            //2nd player
                            if (a == 1)
                            {
                                sum += situation[1, i, i];
                                if (sum == 3)
                                {
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
