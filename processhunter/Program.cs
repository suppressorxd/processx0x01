using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        string[] programs = {
            "notepad.exe",          // Not Defteri
            "mspaint.exe",          // Paint
            "calc.exe",             // Hesap Makinesi
            "cmd.exe",              // Komut İstemi
            "explorer.exe",         // Dosya Gezgini
            "taskmgr.exe",          // Görev Yöneticisi
            "write.exe",            // WordPad
            "powershell.exe",       // PowerShell
            "regedit.exe",          // Kayıt Defteri Düzenleyicisi
            "eventvwr.exe",         // Olay Görüntüleyici
            "services.msc",         // Hizmetler
            "mmc.exe",              // Microsoft Yönetim Konsolu
            "control.exe",          // Denetim Masası
            "msinfo32.exe",         // Sistem Bilgisi
            "dxdiag.exe",           // DirectX Tanı Aracı
            "charmap.exe",          // Karakter Eşlem
            "winver.exe"            // Windows Versiyon Bilgisi
        };

        Random random = new Random();
        int numberOfProcesses = random.Next(10, 25);  

        for (int i = 0; i < numberOfProcesses; i++)
        {
            int index = random.Next(programs.Length);
            string program = programs[index];

            try
            {
                Process.Start(program);
            }
            catch (Exception ex)
            {
                Console.WriteLine($": {program}, Hata: {ex.Message}");
            }

            Thread.Sleep(random.Next(500, 1000));  
        }

    }
}
