using System;
using System.Collections.Generic;

namespace AlgoritmosDePesquisa
{
    public class BuscaSequencial
    {
        public static void buscaSequencial(List<DataSetEl> dataSet, long roomId)
        {
            int loops = 0;
            foreach (DataSetEl dataSetEl in dataSet)
            {
                loops++;
                if (dataSetEl.room_id == roomId)
                {
                    break;
                }
            }

            Console.WriteLine(loops);
        }
    }
}