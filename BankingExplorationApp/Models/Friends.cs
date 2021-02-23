using System;
namespace BankingExplorationApp.Models
{
    public class Friends
    {
        private string _image = string.Empty;
        private string _name = string.Empty;

        public Friends(string image, string name)
        {
            Image = image;
            Name = name;
        }

        public string Image
        {
            get { return _image;  }
            set { _image = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}