namespace Names
{
    public class Name
    {
        private int id;
        private string name;
        private string lastname;

        public Name(int id, string name, string lastname)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
        }

        public int Id { get { return id; } private set { } }

        public string FirstName { get { return name; } private set { } }
    }
}