using RDotNet;
using System.Reflection;

namespace MTSR
{
	public static class R
	{
		public static DataFrame Run(string cmd) => REngine.GetInstance().Evaluate(cmd).AsDataFrame();
		public static DataFrame RunScript(string filePath) => Run(Assembly.GetExecutingAssembly().GetText(filePath));
		public static string ToRPath(string path) => path.Replace("\\", "\\\\");
	}
}
