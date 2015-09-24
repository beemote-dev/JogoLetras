using UnityEngine;
using System.Collections;

public class testeTouch : MonoBehaviour {
	public float speed = 0.1F;
	//public float velocidade;
	//public Transform cubo;
	//public float largura = -7.5f;
	//public float altura = -4.5f;
	//private Touch touch;
	//private float x;
	//private float y;
    // Use this for initialization
	//public Vector2 startPos;
	//public Vector2 direction;
	//public bool directionChosen= false;



	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);

				//Pegar ();
				//touch = Input.GetTouch(0);
				//float x = largura + 18 *touch.position.x/Screen.width;
				//float y = altura + 10 *touch.position.y/Screen.height;
				//transform.position = new Vector3 (x, y, 0);
		}
	}
}
	//void Pegar(){

		//if (Input.touchCount > 0) {
			//Touch touch = Input.GetTouch (0);

			//switch (touch.phase) {
			
				//case TouchPhase.Began:
					//startPos = touch.position;
					///directionChosen = false;
				//Debug.Log("Iniciou");
				//break;			

				//case TouchPhase.Moved:
				//direction = touch.position - startPos;
				//cubo.transform.Translate (Vector2.right * velocidade * Time.deltaTime);
				//Debug.Log("Moveu");
				//break;				

				//case TouchPhase.Ended:
				//directionChosen = true;
				//Debug.Log("Fim");
				//break;
			            
		//   }		
	   //   }
	   // if (directionChosen) {
		//}
 // }
//}




						//float x = largura + 18 *touch.position.x/Screen.width;
						//float y = altura + 10 *touch.position.y/Screen.height;
						//transform.position = new Vector3 (x, y, 0);
						//touch.phaseTouchPhase.Began;
						//startPos = touch.position;
						//direction = touch.position - startPos;
						//directionChosen = true;

						//TouchPhase.Moved;

						//TouchPhase.Ended;

				//} 
			


		
	//}
//}



				
				//if(Input.GetTouch = 0)
				//{//
				
				//if(this.name =="cubo")
				//	{
						//animator.SetBool("Run",true);
						//da uma velocidade ao deslocamento
				//x = largura + 18 *touch.position.x / Screen.width;
						//transform.Translate (Vector2.right * velocidade * Time.deltaTime);
						//define qual o lado se deve movimentar
						//transform.eulerAngles = new Vector2(0,0);
						//Debug.Log("esq");
					///}
					
				//if(this.name =="cubo")
					//{

				//y = altura + 10 *touch.position.y / Screen.height;
						//animator.SetBool("Run",true);
						//da uma velocidade ao deslocamento
						//transform.Translate (Vector2.right * velocidade * Time.deltaTime);
						//define qual o lado se deve movimentar
						//transform.eulerAngles = new Vector2(0,180);
						//Debug.Log("Direita");
						
					//}
	


				//}
		//}
	//}

//}
