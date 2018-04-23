using UnityEngine;
using UnityEngine.UI;

public class GuessDisplay : MonoBehaviour // to talk to UI
{
    // references
    Game game;
    Text guessText;

	// Use this for initialization
	void Start ()
	{
        game = FindObjectOfType<Game>();
        guessText = GetComponent<Text>(); // assumes is attached
	}

	// Update is called once per frame
	void Update ()
	{
        guessText.text = game.GetGuess().ToString();
	}
}
