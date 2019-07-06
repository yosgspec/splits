import std.stdio;
import std.string;
import std.regex;
import std.datetime;
import std.conv;

void main(){
	auto words="asdff\nastgrw3h\r\nwtegole\rkserlhge3t\nearsgh\nergh\rsagr\r\nerghe\r";

	writeln("D:string.splitLines");
	SysTime sw;
	string[] wordList;

	sw=Clock.currTime();
	for(auto i=0;i<1000000;i++){
		wordList=words.splitLines();
	}
	writeln((Clock.currTime()-sw).total!"msecs");
	writeln(wordList.join(","));

	writeln("D:string.replace & split");
	sw=Clock.currTime();
	for(auto i=0;i<1000000;i++){
		wordList=words.replace("\r\n","\n").replace("\r","\n").split("\n");
	}
	writeln((Clock.currTime()-sw).total!"msecs");
	writeln(wordList.join(","));


	writeln("D:regex.split");
	sw=Clock.currTime();
	for(auto i=0;i<1000000;i++){
		wordList=words.split(regex(r"\r\n|\n|\r"));
	}
	writeln((Clock.currTime()-sw).total!"msecs");
	writeln(wordList.join(","));
}
