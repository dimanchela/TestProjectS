using System;
using System.Windows;
using System.Windows.Forms;
using ViewModel;

namespace FilesSizeReader
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		FileViewModel _viewModel;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnOpen_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				FolderBrowserDialog folderDialog = new FolderBrowserDialog();

				if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					lbPath.Content = folderDialog.SelectedPath;
					_viewModel.SetPath = folderDialog.SelectedPath;
				}
			}
			catch (Exception ex) 
			{
				System.Windows.Forms.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnStart_Click(object sender, RoutedEventArgs e)
		{
			btnOpen.IsEnabled = btnStart.IsEnabled = false;
			_viewModel.StartWorkerWithBinaryFiles();
		}
	}
}
