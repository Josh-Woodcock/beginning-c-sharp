﻿using UnityEngine;
using System.Collections;

struct BestBook
{
    public string Name;
    public string Author;
    public float AvgRating;
    public int Score;
}


public class BestBooks : MonoBehaviour
{

    BestBook[] books;

    // Use this for initialization
    void Start()
    {
        books = new BestBook[3];

        BestBook hungerGames = new BestBook();
        hungerGames.Author = "Suzanne Collins";
        hungerGames.Name = "The Hunger Games";
        hungerGames.AvgRating = 4.35f;
        hungerGames.Score = 2173146;

        BestBook harryPotter = new BestBook();
        harryPotter.Author = "JK Rowling";
        harryPotter.Name = "Harry Potter and the Order of the Phoenix";
<<<<<<< HEAD
        harryPotter.AvgRating = 4.45f;
        harryPotter.Score = 2173146;

        BestBook mockingbird = new BestBook();
        mockingbird.Author = "Harper Lee";
        mockingbird.Name = "To Kill A Mockingbird";
        mockingbird.AvgRating = 4.25f;
        mockingbird.Score = 1797878;
=======
        harryPotter.AvgRating = 4.46f;
        harryPotter.Score = 1797878;

        BestBook mockingBird = new BestBook();
        mockingBird.Author = "Harper Lee";
        mockingBird.Name = "To Kill a Mockingbird";
        mockingBird.AvgRating = 4.25f;
        mockingBird.Score = 1797878;
>>>>>>> bb1c07776bf1a3c895d0eb76aaa8cd3aaf94b609

        books[0] = hungerGames;
        books[1] = harryPotter;
        books[2] = mockingBird;
    }

    void OnDisable()
    {
        foreach (BestBook book in books)
        {
            Debug.Log(book.Name);
            Debug.Log(book.Author);
            Debug.Log(book.AvgRating);
            Debug.Log(book.Score);
            Debug.Log("---");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
