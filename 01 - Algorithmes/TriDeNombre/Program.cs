// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tri de Nombres ++");

// VARIABLES

int numA;
int numB;
int numC;
int[] nombres;
string saisieUtilisateur;

// TRAITEMENT

Console.WriteLine("Entrez le premier nombre");
saisieUtilisateur = Console.ReadLine(); // Récupération d'une saisie utilisateur
numA = int.Parse(saisieUtilisateur); // Conversion de la saisie en nombre entier

Console.WriteLine("Entrez le deuxième nombre");
saisieUtilisateur = Console.ReadLine();
numB = int.Parse(saisieUtilisateur);

Console.WriteLine("Entrez le troisième nombre");
saisieUtilisateur = Console.ReadLine();
numC = int.Parse(saisieUtilisateur);

nombres = [numA, numB, numC];

Array.Sort(nombres);

// AFFICHAGE

    for (int i = 0; i < nombres.Length; i++)
    {
        Console.WriteLine(nombres[i]);
    }
    
Console.ReadLine();
