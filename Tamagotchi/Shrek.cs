public class Shrek
{
    private int hunger = 4;
    private int boredom = 4;
    private int hp = 10;
    private bool alive = true;
    Random generator = new Random();
    private List<string> word = new List<string>() {"Donkey" , "Swamp"};
    private int rnd;
    public string name = "Shrek";

    public void Feed(){
        hunger ++;
        boredom --;
        if(hunger >= 10)hunger = 10;
         Console.WriteLine($"{name} gets food and becomes happy");
    }
    public void Talk(){
        int rndWord = generator.Next(word.Count);
        Console.WriteLine($"{name} says {word[rndWord]}");
        Rounds();
    }
    public void Teach(string teached){
        Console.WriteLine($"{name} learned your word");
        word.Add(teached);
        Rounds();
    }
    public void Stats(){
        Console.WriteLine("*------------*");
        Console.WriteLine($"Name: {name} \nHunger: {hunger}\nBoredom: {boredom} \nHealth: {hp}");
        Console.WriteLine("*------------*");
    }
    public bool Alive(){
        return alive;
    }
    public void Tick(){
        rnd = generator.Next(3);
        hunger -=rnd;
        boredom --;
        Console.WriteLine(rnd);
        if(hunger >= 6){
            hp--;
        }
        else if(hunger <= 0 || boredom <= 0){
         alive = false;
        }
    }
    private void Rounds(){
        boredom++;
        hunger--;
    }
}
