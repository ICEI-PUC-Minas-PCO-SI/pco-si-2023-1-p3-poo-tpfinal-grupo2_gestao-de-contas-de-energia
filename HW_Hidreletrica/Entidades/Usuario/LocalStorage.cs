using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_Hidreletrica.Entidades.Usuario {
	public static class LocalStorage {

		public static string filePath = "userLogado.txt";
		public static void salvaInformacoes(string nome, string email, int codigo, string tipoUsuario) {
			StreamWriter arq = new StreamWriter(filePath);
			arq.WriteLine(codigo);
			arq.WriteLine(tipoUsuario);
			arq.WriteLine(email);
			arq.WriteLine(nome);
			arq.Close();
		}

		public static string getTipoUsuario() {
			string tipoUsuario = ReadFile(2);
			return tipoUsuario;
		}

		public static int getCodigoUsuario() {
			int codigo = int.Parse(ReadFile(1));
			return codigo;
		}

		static string ReadFile(int linha) {
			using (StreamReader reader = new StreamReader(filePath)) {
				for (int i = 1; i < linha; i++) {
					reader.ReadLine();
				}
				return reader.ReadLine();
			}
		}

	}
}
