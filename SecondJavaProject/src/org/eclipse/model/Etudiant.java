package org.eclipse.model;

public final class Etudiant extends Personne {
	private String niveau;
	
	public Etudiant(int num, String nom, String prenom, String niveau) {
		super(num, nom, prenom);
		this.niveau = niveau;
	}

	public Etudiant(int num, String nom, String prenom, char sexe, Adresse[] adresses, String niveau) {
		super(num, nom, prenom, sexe, adresses);
		this.niveau = niveau;
	}

	public String getNiveau() {
		return niveau;
	}

	public void setNiveau(String niveau) {
		this.niveau = niveau;
	}
	
	@Override
	public void afficherNomComplet() {
	System.out.println(this.getPrenom() + " " + this.getNom());
	}

	@Override
	public String toString() {
		return "Etudiant [niveau=" + niveau + ", getNum()=" + getNum() + ", getNom()=" + getNom() + ", getPrenom()="
				+ getPrenom() + ", getAdresse()=" + getAdresses() + ", toString()=" + super.toString() + ", getClass()="
				+ getClass() + ", hashCode()=" + hashCode() + "]";
	}
}
