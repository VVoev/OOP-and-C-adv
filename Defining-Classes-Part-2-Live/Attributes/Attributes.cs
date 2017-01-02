
using System;
using System.Runtime.InteropServices;

class UsingAttributes
{
	[DllImport("user32.dll", EntryPoint = "MessageBox")]
	public static extern int ShowMessageBox(int hWnd,
		string text, string caption, int type);

	public static void TestAtribute()
	{
		ShowMessageBox(0, "Your text is here", "Error message", 3);
	}
}