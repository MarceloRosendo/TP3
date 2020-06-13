using System.Collections.Generic;

namespace AlgoritmosDePesquisa
{
    public class BuscaBinaria
    {
        public static int buscaBinaria(List<DataSetEl> dataSet, long roomId)
        {
            return buscaBinaria(dataSet,roomId,0,dataSet.Count-1);
        }

        private static int buscaBinaria(List<DataSetEl> dataset, long roomId, int menor, int maior)
        {
            if (menor > maior)
            {
                return -1;
            }

            int media = (menor + maior) / 2;

            if (dataset[media].room_id.CompareTo(roomId) < 0)
            {
                return buscaBinaria(dataset, roomId, media + 1, maior);
            }
            else if (dataset[media].room_id.CompareTo(roomId) > 0)
            {
                return buscaBinaria(dataset, roomId, menor, media - 1);
            }
            else
            {
                return media;
            }
        }
    }
}