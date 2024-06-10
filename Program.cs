namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int value = Int32.Parse("abc");
                Console.WriteLine(value);
            }
            catch (FormatException)
            {
                throw new CustomException("Invalid input: The input is not a valid integer.");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
