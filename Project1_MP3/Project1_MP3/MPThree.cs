////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Project 1 - MP3
// File Name: MPThree.cs
// Description: 
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Kelsey Blevins, blevinskl2@etsu.edu
// Created: Wednesday, September 09, 2022
// Copyright: Kelsey Blevins, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
///

using System;
using System.Security.Cryptography.X509Certificates;
using MP3;

public class MPThree
{
    public string songTitle
    {
        get; set;
    }

    public string artistName
    {
        get; set;
    }

    public string songReleaseDate
    {
        get; set;
    }

    public string pathJPG
    {
        get; set;
    }

    public double songPlayback
    {
        get; set;
    }

    public decimal downloadCost
    {
        get; set;
    }

    public double fileSize
    {
        get; set;
    }

    public Genre Genre2
    {
        get; set;
    }

    public MPThree(string? songTitle)
    {
        string songTitle;
        string artistName;
        string songReleaseDate;
        double songPlayback;
        decimal downloadCost;
        double fileSize;
        string pathJPG;
        Genre Genre2;
    }

    public MPThree(string songTitle, string artistName, string songReleaseDate, double songPlayback, decimal downloadCost, double fileSize, string pathJPG, Genre Genre2)
    {
        this.songTitle = songTitle;
        this.artistName = artistName;
        this.songReleaseDate = songReleaseDate;
        this.songPlayback = songPlayback;
        this.downloadCost = downloadCost;
        this.fileSize = fileSize;
        this.pathJPG = pathJPG;
        this.Genre2 = Genre2;
    }

    public override string ToString()
    {
        string Mp3File = "";
        Mp3File += $"Artist Name:\t\t {artistName} \n";
        Mp3File += $"Song Title:\t\t{songTitle}\n";
        Mp3File += $"Release Date:\t\t{songReleaseDate}\n";
        Mp3File += $"Song Playback:\t\t{songPlayback}\n";
        Mp3File += $"Download Cost:\t\t{downloadCost}\n";
        Mp3File += $"File Size: \t\t{fileSize}\n";
        Mp3File += $"Path JPG: \t\t{pathJPG}";
        Mp3File += $"Genre: \t\t{Genre2}";
        return ToString();
    }
}
