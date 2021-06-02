﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

/// <summary>
/// Summary description for clsEvent
/// </summary>
public class clsEvent
{
    public clsEvent()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static void LogEvent(string sLog) //For general Log
    {
        //FileStream fs = new FileStream(@"D:\V-eWalletWeb\Log\ClientMessage_" + DateTime.Now.ToString("ddMMMyyyy") + ".log", //LIVE Directory
        FileStream fs = new FileStream(@"E:\VPB\eWallet-Web\V-eWalletWeb\Log\Message_" + DateTime.Now.ToString("ddMMMyyyy") + ".log", //LIVE Directory
        FileMode.OpenOrCreate, FileAccess.Write);
        StreamWriter FilestreamWriter = new StreamWriter(fs);
        FilestreamWriter.BaseStream.Seek(0, SeekOrigin.End);
        FilestreamWriter.WriteLine(sLog);
        FilestreamWriter.WriteLine();
        FilestreamWriter.Flush();
        FilestreamWriter.Close();
    }
    public static void LogExceptionEvent(string sLog) //For general Log
    {
        //FileStream fs = new FileStream(@"D:\V-eWalletWeb\Log\ClientException_" + DateTime.Now.ToString("ddMMMyyyy") + ".log", //LIVE Directory
        FileStream fs = new FileStream(@"E:\VPB\eWallet-Web\V-eWalletWeb\Log\Message_" + DateTime.Now.ToString("ddMMMyyyy") + ".log", //LIVE Directory
        FileMode.OpenOrCreate, FileAccess.Write);
        StreamWriter FilestreamWriter = new StreamWriter(fs);
        FilestreamWriter.BaseStream.Seek(0, SeekOrigin.End);
        FilestreamWriter.WriteLine(sLog);
        FilestreamWriter.WriteLine();
        FilestreamWriter.Flush();
        FilestreamWriter.Close();
    }
}