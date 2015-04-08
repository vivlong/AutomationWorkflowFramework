using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AWF.Classes
{
    public class SortingAlgorithm
    {
        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="list"></param>
        public void BubbleSorter(ArrayList list)
        {
            int i, j, temp;
            bool done = false;
            j = 1;
            while ((j < list.Count) && (!done))
            {
                done = true;
                for (i = 0; i < list.Count - j; i++)
                {
                    if (Convert.ToInt32(list[i]) > Convert.ToInt32(list[i + 1]))
                    {
                        done = false;
                        temp = Convert.ToInt32(list[i]);
                        list[i] = Convert.ToInt32(list[i + 1]);
                        list[i + 1] = temp;
                    }
                }
                j++;
            }
        }
        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="list"></param>
        public void SelectionSorter(ArrayList list)
        {
            int min;
            for (int i = 0; i < list.Count - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (Convert.ToInt32(list[j]) < Convert.ToInt32(list[min]))
                        min = j;
                }

                int t = Convert.ToInt32(list[min]);
                list[min] = Convert.ToInt32(list[i]);
                list[i] = t;
            }
        }
        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="list"></param>
        public void InsertionSorter(ArrayList list)
        {
            int i, j, temp;
            bool done = false;
            j = 1;
            while ((j < list.Count) && (!done))
            {
                done = true;
                for (i = 0; i < list.Count - j; i++)
                {
                    if (Convert.ToInt32(list[i]) > Convert.ToInt32(list[i + 1]))
                    {
                        done = false;
                        temp = Convert.ToInt32(list[i]);
                        list[i] = Convert.ToInt32(list[i + 1]);
                        list[i + 1] = temp;
                    }
                }
                j++;
            }
        }
        /// <summary>
        /// 希尔排序
        /// </summary>
        /// <param name="list"></param>
        public void ShellSorter(ArrayList list)
        {
            int inc;
            for (inc = 1; inc <= list.Count / 9; inc = 3 * inc + 1) ;
            for (; inc > 0; inc /= 3)
            {
                for (int i = inc + 1; i <= list.Count; i += inc)
                {
                    int t = Convert.ToInt32(list[i - 1]);
                    int j = i;
                    while ((j > inc) && (Convert.ToInt32(list[j - inc - 1]) > t))
                    {
                        list[j - 1] = Convert.ToInt32(list[j - inc - 1]);
                        j -= inc;
                    }
                    list[j - 1] = t;
                }
            }
        }
    }
}
