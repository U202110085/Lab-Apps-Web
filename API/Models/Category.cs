namespace API.Models;

public class Category
{
    public int id { get; set; }
    public string name { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
    
    public List<Tutorial> Tutorials { get; set; }

    public List<Tutorial> getTutorials()
    {
        return Tutorials;
    }

}
