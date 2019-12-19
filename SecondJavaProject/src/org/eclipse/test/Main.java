package org.eclipse.test;

import org.eclipse.enums.Sport;
import org.eclipse.model.Adresse;
import org.eclipse.model.Etudiant;
import org.eclipse.model.ListePersonnes;
import org.eclipse.model.Enseignant;
import org.eclipse.model.Personne;

public class Main {

	public static void main(String[] args) {
//		Personne personne = new Personne();
//		personne.setNum(1);
//		personne.setNom("wick");
//		personne.setPrenom("john");
//		
//		System.out.println(personne.getNum() + " " + personne.getNom()
//		+ " " + personne.getPrenom());
//
//		Personne personne2 = new Personne(2,"bob","mike");
//		System.out.println(personne2);
//		System.out.println(Personne.getNbrPersonnes());

//		Personne personne = new Personne(1,"ross","bob",
//				new Adresse("Rue truc","13004","Marseille"));
//		
//		System.out.println(personne);
//		Etudiant etudiant = new Etudiant(1,"ross","bob",
//				new Adresse("Rue truc","13004","Marseille"),
//				"CM1");
//		Etudiant etudiant2 = new Etudiant(2,"dilan","bob",
//				new Adresse("Rue chose","13005","Marseille"),
//				"CM2");
//		Enseignant enseignant = new Enseignant(3,"moran","bob",
//				new Adresse("Rue machin","13006","Marseille"),
//				2250);
//		Enseignant enseignant2 = new Enseignant(4,"leponge","bob",
//				new Adresse("Rue chouette","13007","Marseille"),
//				1950);
//		Personne [] personnes = {etudiant, etudiant2, enseignant, enseignant2};
		
//		for(Personne personne : personnes) {
//			if (personne instanceof Etudiant) {
//				System.out.println( ((Etudiant) personne).getNiveau());
//			} else {
//				System.out.println( ((Enseignant) personne).getSalaire());
//			}
//		}
		
//		enseignant3.afficherNomMajuscule();
//		enseignant3.afficherPrenomMajuscule();
		
//		Sport sport = Sport.BASKET;
//		System.out.println(sport);
		
//		Etudiant etudiant = new Etudiant(2,"dilan","bob",
//				new Adresse("Rue chose","13005","Marseille"),
//				"CM2");
		Enseignant enseignant = new Enseignant(3,"Green","Jonas", 'M',
				new Adresse[] {new Adresse("Rue chouette","13007","Marseille")}, 1700);
		ListePersonnes personnes = new ListePersonnes(new Personne[] {enseignant});
		personnes.editPersonneNom("Green", "Red");
		personnes.editPersonneVilles("Red", "Paris");
		System.out.println(enseignant);
	}

}
