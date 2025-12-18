


namespace Utilities
{
    public class InsTKStringUtilities
    {
        public InsTKStringUtilities()
        {
        }

        public int CountOccurances(string stringToCheck, string stringToFind)
        {
            if (stringToCheck == null)
            {
                return -1;
            }

            var stringCharArray = stringToCheck.ToLower().ToCharArray();
            var stringToChecForAsChar = stringToFind.ToLower().ToCharArray()[0];
            var occuranceCount = 0;
            for (var cIndex = 0; cIndex < stringCharArray.Length; cIndex++)
            {
                if (stringCharArray[cIndex] == stringToChecForAsChar)
                { 
                    occuranceCount++; 
                }
            }
            return occuranceCount;
        }


    }
}