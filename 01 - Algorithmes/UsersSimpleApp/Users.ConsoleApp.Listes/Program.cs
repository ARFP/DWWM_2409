namespace Users.ConsoleApp.Listes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enregistrement d'utilisateurs (gestion avec Listes).");

            //Variable
            bool majeur;
            DateTime formaDate;
            DateTime ajd = DateTime.Now;           
            int age = 0;
            string saisieNomPrenom;
            string saisieDate;
            string? metierCouleur = null;
            bool dateValide;
            ConsoleKey continuerO_N;
            List<string[]> utilisateurs = new();

            //Traitement
            do
            {
                Console.WriteLine("Saisissez le nom et Prénom.");
                saisieNomPrenom = Console.ReadLine();

                Console.WriteLine("Saisissez la date de naissane, jour/mois/année.");
                saisieDate = Console.ReadLine();
                if (DateTime.TryParse(saisieDate, out formaDate))
                {
                    TimeSpan intervalle = ajd - formaDate;
                    age = (int)(intervalle.Days / 365.25);
                }

                if(age<0)
                {
                    Console.WriteLine("Saisie non valide.");
                }

                else if (age<18)
                {
                    Console.WriteLine("couleur préféré ?");
                    metierCouleur = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Votre metier ?");
                    metierCouleur = Console.ReadLine();
                }

                string[] unUtilisateur = [saisieNomPrenom, saisieDate + " (" + age + ")", metierCouleur];

                Console.WriteLine("Voulez vous saisir un autre utilisateur : N/O ?");
                continuerO_N = Console.ReadKey(true).Key;



            }
            while (continuerO_N == ConsoleKey.O);


        }
    }
}
