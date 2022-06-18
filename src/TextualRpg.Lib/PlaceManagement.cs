namespace TextualRpg.Lib
{
    public class PlaceManagement 
    {
        public Place GenratePlace()
        {
            return new Place() { Id=Guid.NewGuid(), 
                                 Name= "This is a place"};
        } 
    }
}