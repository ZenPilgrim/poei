package org.eclipse.module;

import java.util.Arrays;

public class Formation {
	private String intitule;
	private int nbrJours;
	private Stagiaire[] stagiaires;
	
	public Formation(String intitule, int nbrJours, Stagiaire[] stagiaires) {
		super();
		this.intitule = intitule;
		this.nbrJours = nbrJours;
		this.stagiaires = stagiaires;
	}

	public String getIntitule() {
		return intitule;
	}

	public void setIntitule(String intitule) {
		this.intitule = intitule;
	}

	public int getNbrJours() {
		return nbrJours;
	}

	public void setNbrJours(int nbrJours) {
		this.nbrJours = nbrJours;
	}

	public Stagiaire[] getStagiaires() {
		return stagiaires;
	}

	public void setStagiaires(Stagiaire[] stagiaires) {
		this.stagiaires = stagiaires;
	}
	
	public float calculerMoyenneFormation() {
		float sum = 0;
		for(Stagiaire stagiaire : stagiaires){
			sum += stagiaire.calculerMoyenne();
	       }
		return sum/stagiaires.length;
	}
	
	public int getIndexMax() {
		float max = 0;
		int maxIndex = 0;
		for(int i = 0; i < stagiaires.length; i++){
	         if(stagiaires[i].calculerMoyenne() > max)
	        	max = stagiaires[i].calculerMoyenne();
	         	maxIndex = i;
	       }
		return stagiaires.length == 0 ? -1 : maxIndex;
	}
	
	public String afficherNomMax() {
		return stagiaires[getIndexMax()].getNom();
	}
	
	public float afficherMinMax() {
		return stagiaires[getIndexMax()].trouverMin();
	}
	
	public float trouverMoyenneParNom(String nom) {
		for(Stagiaire stagiaire : stagiaires){
			if (stagiaire.getNom() == nom) {
				return stagiaire.calculerMoyenne();
			}
	       }
		return -1;
	}

	@Override
	public String toString() {
		return "Formation [intitule=" + intitule + ", nbrJours=" + nbrJours + ", stagiaires="
				+ Arrays.toString(stagiaires) + "]";
	}
}
