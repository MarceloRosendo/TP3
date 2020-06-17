using System;

namespace AlgoritmosDePesquisa
{
    public class Lista
    {
        private Elemento ini;
        private Elemento fim;
        private Elemento aux;

        public int tam;

        public Lista()
        {
            ini = null;
            fim = null;
            tam = 0;
        }

        public bool vazio()
        {
            return (ini == fim);
        }
        public void inserirElemento(DataSetEl ele)
        {
            Elemento novo = new Elemento(ele);
            novo.quarto = ele;

            if (ini == null)
            {
                ini = novo;
                fim = novo;
                novo.prox = null;
            }
            else
            {
                fim.prox = novo;
                fim = novo;
                fim.prox = null;
            }
            tam++;
        }
        public void pesquisar(long roomId)
        {
            int loops = 0;
            Elemento elementoaux = busca(roomId, ref loops);            

            if(elementoaux ==  null)
            {
                Console.WriteLine("Quarto não encontrado.");
            }
            else
            {
                DataSetEl.printroom(elementoaux.quarto);
                Console.WriteLine("");
                Console.WriteLine("Comparações = " + loops);
            }                     
        }
        private Elemento busca(long roomid, ref int loops)
        {
            aux = ini;
            bool achou = false;
                        
            if (!vazio())
            {
                while (aux != null)
                {
                    if (aux.quarto.room_id == roomid)
                    {
                        achou = true;
                        loops++;
                        break;
                    }
                    else
                    {
                        aux = aux.prox;
                        loops++;
                    }                    
                }
                if (achou)
                    return aux;

                else
                    return null;
            }
            else
            {
                return null;
            }
        }       
    }
    public class Elemento
    {
        public DataSetEl quarto;
        public Elemento prox;

        public Elemento(DataSetEl elemento)
        {
            quarto = elemento;
            prox = null;
        }
    }
}
