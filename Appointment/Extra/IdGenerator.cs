namespace Appointments.Extra
{
    public class IdGenerator
    {
        public IdGenerator() { }

        public int GetId()
        {
            Random rnd = new Random();
            return rnd.Next();
        }
    }
}
