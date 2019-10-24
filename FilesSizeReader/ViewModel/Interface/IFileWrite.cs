using System.Collections.Generic;

namespace ViewModel.Interface
{
	public interface IFileWrite<T>
	{
		void WriteFile(string filePath, IEnumerable<T> items);
	}
}
