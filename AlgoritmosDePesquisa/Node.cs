namespace AlgoritmosDePesquisa
{
    public class Node {
        public DataSetEl elemento;
        public Node left;
        public Node right;
 
        public Node(DataSetEl elemento) {
            this.elemento = elemento;
            right = null;
            left = null;
        }
    }
}