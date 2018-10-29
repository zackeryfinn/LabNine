using System.Collections.Generic;

namespace LabNine
{

    

    public class FavoriteData
    {
        

        public FavoriteData(string studentName, string homeTown, string favoriteFood, string favoriteColor, string favoriteNumber)
        {
            StudentName = studentName;
            HomeTown = homeTown;
            FavoriteFood = favoriteFood;
            Color = favoriteColor;
            Number = favoriteNumber;
        }
        public string StudentName { set; get; }
        public string HomeTown { set; get; }
        public string FavoriteFood { set; get; }
        public string Color { set; get; }
        public string Number { set; get; }
    }
}
