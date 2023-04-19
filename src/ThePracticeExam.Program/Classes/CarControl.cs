namespace ThePracticeExam.Program.Classes
{
    public class CarControl
    {
        public CarControl(int length)
        {
            _cars = new Car[length];
        }
        public CarControl(Car[] cars)
        {
            _cars = cars;
        }

        private Car[] _cars;

        public int Legnth => _cars.Length;

        public Car this[int i]
        {
            get => _cars[i];
            set => _cars[i] = value;
        }
        
        public void Sort()
        {
            for (int y = 0; y < _cars.Length - 1; y++)
            {
                for (int i = 0; i < _cars.Length - 1; i++)
                {
                    // Sorting by Power
                    if (_cars[i].Power > _cars[i + 1].Power)
                    {
                        var buf = _cars[i];
                        _cars[i] = _cars[i + 1];
                        _cars[i + 1] = buf;
                    }

                    // Sorting by Price
                    else if (_cars[i].Power == _cars[i + 1].Power)
                    {
                        if (_cars[i].Price > _cars[i + 1].Price)
                        {
                            var buf = _cars[i];
                            _cars[i] = _cars[i + 1];
                            _cars[i + 1] = buf;
                        }
                    }
                }
            }
        }

        public void Print()
        {
            foreach (var a in _cars) 
            {
                System.Console.WriteLine(a);
            }
        }
    }
}
