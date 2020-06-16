using System.Collections.Generic;

namespace AlgoritmosDePesquisa
{
    public class BubbleSort
    {
        // bubble sort
        public static List<DataSetEl> sort(List<DataSetEl> dataset)
        {
            int i, j;
            for (i = 0; i < dataset.Count - 1; i++)
            {
                for (j = 0; j < dataset.Count - i - 1; j++)
                {
                    if (dataset[j].room_id > dataset[j + 1].room_id)
                    {
                        DataSetEl temp = dataset[j];
                        dataset[j] = dataset[j + 1];
                        dataset[j + 1] = temp;
                    }
                }
            }

            return dataset;
        }
    }
}