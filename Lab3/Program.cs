using Lab3.AbstractClasses;
using Lab3.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static int[,] departments =
            {
                { 2, 2, 1 },
                { 0, 3, 0 },
                { 3, 2, 0 },
                { 1, 1, 2 }
            };

        static Computer[][] organization;

        static Statistic statistic;

        static void Main(string[] args)
        {
            const int memoryIncreaseTo = 8;
            organization = new Computer[departments.GetLength(0)][];
            FillDepartment();
            Console.WriteLine("Count PCs: {0},\nLargest HDD: {1},\nLowest Productivity: {2}", statistic.Count, organization[statistic.LargestHDD.xpos][statistic.LargestHDD.ypos], organization[statistic.LowestProductivity.xpos][statistic.LowestProductivity.ypos]);
            
            IncreaseMemory(memoryIncreaseTo);
            Console.ReadLine();
        }

        private static void IncreaseMemory(int memoryIncreaseTo)
        {
            Console.WriteLine("\nOrganization\n");
            for (int i = 0; i < organization.GetLength(0); i++)
            {
                Console.WriteLine("Department #{0} PCs:\n");
                for (int j = 0; j < organization[i].Length; j++)
                {
                    organization[i][j]._memory += (short)(memoryIncreaseTo - organization[i][j]._memory);
                    //CollectStatistic(i, j);
                    Console.WriteLine("{0}\n",organization[i][j]);
                }
            }
        }

        public static void FillDepartment()
        {
            var indexOffset = 0;
            for (int i = 0; i < departments.GetLength(0); i++)
            {
                int lengthForJagged = 0;
                for (int j = 0; j < departments.GetLength(1); j++)
                {
                    if (departments[i, j] > 0)
                    {
                        lengthForJagged += departments[i, j];
                    }
                }

                organization[i] = new Computer[lengthForJagged];
                for (int j = 0; j < departments.GetLength(1); j++)
                {
                    for (int k = 0; k < departments[i, j]; k++)
                    {
                        switch (j)
                        {
                            case 0:
                                organization[i][indexOffset] = new DesctopPC();
                                break;
                            case 1:
                                organization[i][indexOffset] = new LaptopPC();
                                break;
                            default:
                                organization[i][indexOffset] = new ServerPC();
                                break;
                        }

                        CollectStatistic(i, indexOffset);
                        indexOffset++;
                    }
                }
                indexOffset = 0;
            }
        }

        private static void CollectStatistic(int i, int indexOffset)
        {
            statistic.Count++;
            if (organization[i][indexOffset]._hdd > organization[statistic.LargestHDD.xpos][statistic.LargestHDD.ypos]._hdd)
            {
                statistic.LargestHDD.xpos = i;
                statistic.LargestHDD.ypos = indexOffset;
            }

            var currentProductivity = organization[i][indexOffset]._memory * organization[i][indexOffset]._cpu;
            var statisticProductivity = organization[statistic.LowestProductivity.xpos][statistic.LowestProductivity.ypos]._memory * organization[statistic.LargestHDD.xpos][statistic.LargestHDD.ypos]._cpu;

            if (currentProductivity < statisticProductivity)
            {
                statistic.LowestProductivity.xpos = i;
                statistic.LowestProductivity.ypos = indexOffset;
            }
        }


    }
}
