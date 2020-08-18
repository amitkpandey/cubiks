using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour {
	public GameObject loadingScreen;
	public RectTransform icon;
	public float rotationSpeed = 10f;

	void Start() {
		loadingScreen.SetActive(false);
	}

	void Update() {
		icon.Rotate(new Vector3(0f, 0f, 10f) * Time.deltaTime * rotationSpeed);
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

	public void Settings() {
		MainUIHandler.menu = 2;
		loadingScreen.SetActive(true);
		SceneManager.LoadScene(1);
	}

	public void Quit() {
		Application.Quit();
	}
}