using System;
namespace DefiningClasses
{
    public class DataModifier
    {

        public int CalculateTheDifference(string firstDay, string secoundDay)
        {
            string[] firstInput;
            firstInput = firstDay.Split();
            int firstInputYear = int.Parse(firstInput[0]);
            int firstInputMonth = int.Parse(firstInput[1]);
            int firstInputDay = int.Parse(firstInput[2]);
            DateTime firstDate = new DateTime(firstInputYear, firstInputMonth, firstInputDay);

            string[] secoundInput;
            secoundInput = secoundDay.Split();
            int secoundInputYear = int.Parse(secoundInput[0]);
            int secoundInputMonth = int.Parse(secoundInput[1]);
            int secoundInputDay = int.Parse(secoundInput[2]);
            DateTime secoundDate = new DateTime(secoundInputYear, secoundInputMonth, secoundInputDay);

            var result = (secoundDate - firstDate).TotalDays;

            if (result < 0)
            {
                result = result * -1;
            }

            return (int)result;
        }
    }
}
