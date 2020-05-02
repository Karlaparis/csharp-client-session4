using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Diagnostics;
namespace Homework4
{

	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			uxSubmit.IsEnabled = false;
			uxZipcode.Focus();
		}

		private void uxZipcode_TextChanged(object sender, TextChangedEventArgs e)
		{
			string uspattern = @"^[0-9]{5}(?:-[0-9]{4})?$";
			string capattern = @"^[ABCEGHJKLMNPRSTVXYabceghjklmnprstvxy]{1}\d{1}[A-Za-z]{1}\d{1}[A-Za-z]{1}\d{1}$";

			Regex UsZipCode = new Regex(uspattern);
			Regex CaZipCode = new Regex(capattern);
			bool UsMatch = UsZipCode.IsMatch(uxZipcode.Text);
			bool CaMatch = CaZipCode.IsMatch(uxZipcode.Text);


			if (UsMatch == true)
			{
				uxSubmit.IsEnabled = true;
			}

			else
			{
				uxSubmit.IsEnabled = false;

				if (CaMatch == true)
				{ uxSubmit.IsEnabled = true; }
				else 
				{ uxSubmit.IsEnabled = false; }
			}


		}
	}

}
