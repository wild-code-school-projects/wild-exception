namespace Exceptions
{
    internal class CustomException : Exception
    {

        private readonly DateTime _dateTime;

        public CustomException(string message) : base(message)
        {
            _dateTime = DateTime.Now;
            Console.WriteLine($"{_dateTime.Hour}:{_dateTime.Minute}:{_dateTime.Second} - {message}");
        }
    }
}
