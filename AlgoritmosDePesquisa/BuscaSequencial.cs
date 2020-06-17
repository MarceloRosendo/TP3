using System;
using System.Collections.Generic;

namespace AlgoritmosDePesquisa
{
    public class BuscaSequencial
    {
        public static void buscaSequencial(List<DataSetEl> dataSet, long roomId)
        {
            int loops = 0;
            bool find = false;
            foreach (DataSetEl dataSetEl in dataSet)
            {
                loops++;
                if (dataSetEl.room_id == roomId)
                {
                    find = true;
                    break;
                }
            }

            Console.WriteLine("Comparações = "+loops);
            if (find)
            {
                DataSetEl.printroom(dataSet[loops-1]);
            }
            else
            {
                DataSetEl.printroom(null);
            }
        }
    }
}