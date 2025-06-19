namespace _35MyCustomAttribute
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class BVS : Attribute
    {
		private string _CompanyName;
		private string _DeveloperName;

		public string DeveloperName
		{
			get { return _DeveloperName; }
			set { _DeveloperName = value; }
		}

		public string CompanyName
		{
			get { return _CompanyName; }
			set { _CompanyName = value; }
		}

	}
}
