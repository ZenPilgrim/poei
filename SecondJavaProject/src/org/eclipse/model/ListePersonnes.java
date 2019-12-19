package org.eclipse.model;

import java.util.Arrays;

public class ListePersonnes {
	private Personne [] personnes;
	
	public ListePersonnes(Personne[] personnes) {
		super();
		if (personnes.length <= 10 ) {
			this.personnes = personnes;
		}
		else {
			for (int i = 0; i < 10; i++){
				this.personnes[i] = personnes[i];
			}
		}
	}

	public Personne[] getPersonnes() {
		return personnes;
	}

	public void setPersonnes(Personne[] personnes) {
		this.personnes = personnes;
	}
	
	public Personne findByNom(String s) {
		for (Personne personne : personnes) {
			if (personne.getNom() == s) {
				return personne;
			}
	       }
		return null;
	}
	
	public boolean findByCodePostal(String cp) {
		for (Personne personne : personnes) {
			Adresse[] adresses = personne.getAdresses();
			for (Adresse adresse : adresses) {
				if (adresse.getCodePostal() == cp) {
					return true;
			}
	       }
		}
		return false;
	}
	
	public void editPersonneNom(String oldNom, String newNom) {
		for (Personne personne : personnes) {
			if (personne.getNom() == oldNom) {
				personne.setNom(newNom);
	       }
		}
	}
	
	public void editVilleNom(String nom, String newVille)  {
		for (Personne personne : personnes) {
			Adresse[] adresses = personne.getAdresses();
			for (Adresse adresse : adresses) {
				if (adresse.getVille() == nom) {
					adresse.setVille(newVille);
				}
			}
		}
	}
	
	public void editPersonneVilles(String nom, String newVille) {
		for (Personne personne : personnes) {
			if (personne.getNom().equals(nom)) {
				for (Adresse adresse : personne.getAdresses()) {
					adresse.setVille(newVille);
				}
			}
		}
	}
	

	@Override
	public String toString() {
		return "ListePersonnes [personnes=" + Arrays.toString(personnes) + "]";
	}

	
}
