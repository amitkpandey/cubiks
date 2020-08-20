using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour {
	public GameObject loadingScreen, timer;
	public RectTransform icon, line;
	public GameObject background;
	TimerHandler th;

	void Start() {
		th = background.GetComponent<TimerHandler>();
		loadingScreen.SetActive(false);
		timer.SetActive(false);
	}

	void Update() {
		icon.Rotate(new Vector3(0, 0, 10) * Time.deltaTime * 10);
		line.Rotate(new Vector3(0, 10, 0) * Time.deltaTime * 10);

		AndroidBackButton();
	}

	void AndroidBackButton() {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			if(timer.activeSelf) {
				if(th.timerRunning) {
					th.StopTimer();
				}
				else {
					th.HideTimer();
				}
			}
			else {
				Application.Quit();
			}
		}
	}

	public void Simulator() {
		MainUIHandler.menu = 0;
		loadingScreen.SetActive(true);
		SceneManager.LoadScene(1);
	}

	public void SolveYourCube() {
		MainUIHandler.menu = 1;
		loadingScreen.SetActive(true);
		SceneManager.LoadScene(1);
	}

	public void Timer() {
		timer.SetActive(true);
	}

	public void Settings() {
		MainUIHandler.menu = 2;
		loadingScreen.SetActive(true);
		SceneManager.LoadScene(1);
	}

	public void Quit() {
		Application.Quit();
	}

	public void GitHubLink() {
		Application.OpenURL("https://github.com/manojbhatt101010/cubiks");
	}
}