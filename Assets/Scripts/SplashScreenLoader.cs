using UnityEngine;
using System.Collections;

public class SplashScreenLoader : MonoBehaviour {
    public float delaytime;

    IEnumerator Start()
    {
       yield return new WaitForSeconds(delaytime);

       Application.LoadLevel(1);

    }
}
