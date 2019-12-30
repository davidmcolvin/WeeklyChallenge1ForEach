using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> names = GetPeopleStrings();

      foreach (var item in names)
      {
        Console.WriteLine($"Hello {item}");
      }

      List<PersonModel> people = GetPeople();

      foreach (var item in people)
      {
        Console.WriteLine($"Hello {item.FirstName} {item.LastName}");
      }

      Console.ReadLine();
    }

    private static List<PersonModel> GetPeople()
    {
      return new List<PersonModel> {
      new PersonModel {FirstName="David", LastName="Colvin" },
      new PersonModel {FirstName="Sue", LastName="Storm" },
      new PersonModel {FirstName="Trevor", LastName="Skole"}
      };
    }

    private static List<string> GetPeopleStrings()
    {
      return new List<string> { "John", "Mary", "Sue", "Greg", "Yolanda" };
    }
  }
}
