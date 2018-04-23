using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    // references
    NumberWizard numberWizard;

    private void Start()
    {
        numberWizard = new NumberWizard(1, 1000); // todo parameter
    }

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
	}

    public void HigherPressed()
    {
        numberWizard.GuessHigher();
    }

    public void LowerPressed()
    {
        numberWizard.GuessLower();
    }

	public void QuitRequest()
    {
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

    public int GetGuess()
    {
        return numberWizard.GetGuess();
    }
}
