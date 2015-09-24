using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

	public void ChangeToScena(int scena){
		StartCoroutine ("ChangeLevel",scena);
	}

	public void ExitGame(){
		StartCoroutine ("ChangeLevel",0);
		Application.Quit();
	}

	IEnumerator ChangeLevel(int index){
		Debug.Log("oi");
		float fadeTime = GameObject.Find ("_Change").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
		Application.LoadLevel(index);
	}

}



