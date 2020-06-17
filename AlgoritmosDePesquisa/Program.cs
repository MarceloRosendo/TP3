using System;
using System.Collections.Generic;
using System.IO;

namespace AlgoritmosDePesquisa
{
    internal class Program
    {
        /*
         * Classe principal de menu: redireciona o usuário para o algoritmo de pesquisa desejado
         */
        public static void Main(string[] args)
        {
            List<DataSetEl> dataSetArray = new List<DataSetEl>();
            readFileContent(ref dataSetArray);

            int op = 1;
            long room = 0;

            while (op >0 && op <5)
            {
                Console.Clear();
                Console.WriteLine("Digite sua opção ");
                Console.WriteLine("1-> Pesquisa Sequencial");
                Console.WriteLine("2-> Pesquisa Binária ");
                Console.WriteLine("3-> Árvore Binária ");
                Console.WriteLine("4-> Lista Encadeada ");
                Console.WriteLine("Outra opção para sair");
                op = int.Parse(Console.ReadLine());

                Console.Clear();

                if (op > 0 && op < 5)
                {
                    Console.WriteLine("Digite o id do quarto");
                    room = long.Parse(Console.ReadLine());
                }
             
                if (op == 1)
                {
                    BuscaSequencial.buscaSequencial(dataSetArray, room);
                }
                else if (op == 2)
                {

                    BuscaBinaria.buscaBinaria(BubbleSort.sort(dataSetArray), room);
                }
                else if(op == 3)
                {
                    ArvoreBinaria arvore = new ArvoreBinaria();
                    instaciaArvore(ref arvore, dataSetArray);
                    arvore.pesquisar(room);
                }
                else if(op == 4)
                {
                    Lista listaencadeada = new Lista();
                    instancialistaEnc(ref listaencadeada, dataSetArray);
                    listaencadeada.pesquisar(room);
                }
                Console.ReadKey();
            }
        }
        
        /*
         * Instancia a lista encadeada com os elementos do dataset
         */
        static void instancialistaEnc(ref Lista listaencadeada, List<DataSetEl> dataset)
        {
            foreach (DataSetEl elemento in dataset)
            {
                listaencadeada.inserirElemento(elemento);
            }
        }

        /*
         * Instancia a arvore com os elementos do dataset
         */
        static void instaciaArvore(ref ArvoreBinaria arvoreBinaria, List<DataSetEl> dataset)
        {
            foreach(DataSetEl elemento in dataset)
            {
                arvoreBinaria.inserir(elemento);
            }
        }

        /*
         * Lê o arquivo de dataset e transforma na lista abstrata
         */
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