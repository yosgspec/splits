const words="asdff\nastgrw3h\r\nwtegole\rkserlhge3t\nearsgh\nergh\rsagr\r\nerghe\r";
var wordList;

console.log("JavaScript:string.split(Regex)");
console.time("sw");
for(let i=0;i<1000000;i=0|i+1){
	wordList=words.split(/\r\n|\n|\r/);
}
console.timeEnd("sw");
console.log(wordList.join(","));

console.log("JavaScript:string.replace & split(string)");
console.time("sw");
for(let i=0;i<1000000;i=0|i+1){
	wordList=words.replace(/\r\n/g,"\n").replace(/\r/g,"\n").split("\n");
}
console.timeEnd("sw");
console.log(wordList.join(","));

console.log("JavaScript:string.replace & split(string)");
console.time("sw");
for(let i=0;i<1000000;i=0|i+1){
	wordList=words.split("\r\n").join("\n").split("\r").join("\n").split("\n");
}
console.timeEnd("sw");
console.log(wordList.join(","));
