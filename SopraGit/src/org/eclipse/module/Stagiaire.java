package org.eclipse.module;

import java.util.Arrays;

public class Stagiaire {
	private String nom;
	private float [] notes;
	
	
	
	public Stagiaire(String nom, float[] notes) {
		super();
		this.nom = nom;
		this.notes = notes;
	}
	
	
	public String getNom() {
		return nom;
	}
	public void setNom(String nom) {
		this.nom = nom;
	}
	public float[] getNotes() {
		return notes;
	}
	public void setNotes(float[] notes) {
		this.notes = notes;
	}
	
	public float calculerMoyenne() {
		float somme = 0;
		for (float note : notes) {	  
	         somme += note;
		}
	    return somme / notes.length;
	}
	
	public float trouverMax() {
		if (notes.length == 0) {
			return -1;
			}
		float max = 0;
		for(float note : notes){
	         if(note > max)
	        	 max = note;
	       }
		return max;
	}
	
	public float trouverMin() {
		if (notes.length == 0) {
			return -1;
			}
		float min = 20;
		for(float note : notes){
	         if(note < min)
	        	 min = note;
	       }
		return min;
	}


	@Override
	public String toString() {
		return "Stagiaire [nom=" + nom + ", notes=" + Arrays.toString(notes) + "]";
	}

	
	
}
