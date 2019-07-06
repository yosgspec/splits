using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

class Program{
	static void Main(){
		const string words="asdff\nastgrw3h\r\nwtegole\rkserlhge3t\nearsgh\nergh\rsagr\r\nerghe\r";
		var wordList=new string[]{};
		var sw=new Stopwatch();

		Console.WriteLine("C#:String.Replace & Split");
		sw.Start();
		for(var i=0;i<1000000;i++){
			wordList=words.Replace("\r\n","\n").Split(new[]{'\n','\r'});
		}
		sw.Stop();
		Console.WriteLine(sw.ElapsedMilliseconds);
		Console.WriteLine(String.Join(",",wordList));

		Console.WriteLine("C#:String.Split(String[])");
		sw.Reset();
		sw.Start();
		for(var i=0;i<1000000;i++){
			wordList=words.Split(new[]{"\r\n","\n","\r"},StringSplitOptions.None);
		}
		sw.Stop();
		Console.WriteLine(sw.ElapsedMilliseconds);
		Console.WriteLine(String.Join(",",wordList));

		Console.WriteLine("C#:Regex.Split");
		sw.Reset();
		sw.Start();
		for(var i=0;i<1000000;i++){
			wordList=Regex.Split(words,"\r\n|\n|\r");
		}
		sw.Stop();
		Console.WriteLine(sw.ElapsedMilliseconds);
		Console.WriteLine(String.Join(",",wordList));
	}
}