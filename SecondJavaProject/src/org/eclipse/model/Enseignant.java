package org.eclipse.model;

import java.util.Arrays;

public final class Enseignant extends Personne {
	private int salaire;
	
	

	public Enseignant(int num, String nom, String prenom, char sexe, Adresse[] adresses, int salaire) {
		super(num, nom, prenom, sexe, adresses);
		this.salaire = salaire;
	}

	public int getSalaire() {
		return salaire;
	}

	public void setSalaire(int salaire) {
		this.salaire = salaire;
	}
	
	@Override
	public void afficherNomComplet() {
	System.out.println(this.getPrenom() + " " + this.getNom());
	}

	@Override
	public String toString() {
		return "Enseignant [salaire=" + salaire + ", num=" + num + ", nom=" + nom + ", prenom=" + prenom + ", sexe="
				+ sexe + ", adresses=" + Arrays.toString(adresses) + "]";
	}

	

	
}
