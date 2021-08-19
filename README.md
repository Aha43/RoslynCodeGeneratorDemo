# Roslyn Code Generator Demo

This repo contains example code for getting started with Roslyn compiler code generator.

Source code is not mine but found in two excelent blog posts: 

[Pawel Gerr's post with the actual source code is from](https://www.thinktecture.com/en/net/roslyn-source-generators-introduction/#creation-of-a-new-source-generator)
and [Steve Collins life saving blog on how to debug code generators](http://stevetalkscode.co.uk/debug-source-generators-with-vs2019-1610).

Pawel example is one of the best getting started with source generators source code examples my googling found: It is small enough to not overwhelm or confuse but show real application. Highly recommended, finally got me started with generators. However first time I run it it did not work. Kind of luck since this motivated me to learn how to debug code generators! Turned out Steve had that sorted out :D. Steve's post explained what I had to add project files in order to get breakpoint debugging working and how to do it in vs19.

About the 'bug' I found I have mixed feelings, bad because I do not see why Pawel original code should not work (the commented out lines in file 
