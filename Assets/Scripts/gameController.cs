using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class gameController : MonoBehaviour {

	public static string currentSelectedCar = "myLamboConvert";

	private bool onOff = false;
	private string theScene;

	// Use this for initialization
	void Start () {
		theScene = SceneManager.GetActiveScene ().name;
	}

	public void showNewCar(string nextCar){
		//currentSelectedCar.SetActive(false);
		currentSelectedCar = nextCar;
		}

 	public void quit(){
		Application.Quit ();
	}

	public void changeLevel(string scene){
		SceneManager.LoadScene (scene);
	}

	void Update(){
		//print (currentSelectedCar);
	}

	public void toggleFlash(){
		if (onOff) {
			CameraDevice.Instance.SetFlashTorchMode (false);
			onOff = false;
		} else {
			CameraDevice.Instance.SetFlashTorchMode (true);
			onOff = true;
		}
	}

	



}
