using System;
using System.Collections.Generic;
using BankingExplorationApp.Models;

namespace BankingExplorationApp.ViewModels
{
    public class ActivityViewModel
    {
        private List<Friends> friendsCollection = new List<Friends>();
        private List<Activities> activityCollection = new List<Activities>();

        public ActivityViewModel()
        {
            //Friends
            friendsCollection.Add(new Friends("Marie.png","Marie"));
            friendsCollection.Add(new Friends("Ashley.png", "Ashley"));
            friendsCollection.Add(new Friends("Petter.png", "Petter"));
            friendsCollection.Add(new Friends("Marie.png", "Marie"));
            friendsCollection.Add(new Friends("Ashley.png", "Ashley"));
            //Activity
            activityCollection.Add(new Activities("Amazon", "Today, 08:00am","Amazon Drew","$200.00"));
            activityCollection.Add(new Activities("Spotify", "31 Jan, 11:00am", "Spotify Premiun", "-$8.90"));
            activityCollection.Add(new Activities("McDonals", "29 Jan, 03:10am", "McDonals's", "-$62.80"));
            activityCollection.Add(new Activities("Amazon", "Today, 08:00am", "Amazon Drew", "$200.00"));
        }
        public List<Friends> FriendsCollection
        {
            get { return friendsCollection; }
            set { friendsCollection = value; }
        }
        public List<Activities> ActivitiesCollection
        {
            get { return activityCollection; }
            set { activityCollection = value; }
        }
    }
}
