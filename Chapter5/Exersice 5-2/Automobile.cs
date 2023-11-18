using System;

namespace Automobile
{
    public class Automobile
    {
        private string _name;
        private string _companyName;
        private int _yearCreated;
        private const int _presentYear = 2023;
        
        public int GetAge()
        {
            int age = _presentYear - _yearCreated;
            return age;
        }

        public void CompleteInformation(string companyName, string name, int year)
        {
            _companyName = companyName;
            _name = name;
            _yearCreated = year;
            Console.Write($"{_companyName} {_name} {_yearCreated} ");
        }
    }
}