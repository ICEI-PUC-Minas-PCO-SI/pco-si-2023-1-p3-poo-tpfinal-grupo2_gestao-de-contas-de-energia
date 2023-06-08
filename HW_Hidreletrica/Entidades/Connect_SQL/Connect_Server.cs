using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Connect_SQL
{
	internal static class Connect_Server
	{
		public static string server = @"(localdb)\MSSQLLocalDB";
		public static string database = "master";
		public static string user = "";
		public static string password = "";
		
		public static string Connect()
		{
			return $"Data Source={server}; Integrated Security=True;Initial Catalog={database}; User ID={user}; Password={password}";
		}
	}
}

