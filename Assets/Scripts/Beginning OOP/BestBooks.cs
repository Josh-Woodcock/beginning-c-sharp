using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct BestBook
{
    public string Name;
    public string Author;
    public float AvgRating;
    public int Score;
}


public class BestBooks : MonoBehaviour {

    BestBook[] books;


	// Use this for initialization
	void Start () {

        books = new BestBook[3];

        BestBook hungerGames = new BestBook();
        hungerGames.Author = "Suzanne Collins";
        hungerGames.Name = "The Hunger Ganes";
        hungerGames.AvgRating = 4.35f;
        hungerGames.Score = 2664643;

        BestBook harryPotter = new BestBook();
        hungerGames.Author = "JK Rowling";
        hungerGames.Name = "Harry Potter and the Order of the Phoenix";
        hungerGames.AvgRating = 4.45f;
        hungerGames.Score = 2173146;

        BestBook mockingbird = new BestBook();
        hungerGames.Author = "Harper Lee";
        hungerGames.Name = "To Kill A Mockingbird";
        hungerGames.AvgRating = 4.25f;
        hungerGames.Score = 1797878;

        books[0] = hungerGames;
        books[1] = harryPotter;
        books[2] = mockingbird;

	}
	
    void OnDisable()
    {
        foreach (BestBook book in books)
        {
            Debug.Log(book.Name);
            Debug.Log(book.Author);
            Debug.Log(book.AvgRating);
            Debug.Log(book.Score);
            Debug.Log("------");
        }
    }


	// Update is called once per frame
	void Update () {
		
	}
}
