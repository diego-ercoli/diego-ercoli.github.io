coda.add(root); //aggiungo la radice alla coda
coda.addAll(root.getChildren()); //aggiungo i suoi figli
//Ciclo sui nodi dell'albero a dipendenze posti ad una profondità massima di 1
while (!coda.isEmpty()) {
   TreeNode<MorphSyntaxInfo> node = coda.poll();
   MorphSyntaxInfo info = node.getEl();
   //*---SOGGETTO---*
   if(info.getDepRelation() ==  RELATION.NSUBJ) {
		NPPhraseSpec NP_subj = factory.createNounPhrase();
                sentence.setSubject(generatePhrase(node).getPhrase()); //costruisco NP
                //...codice continua ...
        }
            //*---VERBO---*
            if(info.getPos() == POS.VERB) {
                verb = (VerbMorphSyntaxInfo) info;
                VPPhraseSpec VP = factory.createVerbPhrase();
                sentence.setVerb(VP);
                //...codice continua ...
                VP.setVerb(info.getEnglishLemma());
            }
            //*---OGGETTO---*
            if(info.getDepRelation() == RELATION.DOBJ){ //COMPLEMENTO OGGETTO
            	NPPhraseSpec NP_obj = factory.createNounPhrase();//(info.getEnglishLemma());
            	sentence.addComplement(NP_obj);
            	//...codice continua ...
            	NP_obj = (NPPhraseSpec) generatePhrase(node).getPhrase();
 	    }
        }
       	//codice continua ....
      	return sentence;
    }
