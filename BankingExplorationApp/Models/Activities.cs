using System;
namespace BankingExplorationApp.Models
{
    public class Activities
    {
        private string _image = string.Empty;
        private string _date = string.Empty;
        private string _title = string.Empty;
        private string _price = string.Empty;

        public Activities(string image, string date, string title, string price)
        {
            Image = image;
            Date  = date;
            Title = title;
            Price = price;
        }
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
