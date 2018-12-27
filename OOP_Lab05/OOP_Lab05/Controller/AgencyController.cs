using System;
using System.Collections;

namespace OOP_Lab05
{
    class AgencyController
    {
        public static ArrayList SearchByWeight(Agency agency, int startWeight, int endWeight)
        {
            ArrayList returnedArray = new ArrayList();
            foreach (Vehicle item in agency.parkArray)
            {
                if(item.Weight > startWeight || item.Weight < endWeight)
                {
                    returnedArray.Add(item);
                }
            }
            return returnedArray;
        }

        public static void SortByWeight(Agency agency)
        {
            agency.parkArray.Sort();
        }
    }
}
