package org.eclipse.test;

import org.eclipse.module.Formation;
import org.eclipse.module.Stagiaire;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Stagiaire stagiaire = new Stagiaire ("Dupuis", new float[] { 6,5, 17, 9,25, 15, 7,5 });
		System.out.println(stagiaire.calculerMoyenne());
		
		Stagiaire stagiaire2 = new Stagiaire ("Bernard", new float[] {5, 17, 4,25, 20});
		Stagiaire stagiaire3 = new Stagiaire ("Fringale", new float[] { 5, 17, 15});
		System.out.println(stagiaire2.trouverMin());
		System.out.println(stagiaire3.trouverMax());
		
		Formation formation = new Formation ("POEI", 7, new Stagiaire[] { stagiaire, stagiaire2, stagiaire3});
		System.out.println(formation.calculerMoyenneFormation());
		System.out.println(formation.getIndexMax());
		System.out.println(formation.afficherNomMax());
		System.out.println(formation.afficherMinMax());
		System.out.println(formation.trouverMoyenneParNom("Bernard"));
	}

}
