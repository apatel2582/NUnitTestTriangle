namespace NUnitDemonstration
{
    public class Triangle
    {
        public string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            //Console.WriteLine(result);
            return result;
        }
    }


}


