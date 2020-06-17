using System;
using System.Collections.Generic;

namespace AlgoritmosDePesquisa
{
    public class BuscaSequencial
    {
        /**
         * Busca em cada elemento do dataset (desordenado) pelo room_id passado como parâmetro
         * A variável loops é o auxiliar que conta as comparações
         */
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