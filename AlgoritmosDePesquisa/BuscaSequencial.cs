using System;
using System.Collections.Generic;

namespace AlgoritmosDePesquisa
{
    public class BuscaSequencial
    {
        public static Boolean buscaSequencial(List<DataSetEl> dataSet, long roomId)
        {
            foreach (DataSetEl dataSetEl in dataSet)
            {
                if (dataSetEl.room_id == roomId)
                {
                    return true;
                }
            }

            return false;
        }
    }
}