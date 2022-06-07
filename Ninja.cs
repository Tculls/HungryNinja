class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;
    
    // add a constructor
    public Ninja()
    {
        calorieIntake = 0; 
        FoodHistory = new List<Food>();
    }
    // add a public "getter" property called "IsFull"
    bool IsFull
    {
        get
        {
            return calorieIntake > 1200;
        }
    }
    // build out the Eat method
    public void Eat(Food item)
    {
        // not full
        if(IsFull == false)
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine($"Ninja just consumed {item.Name}");
            if (item.Spicy)
                Console.WriteLine($"This {item.Name} is freakin spicy i need some milk");
            if (item.Sweet)
                Console.WriteLine($"{item.Name} has got some mad sugar this is not good for my longterm longevity");
        }
        else
        {
            Console.WriteLine($"Over stuffed ninja, no more food");
        }
    }
}

