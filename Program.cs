namespace tpSerialisation;

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
    }
}
