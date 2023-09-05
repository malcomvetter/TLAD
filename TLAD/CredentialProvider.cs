using System;
using System.Text;

namespace TLAD
{
    public static class CredentialProvider
    {
        public static string Domain { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }

        public static string Print()
        {
            return "{" + string.Format($"\"domain\":\"{Domain}\", \"username\":\"{Username}\", \"password\":\"{Password}\"") + "}";
        }
    }
}
