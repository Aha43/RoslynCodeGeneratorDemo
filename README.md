# Roslyn Code Generator Demo

This repo contains example code for getting started with writing Roslyn compiler platform code generators.

Source code is not mine but compiled from two excellent blog posts: 

[Pawel Gerr's post with the actual source code is from](https://www.thinktecture.com/en/net/roslyn-source-generators-introduction/#creation-of-a-new-source-generator)
and [Steve Collins life saving blog on how to debug code generators](http://stevetalkscode.co.uk/debug-source-generators-with-vs2019-1610).

Pawel example is one of the best getting started with source generator source code examples my googling found: It is small enough to not overwhelm or confuse but also show a real application. Highly recommended, finally got me started with generators. However, the first time I ran it it did not work. Kind of luck since this motivated me to learn how to debug code generators! Turns out Steve had that sorted out :D. Steve's post explained what I had to add in project files in order to get breakpoint debugging working and how to do it in vs19.

About the 'bug' I found I have mixed feelings, bad because I do not see why Pawel original code should not work (the commented out lines in [this file](https://github.com/Aha43/RoslynCodeGeneratorDemo/blob/main/DemoSourceGenerator/DemoSyntaxReceiver.cs) (line 11 replaced with lines 11 and 14 and line 31 replaced with line 32) but as I said it got me to find Steve's debugging guide!

Ok, so while I provide the working sample code rigged for debugging I recommend doing as I did to get going with code generators read Pawel and Steve blogs and do the hacking, best way to learn!
