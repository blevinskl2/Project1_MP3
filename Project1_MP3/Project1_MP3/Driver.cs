////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Project 1 - MP3
// File Name: Driver.cs
// Description: To display menu options for user and holds in user name and MP3 object
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Kelsey Blevins, blevinskl2@etsu.edu
// Created: Wednesday, September 09, 2022
// Copyright: Kelsey Blevins, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
///


using MP3;
using System.Security.Cryptography.X509Certificates;
using static MPThree;

namespace Mp3;

/// <summary>
/// Implementing user input to create an Mp3 file that is to hold an object and display
/// </summary>
public class Mp3
{
    /// <summary>
    /// Creating a welcome message for user and produces a menu for user to input information, only to be displayed later when requested.
    /// </summary>
    /// <param></param>
    /// <returns>an object that holds both user's name and MP3 object they've created</returns
    public static void Main()
    {
        ///Creating a welcome message and requesting user's name
        Console.WriteLine("Hello! Welcome to MP3 Tracker, where you can add your song's detail specifications!");
        Console.WriteLine("Enter your name: \t \n");
        string userInputName = Console.ReadLine();

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Title = "Menu Application";

        ///Creating the object menu window that presents options for user to choose.
        Menu menu = new Menu("MP3 Menu");
        menu = menu + "Create a new MP3 File" + "Display an MP3 File" + "End the Program" + "QUIT";
        MPThree userInputSong = null;
        
        /// Creating a while/switch loop for user to enter information and to hold the object, displaying object, or exiting with a goodbye message
        /// of the user's name.
        Choices choice = (Choices)menu.GetChoice();
        while (choice != Choices.CLOSE)
        {
            switch (choice)
            {
                case Choices.OPEN:
                    Console.WriteLine("You've chosen to create a new MP3 File. . .");
                    Console.ReadKey();

                    Console.WriteLine("Enter the song title: \n");
                    string songTitle = Console.ReadLine();

                    Console.WriteLine("Enter the artist name: \n");
                    string artistName = Console.ReadLine();

                    Console.WriteLine("Enter the release date: \n");
                    string songReleaseDate = Console.ReadLine();

                    Console.WriteLine("Enter the download cost: \n");
                    double downloadCost = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the file size: \n");
                    decimal fileSize = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Enter the song play back: \n");
                    double songPlayBack = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the Album photo: \n");
                    string pathJPG = Console.ReadLine();

                    Console.WriteLine("Enter the Genre out of the following; Rock, Pop, Jazz, Country, Classical," +
                        "Other \n");
                    string Genre2 = Console.ReadLine();
                    Enum genre = (Genre)Enum.Parse(typeof(Genre), Genre2);
                    userInputSong = new MPThree(songTitle, artistName, songReleaseDate, downloadCost, fileSize, songPlayBack, pathJPG, genre);
                    break;

                case Choices.EDIT:
                    Console.WriteLine("You've chosen to display an MP3 File. . .");
                    Console.ReadKey();

                    Console.WriteLine(userInputSong);

                    break;

                case Choices.CLOSE:
                    Console.WriteLine($"Thank you, {userInputName}, have a good day! :^)");
                    Console.ReadKey();
                    break;

                case Choices.QUIT:
                    break;

                    default:
                    Console.WriteLine("INVALID, PLEASE TRY AGAIN. . . ");
                    break;
            }
            ///Displays menu that hold Choices's enum values and displays them within the menu. This will obtain user's menu choice and holds information.
            ///will continue to loop until user gives correct input.
            choice = (Choices)menu.GetChoice();
        }
    }
}


