using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegisterSims3CC
{

    public partial class mainUI : Form
    {
        public mainUI()
        {
            InitializeComponent();
        }
        
        private void Reg_Click(object sender, EventArgs e)
        {
            //check if the game folder path is set first.
            //string gamefolder = gamepath.Text.Replace(@"\", @"\\");
            string gamefolder = gamepath.Text;
            if (string.IsNullOrEmpty(gamefolder))
            {
                string title = "No Folder Selected";
                string message = "Please select The Sims 2 Ultimate Collection folder.";
                MessageBox.Show(message, title);
            }
            else
            {
                /*
                string message = "The Selected folder is " + gamefolder + ".";
                MessageBox.Show(message);
                */

                RegistryKey SimsKey;

                //check the architecture of the OS
                if (Environment.Is64BitOperatingSystem)
                {
                    //check if registered keys exist
                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\EA GAMES\\The Sims 2")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\EA GAMES\\The Sims 2");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\EA GAMES\\The Sims 2 Fun with Pets Collection")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\EA GAMES\\The Sims 2 Fun with Pets Collection");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP1.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP1.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP2.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP2.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP3.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP3.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP4.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP4.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP5.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP5.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP6.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP6.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP7.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP7.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP8.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP8.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP9.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP9.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SC.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SC.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP1.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP1.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP2.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP2.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP4.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP4.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP5.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP5.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP6.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP6.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP7.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP7.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP8.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP8.exe");
                    }

                    /*
                    //i haven't figured it out this part yet how i could automatically set .Sims2Skin and .Sims2Pack associated by default with PackageInstaller.
                    if ((Registry.ClassesRoot.OpenSubKey(".Sims2Skin")) == null)
                    {
                        SimsKey = Registry.ClassesRoot.CreateSubKey(".Sims2Skin");
                        SimsKey.SetValue("", "The Sims 2 Package Installer");
                        SimsKey.Close();
                    }

                    if ((Registry.ClassesRoot.OpenSubKey(".Sims2Pack")) == null)
                    {
                        SimsKey = Registry.ClassesRoot.CreateSubKey(".Sims2Pack");
                        SimsKey.SetValue("", "The Sims 2 Package Installer");
                        SimsKey.Close();
                    }

                    if ((Registry.ClassesRoot.OpenSubKey("The Sims 2 Package Installer")) == null)
                    {
                        SimsKey = Registry.ClassesRoot.CreateSubKey("The Sims 2 Package Installer");
                        SimsKey = Registry.ClassesRoot.CreateSubKey("The Sims 2 Package Installer\\DefaultIcon");
                        SimsKey.SetValue("", gamefolder + "\\Fun with Pets\\SP9\\CSBin\\PackageInstaller.exe,1");
                        SimsKey.Close();

                        SimsKey = Registry.ClassesRoot.CreateSubKey("The Sims 2 Package Installer\\Shell");
                        SimsKey = Registry.ClassesRoot.CreateSubKey("The Sims 2 Package Installer\\Shell\\Open");
                        SimsKey = Registry.ClassesRoot.CreateSubKey("The Sims 2 Package Installer\\Shell\\Open\\Command");
                        SimsKey.SetValue("", "\"" + gamefolder + "\\Fun with Pets\\SP9\\CSBin\\PackageInstaller.exe\" -file:\"%1\"");
                        SimsKey.Close();
                    }
                    */

                    //register the sims 2 ultimate collection
                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\EA GAMES");
                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\EA GAMES\\The Sims 2");
                    SimsKey.SetValue("DisplayName", "The Sims™ 2 Ultimate Collection");
                    SimsKey.SetValue("CacheSize", "4735180800");
                    SimsKey.SetValue("EPsInstalled", "Sims2EP1.exe,Sims2EP2.exe,Sims2EP3.exe,Sims2SP1.exe,Sims2SP2.exe,Sims2EP4.exe,Sims2EP5.exe,Sims2SP4.exe,Sims2SP5.exe,Sims2EP6.exe,Sims2SP6.exe,,Sims2EP7.exe,Sims2SP7.exe,Sims2SP8.exe,Sims2EP8.exe,Sims2EP9.exe,,,");
                    SimsKey.SetValue("Folder", gamefolder);
                    SimsKey.SetValue("Install Dir", gamefolder + "\\Double Deluxe\\Base");
                    SimsKey.SetValue("Install Dir Parent", gamefolder + "\\Double Deluxe\\");
                    SimsKey.SetValue("Language", "en_US");
                    SimsKey.SetValue("Locale", "en_US");
                    SimsKey.SetValue("Product GUID", "{04450C18-F039-4B81-A621-70C3B0F523D5}");
                    SimsKey.SetValue("Region", "14726");
                    SimsKey.SetValue("Suppression Exe", "Sims2EP9.exe,Sims2EP8.exe,Sims2EP7.exe,Sims2SP7.exe,Sims2SP6.exe,Sims2EP6.exe,Sims2SP5.exe,Sims2SP4.exe,Sims2EP5.exe,Sims2EP4.exe,Sims2SP2.exe,Sims2SP1.exe,Sims2EP3.exe,Sims2EP2.exe,Sims2EP1.exe,Sims2.exe");
                    SimsKey.SetValue("SwapSize", "0");
                    SimsKey.Close();

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\EA GAMES\\The Sims 2\\1.0");
                    SimsKey.SetValue("DisplayName", "The Sims™ 2 Ultimate Collection");
                    SimsKey.SetValue("Language", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("LanguageName", "en_US");
                    SimsKey.Close();

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\EA GAMES\\The Sims 2 Fun with Pets Collection");
                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\EA GAMES\\The Sims 2 Fun with Pets Collection\\1.0");
                    SimsKey.SetValue("DisplayName", "The Sims 2 Fun with Pets Collection");
                    SimsKey.SetValue("Language", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("LanguageName", "English (US)");
                    SimsKey.Close();

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2.exe");
                    SimsKey.SetValue("", gamefolder + "\\Double Deluxe\\Base\\TSBin\\Sims2.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Double Deluxe\\Base");
                    SimsKey.SetValue("Game Registry", "Software\\WOW6432Node\\EA GAMES\\The Sims 2");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP1.exe");
                    SimsKey.SetValue("", gamefolder + "\\University Life\\EP1\\TSBin\\Sims2EP1.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\University Life\\EP1");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 EP1");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP2.exe");
                    SimsKey.SetValue("", gamefolder + "\\Double Deluxe\\EP2\\TSBin\\Sims2EP2.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Double Deluxe\\EP2");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 EP2");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP3.exe");
                    SimsKey.SetValue("", gamefolder + "\\Best of Business\\EP3\\TSBin\\Sims2EP3.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Best of Business\\EP3");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 EP3");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP4.exe");
                    SimsKey.SetValue("", gamefolder + "\\Fun with Pets\\EP4\\TSBin\\Sims2EP4.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Fun with Pets\\EP4");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 EP4");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP5.exe");
                    SimsKey.SetValue("", gamefolder + "\\Seasons\\TSBin\\Sims2EP5.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Seasons");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 Seasons");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP6.exe");
                    SimsKey.SetValue("", gamefolder + "\\Bon Voyage\\TSBin\\Sims2EP6.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Bon Voyage\\");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 Bon Voyage");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP7.exe");
                    SimsKey.SetValue("", gamefolder + "\\Free Time\\TSBin\\Sims2EP7.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Free Time\\");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 FreeTime");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP8.exe");
                    SimsKey.SetValue("", gamefolder + "\\Apartment Life\\TSBin\\Sims2EP8.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Apartment Life\\");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 Apartment Life");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP9.exe");
                    SimsKey.SetValue("", gamefolder + "\\Fun with Pets\\SP9\\TSBin\\Sims2EP9.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Fun with Pets\\SP9");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 Fun with Pets Collection");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SC.exe");
                    SimsKey.SetValue("", gamefolder + "\\Double Deluxe\\EP99\\TSBin\\Sims2SC.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Double Deluxe\\EP99");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 SE");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP1.exe");
                    SimsKey.SetValue("", gamefolder + "\\Fun with Pets\\SP1\\TSBin\\Sims2SP1.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Fun with Pets\\SP1");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 SP1");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP2.exe");
                    SimsKey.SetValue("", gamefolder + "\\Glamour Life Stuff\\TSBin\\Sims2SP2.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Glamour Life Stuff");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 Glamour Life Stuff");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP4.exe");
                    SimsKey.SetValue("", gamefolder + "\\Double Deluxe\\SP4\\TSBin\\Sims2SP4.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Double Deluxe\\SP4");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 SP4");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP5.exe");
                    SimsKey.SetValue("", gamefolder + "\\Best of Business\\SP5\\TSBin\\Sims2SP5.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Best of Business\\SP5");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 SP5");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP6.exe");
                    SimsKey.SetValue("", gamefolder + "\\University Life\\SP6\\TSBin\\Sims2SP6.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\University Life\\SP6");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 SP6");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP7.exe");
                    SimsKey.SetValue("", gamefolder + "\\Best of Business\\SP7\\TSBin\\Sims2EP7.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Best of Business\\SP7");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 Best of Business Collection");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP8.exe");
                    SimsKey.SetValue("", gamefolder + "\\University Life\\SP8\\TSBin\\Sims2SP8.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\University Life\\SP8");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 University Life Collection");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    //let's display the registered pack/s via MessageBox
                    string title = "The Sims 2 Registration";
                    string message = "The Sims 2 Ultimate Collection has been registered.";
                    MessageBox.Show(message, title);
                    
                }
                else //else if architecture is 32 bit
                {
                    //check if registered keys exist
                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\EA GAMES\\The Sims 2")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\EA GAMES\\The Sims 2");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\EA GAMES\\The Sims 2 Fun with Pets Collection")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\EA GAMES\\The Sims 2 Fun with Pets Collection");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP1.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP1.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP2.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP2.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP3.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP3.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP4.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP4.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP5.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP5.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP6.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP6.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP7.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP7.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP8.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP8.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP9.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP9.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SC.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SC.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP1.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP1.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP2.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP2.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP4.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP4.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP5.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP5.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP6.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP6.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP7.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP7.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP8.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP8.exe");
                    }
                    
                    //register the sims 2 ultimate collection
                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\EA GAMES");
                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\EA GAMES\\The Sims 2");
                    SimsKey.SetValue("DisplayName", "The Sims™ 2 Ultimate Collection");
                    SimsKey.SetValue("CacheSize", "4735180800");
                    SimsKey.SetValue("EPsInstalled", "Sims2EP1.exe,Sims2EP2.exe,Sims2EP3.exe,Sims2SP1.exe,Sims2SP2.exe,Sims2EP4.exe,Sims2EP5.exe,Sims2SP4.exe,Sims2SP5.exe,Sims2EP6.exe,Sims2SP6.exe,,Sims2EP7.exe,Sims2SP7.exe,Sims2SP8.exe,Sims2EP8.exe,Sims2EP9.exe,,,");
                    SimsKey.SetValue("Folder", gamefolder);
                    SimsKey.SetValue("Install Dir", gamefolder + "\\Double Deluxe\\Base");
                    SimsKey.SetValue("Install Dir Parent", gamefolder + "\\Double Deluxe\\");
                    SimsKey.SetValue("Language", "en_US");
                    SimsKey.SetValue("Locale", "en_US");
                    SimsKey.SetValue("Product GUID", "{04450C18-F039-4B81-A621-70C3B0F523D5}");
                    SimsKey.SetValue("Region", "14726");
                    SimsKey.SetValue("Suppression Exe", "Sims2EP9.exe,Sims2EP8.exe,Sims2EP7.exe,Sims2SP7.exe,Sims2SP6.exe,Sims2EP6.exe,Sims2SP5.exe,Sims2SP4.exe,Sims2EP5.exe,Sims2EP4.exe,Sims2SP2.exe,Sims2SP1.exe,Sims2EP3.exe,Sims2EP2.exe,Sims2EP1.exe,Sims2.exe");
                    SimsKey.SetValue("SwapSize", "0");
                    SimsKey.Close();

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\EA GAMES\\The Sims 2\\1.0");
                    SimsKey.SetValue("DisplayName", "The Sims™ 2 Ultimate Collection");
                    SimsKey.SetValue("Language", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("LanguageName", "en_US");
                    SimsKey.Close();

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\EA GAMES\\The Sims 2 Fun with Pets Collection");
                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\EA GAMES\\The Sims 2 Fun with Pets Collection\\1.0");
                    SimsKey.SetValue("DisplayName", "The Sims 2 Fun with Pets Collection");
                    SimsKey.SetValue("Language", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("LanguageName", "English (US)");
                    SimsKey.Close();

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2.exe");
                    SimsKey.SetValue("", gamefolder + "\\Double Deluxe\\Base\\TSBin\\Sims2.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Double Deluxe\\Base");
                    SimsKey.SetValue("Game Registry", "SOFTWARE\\EA GAMES\\The Sims 2");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP1.exe");
                    SimsKey.SetValue("", gamefolder + "\\University Life\\EP1\\TSBin\\Sims2EP1.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\University Life\\EP1");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 EP1");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP2.exe");
                    SimsKey.SetValue("", gamefolder + "\\Double Deluxe\\EP2\\TSBin\\Sims2EP2.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Double Deluxe\\EP2");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 EP2");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP3.exe");
                    SimsKey.SetValue("", gamefolder + "\\Best of Business\\EP3\\TSBin\\Sims2EP3.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Best of Business\\EP3");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 EP3");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP4.exe");
                    SimsKey.SetValue("", gamefolder + "\\Fun with Pets\\EP4\\TSBin\\Sims2EP4.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Fun with Pets\\EP4");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 EP4");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP5.exe");
                    SimsKey.SetValue("", gamefolder + "\\Seasons\\TSBin\\Sims2EP5.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Seasons");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 Seasons");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP6.exe");
                    SimsKey.SetValue("", gamefolder + "\\Bon Voyage\\TSBin\\Sims2EP6.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Bon Voyage\\");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 Bon Voyage");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP7.exe");
                    SimsKey.SetValue("", gamefolder + "\\Free Time\\TSBin\\Sims2EP7.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Free Time\\");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 FreeTime");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP8.exe");
                    SimsKey.SetValue("", gamefolder + "\\Apartment Life\\TSBin\\Sims2EP8.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Apartment Life\\");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 Apartment Life");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP9.exe");
                    SimsKey.SetValue("", gamefolder + "\\Fun with Pets\\SP9\\TSBin\\Sims2EP9.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Fun with Pets\\SP9");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 Fun with Pets Collection");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SC.exe");
                    SimsKey.SetValue("", gamefolder + "\\Double Deluxe\\EP99\\TSBin\\Sims2SC.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Double Deluxe\\EP99");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 SE");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP1.exe");
                    SimsKey.SetValue("", gamefolder + "\\Fun with Pets\\SP1\\TSBin\\Sims2SP1.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Fun with Pets\\SP1");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 SP1");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP2.exe");
                    SimsKey.SetValue("", gamefolder + "\\Glamour Life Stuff\\TSBin\\Sims2SP2.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Glamour Life Stuff");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 Glamour Life Stuff");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP4.exe");
                    SimsKey.SetValue("", gamefolder + "\\Double Deluxe\\SP4\\TSBin\\Sims2SP4.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Double Deluxe\\SP4");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 SP4");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP5.exe");
                    SimsKey.SetValue("", gamefolder + "\\Best of Business\\SP5\\TSBin\\Sims2SP5.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Best of Business\\SP5");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 SP5");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP6.exe");
                    SimsKey.SetValue("", gamefolder + "\\University Life\\SP6\\TSBin\\Sims2SP6.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\University Life\\SP6");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 SP6");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP7.exe");
                    SimsKey.SetValue("", gamefolder + "\\Best of Business\\SP7\\TSBin\\Sims2EP7.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\Best of Business\\SP7");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 Best of Business Collection");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    SimsKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP8.exe");
                    SimsKey.SetValue("", gamefolder + "\\University Life\\SP8\\TSBin\\Sims2SP8.exe");
                    SimsKey.SetValue("Path", gamefolder + "\\University Life\\SP8");
                    SimsKey.SetValue("Game Registry", "Software\\EA GAMES\\The Sims 2 University Life Collection");
                    SimsKey.SetValue("Installed", 00000001, RegistryValueKind.DWord);
                    SimsKey.SetValue("Restart", 00000000, RegistryValueKind.DWord);

                    //let's display the registered pack/s via MessageBox
                    string title = "The Sims 2 Registration";
                    string message = "The Sims 2 Ultimate Collection has been registered.";
                    MessageBox.Show(message, title);
                }
                
            }
        }
        
        private void gamepath_TextChanged(object sender, EventArgs e)
        {

        }

        private void selfolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog selectpath = new FolderBrowserDialog();
            selectpath.Description = "Select the game folder of the Sims 2 Ultimate Collection:";

            if (selectpath.ShowDialog() == DialogResult.OK)
            {
                gamepath.Text = selectpath.SelectedPath;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Unreg_Click(object sender, EventArgs e)
        {
            DialogResult confirmUnregister = MessageBox.Show("This will remove the registration of The Sims 2 Ultimate Collection in this computer. Are you sure you want to proceed?", "Remove The Sims 2 UC", MessageBoxButtons.YesNo);
            if (confirmUnregister == DialogResult.Yes)
            {
                //check the architecture of the OS
                if (Environment.Is64BitOperatingSystem)
                {
                    /*
                    //this i haven't figured out yet. please refer to the code above regarding to PackageInstaller.
                    if ((Registry.ClassesRoot.OpenSubKey(".Sims2Skin")) != null)
                    {
                        Registry.ClassesRoot.DeleteSubKeyTree(".Sims2Skin");
                    }

                    if ((Registry.ClassesRoot.OpenSubKey(".Sims2Pack")) != null)
                    {
                        Registry.ClassesRoot.DeleteSubKeyTree(".Sims2Pack");
                    }

                    if ((Registry.ClassesRoot.OpenSubKey("The Sims 2 Package Installer")) != null)
                    {
                        Registry.ClassesRoot.DeleteSubKeyTree("The Sims 2 Package Installer");
                    }
                    */

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\EA GAMES\\The Sims 2")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\EA GAMES\\The Sims 2");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\EA GAMES\\The Sims 2 Fun with Pets Collection")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\EA GAMES\\The Sims 2 Fun with Pets Collection");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP1.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP1.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP2.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP2.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP3.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP3.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP4.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP4.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP5.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP5.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP6.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP6.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP7.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP7.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP8.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP8.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP9.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP9.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SC.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SC.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP1.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP1.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP2.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP2.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP4.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP4.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP5.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP5.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP6.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP6.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP7.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP7.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP8.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\WOW6432Node\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP8.exe");
                    }

                    string title = "Remove The Sims 2 UC";
                    string message = "The Sims 2 Ultimate Collection has been removed.";
                    MessageBox.Show(message, title);
                }
                else //else if architecture is 32bit
                {
                   
                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\EA GAMES\\The Sims 2")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\EA GAMES\\The Sims 2");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\EA GAMES\\The Sims 2 Fun with Pets Collection")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\EA GAMES\\The Sims 2 Fun with Pets Collection");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP1.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP1.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP2.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP2.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP3.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP3.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP4.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP4.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP5.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP5.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP6.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP6.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP7.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP7.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP8.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP8.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP9.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2EP9.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SC.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SC.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP1.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP1.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP2.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP2.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP4.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP4.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP5.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP5.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP6.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP6.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP7.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP7.exe");
                    }

                    if ((Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP8.exe")) != null)
                    {
                        Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\Sims2SP8.exe");
                    }

                    string title = "Remove The Sims 2 UC";
                    string message = "The Sims 2 Ultimate Collection has been removed.";
                    MessageBox.Show(message, title);
                }
            }
        }
        
        private void mainUI_Load(object sender, EventArgs e)
        {

        }

        //this enables draging the window somewhere in the screen
        private void mainUI_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void mainUI_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

    }
}
