using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string playScenen = "Play";
    public SceneFader sceneFader;

	public void Play ()
	{
		sceneFader.FadeTo(playScenen);
	}
}
