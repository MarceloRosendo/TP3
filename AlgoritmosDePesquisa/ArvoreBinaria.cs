using System;

namespace AlgoritmosDePesquisa
{
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

        public Node pesquisar(int roomId)
        {
            int loops = 0;
            Node node = pesquisar(this.raiz, roomId, ref loops);
            
            Console.WriteLine(loops);
            return node;
        } 
        
        private Node pesquisar(Node raizArvore, int roomId, ref int loops)
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