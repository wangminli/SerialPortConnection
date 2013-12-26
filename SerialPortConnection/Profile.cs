using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INIFILE
{
    class Profile
    {
        public static void LoadProfile()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory;
            _file = new IniFile(strPath + "Cfg.ini");
            G_BAUDRATE = _file.ReadString("CONFIG", "BaudRate", "4800");    //读数据，下同
            G_DATABITS = _file.ReadString("CONFIG", "DataBits", "8");
            G_STOP = _file.ReadString("CONFIG", "StopBits", "1");
            G_PARITY = _file.ReadString("CONFIG", "Parity", "NONE");
         
        }

        public static void SaveProfile()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory;
            _file = new IniFile(strPath + "Cfg.ini");
            _file.WriteString("CONFIG", "BaudRate", G_BAUDRATE);            //写数据，下同
            _file.WriteString("CONFIG", "DataBits", G_DATABITS);
            _file.WriteString("CONFIG", "StopBits", G_STOP);
            _file.WriteString("CONFIG", "G_PARITY", G_PARITY);
        }

        private static IniFile _file;//内置了一个对象

        public static string G_BAUDRATE = "1200";//给ini文件赋新值，并且影响界面下拉框的显示
        public static string G_DATABITS = "8";
        public static string G_STOP = "1";
        public static string G_PARITY = "NONE";
        
    }
}
