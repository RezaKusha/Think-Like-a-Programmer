using System;

namespace Automobile
{
    public class Automobile
    {
        private string _name;
        private string _companyName;
        private int _yearCreated;

        public string GetName()
        {
            return _name;
        }
        
        public void SetName(string name)
        {
            _name = name;
        }
        
        public string GetCompanyName()
        {
            return _companyName;
        }
        
        public void SetCompanyName(string companyName)
        {
            _companyName = companyName;
        }
        
        public int GetYear()
        {
            return _yearCreated;
        }

        public void SetYear(int year)
        {
            _yearCreated = year;
        }
    }
}