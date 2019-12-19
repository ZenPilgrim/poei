package org.eclipse.interfaces;

public interface IMiseEnForme {
	
	public String prenom = "none";
	
	public default void afficherNomMajuscule() {
		System.out.println(prenom.toUpperCase());
	};
	public abstract void afficherPrenomMajuscule();
}
