using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PersonAgeTesting
{
    public class CategoryOfPerson
    {
        int age;
        public CategoryOfPerson(int age)
        {
            this.age = age;
        }

        public string Category()
        {

            string category;
            try
            {
                if (age.Equals(0))
                {
                    throw new PersonAgeException("Age should not be eual to zero");
                }
                if (age >= 90)
                {
                    throw new PersonAgeException("Person age should  below 90");
                }
                if (age >= 1 && age <= 14)
                {
                    return "Children";
                }
                else if (age >= 15 && age <= 24)
                {
                    return "Youth";
                }
                else if (age >= 25 && age <= 64)
                {
                    return "Adult";
                }
                else if (age >= 65)
                {
                    return "Senior";
                }
            }
            catch (ArgumentNullException e)
            {
                throw new PersonAgeException(PersonAgeException.ExceptionTypes.NULL_MESSAGE, "age should not be null");
            }
            catch (FormatException e)
            {
                throw new PersonAgeException(PersonAgeException.ExceptionTypes.FORMAT_ERROR, "value is not in an appropriate format");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return null;

        }
    }
}
