using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour
{
	public float pass;
	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		StartCoroutine ("Espera");
	}

	IEnumerator Espera(){
		yield return new WaitForSeconds (pass);
		float fadeTime = GameObject.Find ("_Change").GetComponent<Fading>().BeginFade(1);
		yield return new WaitForSeconds (fadeTime);
		Cursor.visible = true;
        //Application.LoadLevel(1);
	}
}
