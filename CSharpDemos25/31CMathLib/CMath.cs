using _35MyCustomAttribute;

namespace _31CMathLib
{
    [Serializable]
    [BVS(CompanyName ="BonaventureSystems",DeveloperName ="Mugdha")]
    public class CMath
    {
        //[BVS(CompanyName = "BonaventureSystems", DeveloperName = "Mugdha")]
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
