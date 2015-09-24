using UnityEngine;
using System.Collections;

public class BehaviorLixeiras : MonoBehaviour {

    private int Pontuacao = 0;
    public Transform objeto;
    public GameObject lixo;
    private Animator animator;




    //void OnTriggerStay2D(Collider2D col)
    //{
    //    if (col.gameObject.tag == "Reciclados")
    //    {
    //        animator.SetFloat("presenca", 1.5f);
            
    //    }
    //    else
    //    {
    //        VoltaAnimacao();
    //    }
    //}




    IEnumerator VoltaAnimacao()
    {
        yield return new WaitForSeconds(0.5f);
        animator.SetFloat("presenca", -1.0f);
    }
    
    //Metodo para touch (Android)
    void Start()
    {

        animator = objeto.GetComponent<Animator>();

    }

    

    void Update()
    {

        //var Point = GameObject.Find("pontuacao").GetComponent<GUIText>();
        //Point.text = "Pontuação: " + Pontuacao.ToString();


        if (Input.touchCount == 1)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos = new Vector2(wp.x, wp.y);
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                animator.SetFloat("presenca", 1.5f);
            }
            else 
            {
                animator.SetFloat("presenca", -1.0f);
            }
        }
    }

    //Debug windows
    void OnMouseEnter()
    {
        animator.SetFloat("presenca", 1.5f);
    }

    void OnMouseExit()
    {
        animator.SetFloat("presenca", -1.0f);
    }
}
