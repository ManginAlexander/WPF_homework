using System;
using System.Windows;

namespace ConsoleApplication1
{
	class Program
	{
		public class AppCode : Application
		{
			[STAThread]
			public static void Main()
			{
				var app = new AppCode();
				var win = new Window();
				app.Run(win);
			}
		}
	}
}
