namespace _35MyAttributeLib
{
	[AttributeUsage(AttributeTargets.Class)]
    public class Table : Attribute
    {
		private string _TableNAme;

		public string TableName
		{
			get { return _TableNAme; }
			set { _TableNAme = value; }
		}
	}
	[AttributeUsage(AttributeTargets.Property)]
    public class Column : Attribute
    {
        private string _ColumnName;
		private string _ColumnType;

		public string ColumnType
		{
			get { return _ColumnType; }
			set { _ColumnType = value; }
		}

		public string ColumnName
        {
            get { return _ColumnName; }
            set { _ColumnName = value; }
        }
    }
}
