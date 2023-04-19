namespace ThePracticeExam.Program.Classes
{
    class Car
    {
        public string Model { get; set; }
        public int Price { get; set; }
        public double Power { get; set; }

        public override string ToString()
        {            
            return $"{Model} {Price} {Power}";
        }
    }
}
