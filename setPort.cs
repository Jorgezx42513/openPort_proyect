using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OpenPort
{
    internal class setPort : PortsState
    {
        public void MySql(Button btMySQL)
        {
            if (MySQL == false)
            {
                exeCommand(@"mysql\bin\mysqld --defaults-file=mysql\bin\my.ini --standalone");
                MySQL = true;
                btMySQL.Content = "Stop";
            }
            else
            {
                exeCommand($"start \"\" /MIN call \"{getPath() + @"/"}killprocess.bat\" \"mysqld.exe\" ");
                MySQL= false;
                btMySQL.Content = "Start";
            }
                
        }
        public void Apache(Button btApache) 
        {
            if (apache == false)
            {
                exeCommand(@"apache\bin\httpd.exe");
                apache = true;
                btApache.Content = "Stop";
            }
            else
            {
                exeCommand($"start \"\" /MIN call \"{getPath() + @" / "}killprocess.bat\" \"httpd.exe\"");
                apache= false;
                btApache.Content = "Start";
            }
        }
        public void Php()
        {
            if (php == true)
                exeCommand("");
            else
                exeCommand("");
        }
    }
}
