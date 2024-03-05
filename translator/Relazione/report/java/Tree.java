public class TreeNode<E> implements Iterable<E> {
    private List<TreeNode<E>> children;
    private TreeNode<E> father;
    private E el;   
    //COSTRUTTORE e metodi getter e setter non mostrati per brevità.
   /**
     * Aggiunge un figlio (sotto-albero) all'albero corrente
     * @param child
     */
    public void addChild(TreeNode<E> child) {
        subTreeNodes.add(child);
        child.father = this;
    }
    /**
     * Restituisce true se l'albero sotteso al nodo corrente è una foglia
     * @return
     */
    public boolean isLeaf() {
        return children.isEmpty();
    }

   /**
     * Restituisce i nodi figli che costituiscono sotto-alberi.
     * @return the subTreeNodes
     */
    public List<TreeNode<E>> getSubTreeNodes() {
        return subTreeNodes;
    }
    @Override
    public Iterator<E> iterator() {
    	//Visita in ampiezza
        return new WithSearchIterator<E>(this);
    }
   
}
