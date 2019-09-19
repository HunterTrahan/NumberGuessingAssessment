Hunter Trahan
----
Mock Assessment
Number Guessing Assessment

## I. Requirements

1. Description of Problem

    - Name: Number Guessing Assessment

    - Problem Statement: This game consists of the computer trying to guess a number that you have selected from a given range.

    - Problem Specifications: 
        - The game is implemented as a console application.
        - Input is received via the console and validated before use.
        - The program asks the player to think of a (whole) number between a specified range.
        - The player presses ‘enter’ when they have thought of a number.
        - The program uses a random number generator to guess the first number.
        - The player indicates whether the guessed number is less than, greater than, or equal to the number they are thinking of.
        - If incorrect, the program continues to guess the player’s number, receiving feedback from the player after each guess.
        - The program should be able to identify if the player has cheated and changed the number they were thinking of.
        - At the end of the game, the program outputs how many guesses it took to identify the player’s number.

2. Input Information

    - Enter - used to start the game and confirm your choice.
    - G - used to tell the game your number is greater than the number it generated.
    - L - used to tell the game your number is lower than the number it generated.
    - E - used to tell the game your number is equel tp the number it generated.

3. Output Information

    - Game start - Once the game starts the player is prompted to think of a number and press enter to continue.
    - Choice Loop - After continuing the player is promted to state whether their number is greater, lower, or equel to the number generated.
    - Choice - Depending on what the player chooses diffrent information is displayed
        - If the user chooses to say the number is greater than the number generated the game will display a new higher number then reprompt the Choice Loop.
        - If the user chooses to say the number is lower than the number generated the game will display a new lower number then reprompt the Choice Loop.
        - If the user chooses to say the number is equel to the number generated the game will display the number is solved and the number of guesses it took to solve.
    - Cheat- If the player attempts to change their original number of choice they will be called out.

## II. Design

1. System Architecture

    -------------------
    Start
    
        ______________________________________________________________________________
        |Think of a number between 1 and 100                                         |
        |Press 'Enter' to continue                                                   |
        |                                                                            |
        |                                                                            |
        |                                                                            |
        |                                                                            |
        |____________________________________________________________________________|

    At the start of the game the player is prompted to think of a number between 1 and 100 and press 'Enter' to continue after doing so.

    -------------------
    Choice

        ______________________________________________________________________________
        |Think of a number between 1 and 100                                         |
        |Press 'Enter' to continue                                                   |
        |                                                                            |
        |26                                                                          |
        |                                                                            |
        |Is your number greater than(G), less than(L), or equel(E) to this number?   |
        |____________________________________________________________________________|

    After continuing the game will display a number in a attempt to guess your choice of number.
    The player will need to choose whether their number is greater tha, less than, or equel to the number generated.

    -------------------
    Loop

        ______________________________________________________________________________
        |Think of a number between 1 and 100                                         |
        |Press 'Enter' to continue                                                   |
        |                                                                            |
        |26                                                                          |
        |                                                                            |
        |Is your number greater than(G), less than(L), or equel(E) to this number?   |
        |G                                                                           |
        |78                                                                          |
        |                                                                            |
        |Is your number greater than(G), less than(L), or equel(E) to this number?   |
        |____________________________________________________________________________|

    Once the player makes their decision a number is generated corresponding to their choice.
    The player is also prompted to make the choice again, this will continue untill the player says their number is equel

    -------------------
    End

        ______________________________________________________________________________
        |Think of a number between 1 and 100                                         |
        |Press 'Enter' to continue                                                   |
        |                                                                            |
        |26                                                                          |
        |                                                                            |
        |Is your number greater than(G), less than(L), or equel(E) to this number?   |
        |G                                                                           |
        |78                                                                          |
        |                                                                            |
        |Is your number greater than(G), less than(L), or equel(E) to this number?   |
        |E                                                                           |
        |Number Solved                                                               |
        |Number of guesses:1                                                         |
        |____________________________________________________________________________|

    Once the player decides the number generated is equel to their number the game states the number is solved.
    The number of guesses it took to solve the players number is also displayed.
    Once the user presses 'Enter' the game will close.