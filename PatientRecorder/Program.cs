using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace PatientRecorder
{
	internal sealed partial class Program
	{
		[STAThread]
		static void Main()
		{
			try
			{
				Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(true);

				using (MainForm = new FormMain())
				{
					SingleInstanceApplication.Run(MainForm, NewInstanceHandler);
				}
			}
			catch (Exception ex)
			{
				string nl = Environment.NewLine;
				File.AppendAllText(fatalErrorPath, ex.ToString() + nl + nl, Encoding.Default);
				Process.Start(fatalErrorPath);
			}
			finally
			{
				
			}
		}
		
		static FormMain MainForm;

		public static void NewInstanceHandler(object sender, StartupNextInstanceEventArgs e)
		{
			e.BringToForeground = true;
			MainForm.NewInstance(e.CommandLine);
		}

		public class SingleInstanceApplication : WindowsFormsApplicationBase
		{
			private SingleInstanceApplication()
			{
				base.IsSingleInstance = true;
			}

			public static void Run(Form form, StartupNextInstanceEventHandler startupHandler)
			{
				SingleInstanceApplication app = new SingleInstanceApplication();
				app.MainForm = form;
				app.StartupNextInstance += startupHandler;
				app.Run(Environment.GetCommandLineArgs());
			}
		}

		public static readonly CultureInfo cult = new CultureInfo("tr-TR");

		public static readonly string exeDir = Path.GetDirectoryName(Application.ExecutablePath);

		public static readonly string fatalErrorPath = exeDir + "\\FatalError.log";

		public static readonly string recordPath = exeDir + "\\rec", 
			recordPath2 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData, Environment.SpecialFolderOption.Create) + "\\rec";

		public const string Title = "Kayıt Defteri";
	}
}
