namespace ThePracticeExam.Program.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public int Price { get; set; }
        public int Power { get; set; }

        public override string ToString()
        {            
            return $"{Model} {Price} {Power}";
        }
    }
}
