using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using MarkdownSharp;
using System.IO;

namespace MarkdownWin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0) {
                RunCli(args);
            } else {
                RunForm();
            }
        }

        static void RunForm() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static void RunCli(string[] args) {
            const string inArg = "in";
            const string outArg = "out";
            const string cssArg = "css";
            const string helpArg = "help";

            try {
                var parsedArgs = ParseArgsRaw(args);

                if (parsedArgs.ContainsKey(helpArg))
                    PrintCliHelp();
                else {
                    var inPath = GetAbsPath(parsedArgs[inArg][0]);
                    var outPath = GetAbsPath(GetOutPath(inPath, outArg, parsedArgs));

                    var mkDown = new Markdown();
                    var result = mkDown.Transform(File.ReadAllText(inPath));

                    File.WriteAllText((outPath), result, System.Text.Encoding.UTF8);
                }
            } catch (Exception ex) {
                PrintCliHelp(ex.Message);
            }
        }

        private static string GetOutPath(string inPath, string outArg, Dictionary<string, IList<string>> parsedArgs) {
            if (parsedArgs.ContainsKey(outArg))
                return parsedArgs[outArg][0];
            else {
                var fi = new FileInfo(inPath);
                return fi.FullName.Substring(0, fi.FullName.Length - fi.Extension.Length) + ".html";
            }
        }

        static string GetAbsPath(string path) {
            if (Path.IsPathRooted(path))
                return path;
            else
                return Path.Combine(Environment.CurrentDirectory, path);
        }

        static void PrintCliHelp(string errorMsg = "") {
            if (errorMsg != "")
                Console.WriteLine("Error: " + errorMsg);

            Console.WriteLine("Usage: -in <inputPath> -out <outputPath> [-css <cssStyleSheet>]");
        }

        static Dictionary<string, IList<string>> ParseArgsRaw(string[] args) {
            var parsedArgs = new Dictionary<string, IList<string>>();

            var prev = string.Empty;
            var curr = string.Empty;

            for (int i = 0; i < args.Length; i++) {
                curr = args[i];

                if (curr.StartsWith("-")) {
                    var arg = curr.TrimStart('-');

                    parsedArgs[arg] = new List<string>(2);
                    prev = arg;
                } else if (!String.IsNullOrEmpty(prev)) {
                    parsedArgs[prev].Add(curr);
                } else {
                    throw new ArgumentException("invalid syntax");
                }
            }

            return parsedArgs;
        }
    }
}
