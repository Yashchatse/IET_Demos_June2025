using _35MyAttributeLib;

namespace _36EmpLib
{
	[Table(TableName ="Emp")]
    public class Employee
    {
		private int _Id;
		private string _Name;
		private string _Address;

        [Column(ColumnName = "EId", ColumnType = "int")]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        [Column(ColumnName = "EName", ColumnType = "varchar(50)")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        [Column(ColumnName ="EAddress",ColumnType ="varchar(50)")]
		public string Address
		{
			get { return _Address; }
			set { _Address = value; }
		}
        
	}
}
