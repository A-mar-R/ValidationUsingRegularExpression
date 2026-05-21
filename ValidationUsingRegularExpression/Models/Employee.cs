using System.ComponentModel.DataAnnotations;

namespace ValidationUsingRegularExpression.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "First Name is required.")]
        public string?  FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")] 
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Designation is required.")]
        public  string? Designation { get; set; }

        [Required(ErrorMessage = "Email Address is required.")]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email address.")]
        public  string? EmailAddress { get; set; }
        
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Mobile number must be exactly 10 digits.")]
        public long MobileNumber { get; set; }
        [Required(ErrorMessage = "Age is required.")]
        public int? EmployeeAge { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
        public DateOnly? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        public string? Password { get; set; }
    }
}
