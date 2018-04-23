using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    // configuration parameters
    [SerializeField] int lowestNumber = 1;
    [SerializeField] int highestNumber = 10000;

    // references
    NumberWizard numberWizard;

    private void Start()
    {
        numberWizard = new NumberWizard(lowestNumber, highestNumber);
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
		Application.Quit();
	}

    public int GetGuess()
    {
        return numberWizard.GetGuess();
    }
}
