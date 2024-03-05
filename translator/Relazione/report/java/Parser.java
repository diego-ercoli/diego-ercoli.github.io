public TreeNodeNode<MorphSyntaxInfo> buildDepParsingTreeNode(String sentence){
        //Ottengo i dati da Tint in formato JSON
        String json = getJSONViaHTTP(sentence); 
        //Deserializzo la stringa JSON in un oggetto JAVA
        TintParserOutput obj = getParsedObject(json); 
        //Ottengo la lista di dipendenze di TINT
        TintParserOutput.SentenceDependencyTint[] dependencies = obj.getSentences()[0].getBasicDependencies();
        //Ottengo l'elenco di tokens di TINT (parole) che inglobano le informazioni morfologiche.
        TintParserOutput.SentenceTokenTint[] morph_words = obj.getSentences()[0].getTokens();
        //Dichiaro un array di nodi corrispondenti alle parole della frase
        TreeNode<MorphSyntaxInfo>[] word_nodes = new TreeNode[morph_words.length];
        for (int i=0;i<morph_words.length;i++) {
        	//Dichiaro un contenitore di informazioni morfologiche per il termine corrente	
        	MorphSyntaxInfo info = null;
        	//Estraggo le informazioni morfologiche da morph_words[i] e le assegno ad info.
       		//...Nota: Codice omesso per brevità.     
        	//Creo il nodo per la parola ed assegno il puntatore all'info morfologica
			word_nodes[i] = new TreeNode<>(info);
        }
        int root=-1; //indice del nodo che costituirà la radice dell'albero
        //Ciclo sulla lista di dipendenze 
        for(TintParserOutput.SentenceDependencyTint relation: dependencies){
            //in Tint gli indici partondo da 1, mentre in Java partono da 0
            int head = relation.getGovernor()-1; //indice parola head
            int dep = relation.getDependent()-1; //indice parola dipendenza
            //Estraggo il tipo di relazione (label)
            String label_edge = relation.getDep();
            //L'etichetta root indica qual'è la testa della frase
            if(label_edge.toLowerCase().equals("root"))
                root = dep;
            else            	
            	/*Il nodo associato al dipendente diventa figlio del nodo
            	associato alla testa*/
                word_nodes[head].addChild(word_nodes[dep]);
            //Annoto l'etichetta della relazione sul nodo figlio
            word_nodes[dep].getEl().setDepRelation(label_edge);
        }
        //Restituisco la radice dell'albero
        return word_nodes[root];
    }
}
