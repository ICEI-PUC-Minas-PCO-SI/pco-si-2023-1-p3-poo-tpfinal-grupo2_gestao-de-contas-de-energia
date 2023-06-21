using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services {
	public interface IRepository {
		public void Add<T>(T entity) where T : class;
	}
}
