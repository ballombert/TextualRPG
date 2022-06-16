namespace TextualRpg.Lib
{
    public class Place 
    {
        public Guid Id {get;}
        public string Name {get;}

        public Place (string name)
        {
            Id= Guid.NewGuid();
            this.Name= name;
        }
    }
}