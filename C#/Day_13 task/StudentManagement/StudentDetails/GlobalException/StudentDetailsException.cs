namespace StudentDetails.GlobalException
{
    public class StudentDetailsException : Exception
    {
        public static List<string> StudentDetailexception { get; set; } =
            new List<string>
            {
                "Student not found",
                "**"

            };
                
    }
}
