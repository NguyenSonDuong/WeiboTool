using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ControllerWeibo
{
    public delegate void RunInvoker();
    public class ActionWeibo
    {
        public static void InvokerFunction(Control cotrol, RunInvoker run)
        {
            cotrol.Invoke(new MethodInvoker(run));
        }
        public static String GetIDFromText(String text)
        {
            String id = "";
            string pattern = @"[0-9]{4,17}";
            RegexOptions options = RegexOptions.Multiline;
            try
            {
                id = Regex.Match(text, pattern, options).Value;
                if (String.IsNullOrEmpty(id))
                {

                }
            }
            catch(Exception ex)
            {

            }
            
            return id;
        }

        
    }
}
