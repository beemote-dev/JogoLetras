using UnityEngine;
using System.Collections;

public class CoultDownTimer : MonoBehaviour {
    public float timeRemaining;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeRemaining -= Time.deltaTime;
    }


    void OnGUI()
    {
        if (timeRemaining > 0)
        {
            GUI.Label(new Rect(130, 40, 200, 100), "Tempo: " + (int)timeRemaining);
            
        }
        else
        {
            GUI.Label(new Rect(130, 20, 200, 100), "Acabou o tempo!");
            Application.LoadLevel(3);
        }
    }
}
