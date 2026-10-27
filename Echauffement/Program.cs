using System.ComponentModel.Design;

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré

        Console.WriteLine("Je m'appele Misha, mon jeu préferé est CS2 ");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge

        Console.WriteLine("Quelle est votre Prénom ? ");
        string name = Console.ReadLine();
        Console.WriteLine("Quelle est votre age? ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        
        if (age >= 18)
        {
            Console.WriteLine("Tu es majeur ");
        }
        else
        {
            Console.WriteLine("Tu es mineur ");
        }
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)

        Console.WriteLine("Combien d'euro a tu ? ");
        float euros = Convert.ToSingle(Console.ReadLine());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix

        Console.WriteLine("\n --- Coix d'armes ---");
        Console.WriteLine("Dynamite = $ 1.00 ");
        Console.WriteLine("Couteau = $ 10.00 ");
        Console.WriteLine("Revolver = $ 35.00 ");
        Console.WriteLine("Vinchester = $ 120.00 ");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4

        Console.WriteLine("Quelle arme tu veux acheter ? 1/2/3/4 ");
        int choix = Convert.ToInt32(Console.ReadLine());

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

        if (choix == 1)
        {
            if (euros > 1.0f)
            {
                Console.WriteLine("T'as assé d'argents");
            }
            else
            {
            Console.WriteLine("T'as pas assé d'argent");
            }
        }
        else if (choix == 2)
        {
            if (euros > 10.0f)
            {
                Console.WriteLine("T'as assé d'argents");
            }
            else
            {
                Console.WriteLine("T'as pas assé d'argent");
            }
        }
        else if (choix == 3)
        {
            if (euros > 35.0f)
            {
                Console.WriteLine("T'as assé d'argents");
            }
            else
            {
                Console.WriteLine("T'as pas assé d'argent");
            }
        }
        else if (choix == 4)
        {
            if (euros > 120.0f)
            {
                Console.WriteLine("T'as assé d'argents");
            }
            else
            {
                Console.WriteLine("T'as pas assé d'argent");
            }
        }
        else
        {
            Console.WriteLine("Ton choix ne fait pas partie des repponces !");
        }
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}