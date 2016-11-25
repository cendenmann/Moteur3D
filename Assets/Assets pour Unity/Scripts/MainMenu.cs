﻿/* Endenmann Cyrielle
 * Projet 3D
 * MainMenu class
 */

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GameObject _menu;
	public GameObject _options;
	public GameObject _howto;

	// Use this for initialization
	void Start () {
		_options.SetActive (false);
		_options.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Play game
	public void OnPlayClicked() {
		SceneManager.LoadScene("game");
		Time.timeScale = 1.0f;
	}

	// Options
	public void OnOptionsClicked() {
		_menu.SetActive (false);
		_options.SetActive (true);
	}

	// How to play
	public void OnHowToClicked() {
		_menu.SetActive (false);
		_howto.SetActive (true);
	}

	// Quit game
	public void OnQuitClicked() {
		Application.Quit ();
	}

	// Back
	public void OnBackClicked() {
		_menu.SetActive (true);
		_options.SetActive (false);
		_howto.SetActive (false);
	}
}