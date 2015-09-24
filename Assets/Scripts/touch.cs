using UnityEngine;
using System.Collections;

public class touch : MonoBehaviour {
	//public GameObject particle;
	public GameObject projectile;
	public float velocidade=0.5f;
	public Vector2 startPos;
	public Vector2 direction;
	private Touch touche;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            // Get movement of the finger since last frame
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            // Move object across XY plane
            GetComponent<Rigidbody2D>().gameObject.SetActive(false);
            transform.Translate(touchDeltaPosition.x * velocidade, touchDeltaPosition.y * velocidade, 0);

        






        //int i = 0;
        //while (i < Input.touchCount) {
        //    if (Input.GetTouch(i).phase == TouchPhase.Began) {

        //        if(this.tag =="A")
        //        {
        //            direction = touche.position - startPos;
        //            transform.Translate (Vector2.right * velocidade * Time.deltaTime);
        //        }
        //    }
			//++i;

		//int i = 0;
		//while (i < Input.touchCount) {
			//if (Input.GetTouch(i).phase == TouchPhase.Began)
			//	clone = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
			
			//++i;
	}

	
 }
}

