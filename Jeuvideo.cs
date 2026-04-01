class Jeuvideo
{
    protected string titre;
    protected string studio;
    protected double prix;

    public string Titre { get{return titre;} set {titre = value;}}
    public string Studio { get{return studio;} set {studio = value;}}
    public double Prix { get{return prix;} set {prix = value;}}

    public Jeuvideo() {}
    public Jeuvideo(string titre, string studio, double prix)
    {
        this.titre = titre;
        this.studio = studio;
        this.prix = prix;
    }
}