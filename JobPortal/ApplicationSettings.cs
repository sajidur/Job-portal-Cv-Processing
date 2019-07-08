using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal
{
    public class ApplicationSettings
    {
        public static string Inputurl { get; set; }
        public static DataTable Data { get; set; }
        public static int OTPExpirationTime { get; set; }
        public static string TransactionFolderURL { get; set; }
        public static string Outputurl { get; set; }
    }
}
