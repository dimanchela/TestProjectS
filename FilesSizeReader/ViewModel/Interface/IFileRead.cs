namespace ViewModel.Interface
{
	public interface IFileRead<T>
	{
		T ReadFile(string filePath);
	}
}
