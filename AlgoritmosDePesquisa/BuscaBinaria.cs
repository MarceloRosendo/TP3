using System;
using System.Collections.Generic;

namespace AlgoritmosDePesquisa
{
    public class BuscaBinaria
    {
        public static void buscaBinaria(List<DataSetEl> dataSet, long roomId)
        {
            int loops = 0;
            int index = buscaBinaria(dataSet,roomId,0,dataSet.Count-1, ref loops);
            
            Console.WriteLine(dataSet[index]);
            Console.WriteLine(loops);
        }

        private static int buscaBinaria(List<DataSetEl> dataset, long roomId, int menor, int maior, ref int loops)
        {
            if (menor > maior)
            {
                loops++;
                return -1;
            }

            int media = (menor + maior) / 2;

            if (dataset[media].room_id.CompareTo(roomId) < 0)
            {
                loops++;
                return buscaBinaria(dataset, roomId, media + 1, maior, ref loops);
            }
            else if (dataset[media].room_id.CompareTo(roomId) > 0)
            {
                loops++;
                return buscaBinaria(dataset, roomId, menor, media - 1, ref loops);
            }
            else
            {
                return media;
            }
        }
    }
}