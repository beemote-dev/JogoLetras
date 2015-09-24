using UnityEngine;
using System.Collections;

public class MataPrefab : MonoBehaviour {
    //public float tempoTouch;
    public string letra;
    //tempo dado para vida das letras que caem
    private float timeVida;
    //varialvel de tempo maximo de vida
    public float tempoMaximoVida;

	// Use this for initialization
	void Start () {
        timeVida = 0;
	}
	
	// Update is called once per frame
	void Update () {
        timeVida += Time.deltaTime;        
        //if (string.IsNullOrEmpty(letra))
        //{
        //    tempoMaximoVida = tempoTouch;
        //}
        if (timeVida >= tempoMaximoVida)
        {
            Destroy(gameObject);
            timeVida = 0;
        }
	}
}
