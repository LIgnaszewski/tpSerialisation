using System.IO;
class GestionJeux
{
    protected List<Jeuvideo> jeuvideos;
    
    public void addGame(Jeuvideo game)
    {
        if (jeuvideos == null)
        {
            jeuvideos = new List<Jeuvideo>();
        }

        jeuvideos.Add(game);
    }

    public void deleteGame(Jeuvideo game)
    {
        bool found = false;
        foreach(Jeuvideo g in jeuvideos)
        {
            if (game == g)
            {
                found = true;
            }
        }

        if (found == false) Console.WriteLine("Le jeu video n'est pas dans la liste");
        else
        {
            jeuvideos.Remove(game);
            Console.WriteLine("Jeu supprimé avec succès de la liste");
        }
    }

    public void Afficher()
    {
        Console.WriteLine("La liste des jeux : ");
        foreach (Jeuvideo g in jeuvideos)
        {
            Console.WriteLine($" - {g.Titre} | {g.Studio} | {g.Prix}€");
        }
    }

    public void SauverCSV(string filePath)
    {
        StreamWriter writer = new StreamWriter(filePath);
        foreach (Jeuvideo g in jeuvideos)
        {
            writer.WriteLine(g.Titre + ";" +
            g.Studio + ";" +
            g.Prix);
        }
        writer.Close();
    }
}