using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Collections.Generic;
public class GestionJeux
{
    protected List<Jeuvideo> jeuvideos= new List<Jeuvideo>();
    
    public void addGame(Jeuvideo game)
    {

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

    public void ChargerCSV(string filePath)
    {
        jeuvideos.Clear();
        if (File.Exists(filePath))
        {
            StreamReader reader = new StreamReader(filePath);
            while (!reader.EndOfStream)
        {
        string ligne = reader.ReadLine();
        string[] morceaux = ligne.Split(';');
        Jeuvideo g = new Jeuvideo();
        g.Titre = morceaux[0];
        g.Studio = morceaux[1];
        g.Prix = double.Parse(morceaux[2]);
        jeuvideos.Add(g);
        }
        reader.Close();
        }
    }

    public void SauverXml(string filePath)
    {
        XmlSerializer xs = new XmlSerializer(typeof(List<Jeuvideo>));
        StreamWriter writer = new StreamWriter(filePath);
        xs.Serialize(writer, jeuvideos);
        writer.Close();
    }

    public void ChargerXml(string filePath)
    {
        if (File.Exists(filePath))
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Jeuvideo>));
            StreamReader reader = new StreamReader(filePath);
            jeuvideos = (List<Jeuvideo>)xs.Deserialize(reader);
            reader.Close();
        }
    }

    public void SauverJson(string filePath)
    {
        string json = JsonSerializer.Serialize(jeuvideos);
        File.WriteAllText(filePath, json);
    }

    public void ChargerJson(string filePath)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            jeuvideos = JsonSerializer.Deserialize<List<Jeuvideo>>(json);
        }
    }
    
}