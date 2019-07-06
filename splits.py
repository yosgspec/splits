from time import time
import re

words="asdff\nastgrw3h\r\nwtegole\rkserlhge3t\nearsgh\nergh\rsagr\r\nerghe\r"

print("Python3:string.splitlines")
sw=time();
for i in range(1000000):
	wordList=words.splitlines()
print((time()-sw)*1000)
print(",".join(wordList))

print("Python3:string.replace & split")
sw=time();
for i in range(1000000):
	wordList=words.replace("\r\n","\n").replace("\r","\n").split("\n")
print((time()-sw)*1000)
print(",".join(wordList))

print("Python3:re.split")
sw=time();
for i in range(1000000):
	wordList=re.split("\r\n|\n|\r",words)
print((time()-sw)*1000)
print(",".join(wordList))
