// Présentation de VueJS : https://worldline.github.io/vuejs-training/fr/presentation/
// Prise en main de VueJS : https://cours.brosseau.ovh/tp/vuejs3/tp0.html

/**
 * Exercice "Compteur de clics" Pur JS
 * https://arfp.github.io/tp/web/javascript/01-intro/
 */

/*
1. Ajouter un évènement sur le bouton "Ajouter 1"
    - Au clic sur le bouton, la valeur dans le <span> est incrémentée de 1
2. Ajouter un évènement sur le bouton "Réinitialiser"
- Au clic sur le bouton, la valeur dans le <span> est réinitialisée à 0
*/

const btnAjouter = document.querySelector('#ajouter');
const spanScore = document.querySelector('#score');
const btnReinitialiser = document.querySelector('#reinitialiser');

btnAjouter.addEventListener('click', () => {

    // Récupérer la valeur dans le span id="score"
    let nbClics = spanScore.textContent;
    console.log(nbClics);

    // Incrémenter la valeur
    nbClics++;
    console.log(nbClics);

    // Injecter la valeur incrémentée dans le span
    spanScore.textContent = nbClics;
});

btnReinitialiser.addEventListener('click', () => {
    // Réinitialiser la valeur du span à 0
    spanScore.textContent = 0;

})
