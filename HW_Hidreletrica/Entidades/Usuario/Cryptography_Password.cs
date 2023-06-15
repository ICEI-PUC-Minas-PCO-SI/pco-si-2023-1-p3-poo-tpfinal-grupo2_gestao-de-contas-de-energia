using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Usuario
{
	static class Cryptography_Password
	{
		public static string CryptographyMethod(string input)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] inputBytes = Encoding.UTF8.GetBytes(input);
				byte[] hashBytes = sha256.ComputeHash(inputBytes);

				StringBuilder sb = new StringBuilder();
				foreach (byte b in hashBytes)
				{
					sb.Append(b.ToString("x2"));
				}

				return sb.ToString();
			}
		}
	}
}
