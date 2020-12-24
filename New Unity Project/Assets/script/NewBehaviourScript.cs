using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int level;
    string currentscreen = "MainMenu";

    string password;
    string[] level1passwords = {"Mario", "Crash", "space", "jupiter" };
    string[] level2passwords = {"overwatch", "pubg", "fortnite", "ninja"};
     //Start is called before the first frame update
    void Start()
    {
        mainmenu("Welcome to the game!");
    }

    void mainmenu(string greetings)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greetings);
        Terminal.WriteLine("what would you like to hack?");
        Terminal.WriteLine("press 1 for Huss brain");
        Terminal.WriteLine("press 2 for Aziz brain");
        Terminal.WriteLine("Enter your selection: ");

    } //end main menu

    void OnUserInput(string input)
    {
        print("This is what the user wrote: " + input);

        if (input == "Menu")
        {
            mainmenu("Welcome back, Hacker");
            currentscreen = "MainMenu";
        }
        
        else if (currentscreen == "MainMenu")
        {
            SetLevel(input);
        }
        else if (currentscreen == "password")
        {
            CheckPassword(input);
        }
           
    } // end userinput


    void SetLevel(string selectedLevel)
    {
        if (selectedLevel == "1")
        {
            level = 1;
            StartGame();
        }
        else if (selectedLevel == "2")
        {
            level = 2;
            StartGame();
        }
    
        else
            Terminal.WriteLine("Wrong input, try again!");
    } //end setlevel

   


    void StartGame()
    {
        currentscreen = "password";
        Terminal.WriteLine("You have chosen level " + level);

        switch(level)
        {
            case 1: 
                 password = level1passwords[Random.Range(0,level1passwords.Length)];
               break;
            case 2: password = level2passwords[Random.Range(0,level2passwords.Length)];
                break;

            default:
                break;
        }

        Terminal.WriteLine(password.Anagram());
     

    } // end start game

    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("Congratulations! YOU WON!!!");
        }
        else
            Terminal.WriteLine("NOOP! Try Again, or type menu to go back");
    } // end check password

    private void Update()
    {
        print(currentscreen);
    }

}