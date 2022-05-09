# MarsRovers
Version 1.0.0

## Using The Program
Simple C# console program that controls a squad of rovers deployed in a plateau in Mars, it takes user input from a text file. To add input create a directory named MarsRoverInstructions in C drive and add a txt file named instructions. The first line of input must be the coordinates of the plateau, thereafter every pair of lines represents a rover's initial position and instruction respectively.\
    Sample Input:\
    5 5\
    1 2 N\
    LMLMLMLMM\
    3 3 E\
    MMRMMRMRRM

#### Assumptions: 
* Input provided is valid (i.e its in the right format as presented above).
* The last letters in rover's initial position allowed are (N, E, W, S) and for instructions (L, R, M) only.
* There are no empty lines in the text file.
 
 ## Installation
 No installation needed simply clone the project, use publish feature on Visual Studio or any IDE of your choice and simple run the MarsRovers.exe file.
 


