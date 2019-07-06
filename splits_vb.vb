Option Strict On
Option Infer On
Imports System.Text.RegularExpressions
Imports System.Diagnostics

Module Program
	Sub Main()
		Dim words=$"asdff{vbLf}astgrw3h{vbCrLf}wtegole{vbCr}kserlhge3t{vbLf}earsgh{vbLf}ergh{vbCr}sagr{vbCrLf}erghe{vbCr}"
		Dim wordList As String()={}
		Dim sw As New Stopwatch()

		Console.WriteLine("VisualBasic:String.Replace & Split(VB)")
		sw.Start()
		For i=1I To 1000000
			wordList=Split(words.Replace(vbCrLf,vbLf).Replace(vbCr,vbLf),vbLf)
		Next
		sw.Stop()
		Console.WriteLine(sw.ElapsedMilliseconds)
		Console.WriteLine(String.Join(",",wordList))

		Console.WriteLine("VisualBasic:String.Replace & Split")
		sw.Reset()
		sw.Start()
		For i=1I To 1000000
			wordList=words.Replace(vbCrLf,vbLf).Split({vbLf(0),vbCr(0)})
		Next
		sw.Stop()
		Console.WriteLine(sw.ElapsedMilliseconds)
		Console.WriteLine(String.Join(",",wordList))

		Console.WriteLine("VisualBasic:String.Split(String())")
		sw.Reset()
		sw.Start()
		For i=1I To 1000000
			wordList=words.Split({vbCrLf,vbLf,vbCr},StringSplitOptions.None)
		Next
		sw.Stop()
		Console.WriteLine(sw.ElapsedMilliseconds)
		Console.WriteLine(String.Join(",",wordList))

		Console.WriteLine("VisualBasic:Regex.Split")
		sw.Reset()
		sw.Start()
		For i=1I To 1000000
			wordList=Regex.Split(words,$"{vbCrLf}|{vbLf}|{vbCr}")
		Next
		sw.Stop()
		Console.WriteLine(sw.ElapsedMilliseconds)
		Console.WriteLine(String.Join(",",wordList))
	End Sub
End Module
