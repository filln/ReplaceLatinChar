// Copyright 2021 Anatoli Kucharau https://vk.com/ulvprog. All Rights Reserved.

/**
 * Программа для замены латинских символов текста на кириллические, которые выглядят одинаково.
 * 
 */


using System.Windows;

namespace ReplaceLatinChar
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private string latinArr = "eyopaxcETOPAHKXCBM";
		private string cyrillicArr = "еуорахсЕТОРАНКХСВМ";

		private void ReplaceButton_Click(object sender, RoutedEventArgs e)
		{
			OutputTextBox.Clear();
			int latinArrLength = latinArr.Length;
			int inputTextLength = InputTextBox.Text.Length;
			char[] outputCharArr = new char[inputTextLength];
			InputTextBox.Text.CopyTo(0, outputCharArr, 0, inputTextLength);
			int countOfReplaces = 0;
			for (int charIndex = 0; charIndex < inputTextLength; charIndex++)
			{
				for (int latinIndex = 0; latinIndex < latinArrLength; latinIndex++)
				{
					if (outputCharArr[charIndex] == latinArr[latinIndex])
					{
						outputCharArr[charIndex] = cyrillicArr[latinIndex];
						countOfReplaces++;
						break;
					}
				}
			}
			OutputTextBox.Text = new string(outputCharArr);
			stateLabel.Content = "Количество замен: " + countOfReplaces.ToString();
		}




	}
}
