sap.ui.define([], function () {
	"use strict";

	return {

    eloImage: function (elo) {
        
        switch (elo){

            case 0: return "../assets/Ferro.png "
            case 1: return "../assets/Bronze.png"
            case 2: return "../assets/Prata.png"
            case 3: return "../assets/Ouro.png"
            case 4: return "../assets/Platina.png"
            case 5: return "../assets/Diamante.png"
            case 6: return "../assets/Mestre.png"
            case 7: return "../assets/GM.png"
            case 8: return "../assets/Challenger.png"
     
        }  
    },
    eloLegenda: function (elo) {
        switch (elo){

            case 0: return "Ferro"
            case 1: return "Bronze"
            case 2: return "Prata"
            case 3: return "Ouro"
            case 4: return "Platina"
            case 5: return "Diamante"
            case 6: return ".Mestre"
            case 7: return "Grão Mestre"
            case 8: return "Desafiante"
     
        } 
    }

}});