namespace tpSerialisation;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        GestionJeux gestionsJeux = new GestionJeux();

        Jeuvideo g1 = new Jeuvideo("Fortnite", "Epic", 0);
        Jeuvideo g2 = new Jeuvideo("Valorant", "Riot Games", 0);
        Jeuvideo g3 = new Jeuvideo("Minecraft ", "Mojang ", 29.99);

        gestionsJeux.addGame(g1);
        gestionsJeux.addGame(g2);
        gestionsJeux.addGame(g3);

        gestionsJeux.Afficher();
        gestionsJeux.SauverCSV("C:\\Users\\lignaszewski\\Documents\\TP Orienté Objet\\tpSerialisation\\Jeux.csv");
        gestionsJeux.SauverXml("C:\\Users\\lignaszewski\\Documents\\TP Orienté Objet\\tpSerialisation\\Jeux.xml");
        gestionsJeux.SauverJson("C:\\Users\\lignaszewski\\Documents\\TP Orienté Objet\\tpSerialisation\\Jeux.json");

        gestionsJeux.ChargerCSV("C:\\Users\\lignaszewski\\Documents\\TP Orienté Objet\\tpSerialisation\\Jeux.csv");
        Console.WriteLine("-----------------------| APRES LE CHARGEMENT CSV |------------------------");
        gestionsJeux.Afficher();

        gestionsJeux.ChargerXml("C:\\Users\\lignaszewski\\Documents\\TP Orienté Objet\\tpSerialisation\\Jeux.xml");
        Console.WriteLine("-----------------------| APRES LE CHARGEMENT XML |------------------------");
        gestionsJeux.Afficher();
        
        gestionsJeux.ChargerJson("C:\\Users\\lignaszewski\\Documents\\TP Orienté Objet\\tpSerialisation\\Jeux.json");
        Console.WriteLine("-----------------------| APRES LE CHARGEMENT JSON |------------------------");
        gestionsJeux.Afficher();
    }
}
