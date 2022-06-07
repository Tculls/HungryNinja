class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Ponzeh", 1000, false, false),
            new Food("Greem bens", 40, false, false),
            new Food("Hont Saize", 10, true, true),
            new Food("Gumbo", 1243, true, false),
            new Food("Panant bontr", 210, false, true),
            new Food("Borgir", 920, true, false),
            new Food("Expansive brad", 300, false, false),


        };
    }
     
    public Food Serve()
    {
        Random rand = new Random();
        Food dish = Menu[rand.Next(Menu.Count())];
        return dish;
    }
}
