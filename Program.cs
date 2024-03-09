namespace CIT_195_Lesson_5_Club_Interface
{
    public interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public string FullName();
    }
    class Program
    {
        class Member : IClub
        {

            public string Slogan { get; set; }
            public int WeightKG { get; set; }
            public int HeightCM { get; set; }
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Member()
            {
                Slogan = string.Empty;
                WeightKG = 0;
                HeightCM = 0;
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
            }
            public Member(int id, string firstName, string lastName, string slogan, int weightKG, int heightCM)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Slogan = slogan;
                WeightKG = weightKG;
                HeightCM = heightCM;
            }
            public string FullName()
            {
                return FirstName + " " + LastName;
            }
            public string AllStats()
            {
                return $"ID = {Id}\nWeight = {WeightKG} kg\nHeight = {HeightCM} cm\nSlogan = {Slogan}";
            }
        }
        static void Main(string[] args)
        {
            Member Wimpy = new Member(1234, "J. Wellington", "Wimpy", "I will gladly pay you Tuesday", 155, 168);
            Console.WriteLine(Wimpy.FullName());
            Console.WriteLine(Wimpy.AllStats());
        }
    }
}
