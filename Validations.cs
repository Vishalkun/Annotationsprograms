using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotations
{
    public class Validations
    {
        public static void validate_details()
        {
            UserDetails userobj = new UserDetails();
            userobj.first_name = "Sanjay";

            ValidationContext context = new ValidationContext(userobj, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(userobj, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult result in results)
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine(userobj.first_name);

            }
        }

    }
}
