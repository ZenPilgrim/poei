package org.eclipse.model;

import java.util.Arrays;

import org.eclipse.interfaces.IMiseEnForme;

public abstract class Personne implements IMiseEnForme {
	//Attributs en premier
	protected int num;
	protected String nom;
	protected String prenom;
	protected char sexe;
	protected Adresse[] adresses;
	//static = meme pour tous les objets
	private static int nbrPersonnes;
	
	//Constructeurs du - au + remplis
	//Toujours avoir un constructeur sans param pour Spring / Hibernate
	public Personne() {
		super();
		nbrPersonnes++;
	}
	
	public Personne(int num, String nom, String prenom) {
		super();
		setNum(num);
		this.nom = nom;
		this.prenom = prenom;
		nbrPersonnes++;
	}

	public Personne(int num, String nom, String prenom, char sexe, Adresse[] adresses) {
		super();
		this.num = num;
		this.nom = nom;
		this.prenom = prenom;
		this.sexe = sexe;
		this.adresses = adresses;
	}

	//Getters et Setters
	
	
	public abstract void afficherNomComplet();
	
	public int getNum() {
		return num;
	}

	public void setNum(int num) {
		this.num = num;
	}

	public String getNom() {
		return nom;
	}

	public void setNom(String nom) {
		this.nom = nom;
	}

	public String getPrenom() {
		return prenom;
	}

	public void setPrenom(String prenom) {
		this.prenom = prenom;
	}

	public char getSexe() {
		return sexe;
	}

	public void setSexe(char sexe) {
		this.sexe = sexe;
	}

	public Adresse[] getAdresses() {
		return adresses;
	}

	public void setAdresses(Adresse[] adresses) {
		this.adresses = adresses;
	}

	public static int getNbrPersonnes() {
		return nbrPersonnes;
	}

	public static void setNbrPersonnes(int nbrPersonnes) {
		Personne.nbrPersonnes = nbrPersonnes;
	}

	@Override
	public final void afficherPrenomMajuscule() {
		System.out.println(prenom.toUpperCase());
		
	}

	@Override
	public String toString() {
		return "Personne [num=" + num + ", nom=" + nom + ", prenom=" + prenom + ", sexe=" + sexe + ", adresses="
				+ Arrays.toString(adresses) + "]";
	}

	

	//TO STRING a la fin
	

}
