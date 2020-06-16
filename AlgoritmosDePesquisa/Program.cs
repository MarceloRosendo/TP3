using System;
using System.Collections.Generic;
using System.IO;

namespace AlgoritmosDePesquisa
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<DataSetEl> dataSet = new List<DataSetEl>();
            ArvoreBinaria arvoreBinaria = new ArvoreBinaria();
            readFileContent(ref dataSet);
            // busca sequencial
            
            Console.WriteLine("Busca sequencial ");
            BuscaSequencial.buscaSequencial(dataSet, 4659998);
            // busca binária
            List<DataSetEl> dataSetSort = BubbleSort.sort(dataSet);
            Console.WriteLine("Busca binária "); 
            BuscaBinaria.buscaBinaria(dataSetSort, 4659998);
            
            // arvore binária
            instaciaArvore(ref arvoreBinaria, dataSet);
            Console.WriteLine("Arvore binária "); 
            Node retorno = arvoreBinaria.pesquisar(4659998);

            // 
        }

        static void instaciaArvore(ref ArvoreBinaria arvoreBinaria, List<DataSetEl> dataset)
        {
            foreach(DataSetEl elemento in dataset)
            {
                arvoreBinaria.inserir(elemento);
            }
        }

        static void readFileContent(ref List<DataSetEl> dataSetArray)
        {
            try
            {
                int counter = 0;
                string line;

                StreamReader file = new StreamReader("airbnb_reduzido.txt");

                while ((line = file.ReadLine()) != null)
                {
                    if (counter > 0)
                    {
                        string[] lineSplited = line.Split('\t');
                        DataSetEl aux = new DataSetEl();
                        aux.room_id = long.Parse(lineSplited[0]);
                        aux.host_id = long.Parse(lineSplited[1]);
                        aux.room_type = lineSplited[2];
                        aux.country = lineSplited[3];
                        aux.city = lineSplited[4];
                        aux.neighborhood = lineSplited[5];
                        aux.reviews = lineSplited[6];
                        aux.overall_satisfaction = lineSplited[7];
                        aux.accommodates = lineSplited[8];
                        aux.bedrooms = lineSplited[9];
                        aux.price = lineSplited[10];
                        aux.property_type = lineSplited[11];

                        dataSetArray.Add(aux);
                    }
                    counter++;
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}