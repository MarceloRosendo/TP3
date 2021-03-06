using System;

namespace AlgoritmosDePesquisa
{
    /**
         * Estrutura de árvore que adiciona os nodos e busca utilizando sua organização para dividir os ramos e identificar
         * o room_id desejado     
         * A variável loops é o auxiliar que conta as comparações
         */
    public class ArvoreBinaria
    {
        private Node raiz; 
        
        public ArvoreBinaria()
        {
            raiz = null;
        }
        
        public void inserir(DataSetEl alunoNovo)
        {
            this.raiz = adicionar(this.raiz, alunoNovo);
        }

        private Node adicionar(Node raizArvore, DataSetEl elemento)
        {
            if (raizArvore == null)
                raizArvore = new Node(elemento);
            else
            {
                if (raizArvore.elemento.room_id > elemento.room_id)
                    raizArvore.left = adicionar(raizArvore.left, elemento);
                else
                {
                    if (raizArvore.elemento.room_id < elemento.room_id)
                        raizArvore.right = adicionar(raizArvore.right, elemento);
                    else
                        Console.WriteLine("O elemento " + elemento.room_id + " já foi inserido anteriormente na árvore.");
                }
            }
            return raizArvore;
        }

        /**
         * Faz uma chamada de uma função recursiva que irá dividir os ramos da arvore aproximando-se
         * do valor buscado.
         * 
         */
        public Node pesquisar(long roomId)
        {
            int loops = 0;
            Node node = pesquisar(this.raiz, roomId, ref loops);
            
            Console.WriteLine("Comparações = "+loops);
            if(node != null)
            {
                DataSetEl.printroom(node.elemento);
            }
            else
            {
                DataSetEl.printroom(null);
            }
         
            return node;
        } 
        
        private Node pesquisar(Node raizArvore, long roomId, ref int loops)
        {
            if (raizArvore == null)
            {
                loops++;
                return null;   
            }

            if (raizArvore.elemento.room_id == roomId)
            {
                loops++;
                return raizArvore;
            }

            if (raizArvore.elemento.room_id > roomId)
            {
                loops++;
                return pesquisar(raizArvore.left, roomId, ref loops);
            }
            else
            {
                loops++;
                return pesquisar(raizArvore.right, roomId, ref loops);
            }
        }

    }
}