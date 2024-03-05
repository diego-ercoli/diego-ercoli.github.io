//*---SOGGETTO---*
if(info.getDepRelation() ==  RELATION.NSUBJ) {
    //Nodo NP
    NPPhraseSpec NP_subj = factory.createNounPhrase();
    //Assegno relazione subj
    sentence.setSubject(NP_subj); 
    //Genero in maniera ricorsiva il sottoalbero Beta1
    NP_subj = (NPPhraseSpec) generatePhrase(node).getPhrase();
}
//*---VERBO---*
if(info.getPos() == POS.VERB) {
    //NODO VP
    VPPhraseSpec VP = factory.createVerbPhrase();
    //Assegno relazione verb
    sentence.setVerb(VP);
    //Aggiungo ai figli di VP un nodo foglia (lemma)
    VP.setVerb(info.getEnglishLemma());
}
//*---COMPLEMENTO OGGETTO---*
If(info.getDepRelation() == RELATION.DOBJ){ 
    //Nodo NP
    NPPhraseSpec NP_obj = factory.createNounPhrase();
    //Assegno relazione obj
    sentence.addComplement(NP_obj);.
    //Genero in maniera ricorsiva il sottoalbero Beta2 
    NP_obj = (NPPhraseSpec) generatePhrase(node).getPhrase();
}
