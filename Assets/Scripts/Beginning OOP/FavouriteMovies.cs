using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct MyFavouriteMovies
{
    public string GenreType;
    public int StarRating;
    public string[] MovieNames;           
}

public class FavouriteMovies : MonoBehaviour {

    public string genreType;
    public int starRating;
    public string[] movies; 

	// Use this for initialization
	void Start () {
		
	}

    void OnDisable()
    {
        MyFavouriteMovies myFavouriteMovies = new MyFavouriteMovies();
        myFavouriteMovies.GenreType = genreType;
        myFavouriteMovies.StarRating = starRating;
        myFavouriteMovies.MovieNames = movies;

        Debug.Log("genre type: " + myFavouriteMovies.GenreType);
        Debug.Log("star rating: " + myFavouriteMovies.StarRating);
        Debug.Log("movie names: ");
        foreach (string movieName in myFavouriteMovies.MovieNames)
        {
            Debug.Log(movieName);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
