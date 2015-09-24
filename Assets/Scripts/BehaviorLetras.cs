using UnityEngine;
using System.Collections;

public class BehaviorLetras : MonoBehaviour
{
    private MataPrefab mp;
    public string letra;
    //Metodo de arrastar e soltar para mouse
    private Vector3 screenPoint;

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    {
        //GetComponent<GameObject>().tag = letra;
        //GameObject.FindGameObjectWithTag(letra);

        //if (respawn == null)
        //{
        //    respawn = GameObject.FindWithTag("letras");
        //    //(respawnPrefab, respawn.transform.position, respawn.transform.rotation) as GameObject;
        //    Instantiate(respawn);


        if (Input.mousePresent == true)
        {
            mp = GetComponent<MataPrefab>();
            mp.tempoMaximoVida = 60f;
        }
        

        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentPos = Camera.main.ScreenToWorldPoint(currentScreenPoint);
        transform.position = currentPos;
    }

    //Metodo utilizado quando roda em Android
    private float maxPickingDistance = 2500;// increase if needed, depending on your scene size
    private Transform pickedObject = null;

    void Update()
    {
        if (Input.touchCount >= 1)
        {

            foreach (Touch touch in Input.touches)
            {
                //Identifica o objeto que foi 'tocado'
                Ray ray = Camera.main.ScreenPointToRay(touch.position);

                if (touch.phase == TouchPhase.Began)
                {
                    GetComponent<GameObject>().tag = letra;
                    RaycastHit hit = new RaycastHit();
                    if (Physics.Raycast(ray, out hit, maxPickingDistance))
                    {
                        pickedObject = hit.transform;
                    }
                    else
                    {
                        pickedObject = null;
                    }
                }
                else if (touch.phase == TouchPhase.Moved)
                {
                    if (pickedObject != null)
                    {
                        Vector2 screenDelta = touch.deltaPosition;

                        float halfScreenWidth = 0.1f * Screen.width;
                        float halfScreenHeight = 0.1f * Screen.height;

                        float dx = screenDelta.x / halfScreenWidth;
                        float dy = screenDelta.y / halfScreenHeight;

                        Vector3 objectToCamera =
                            pickedObject.transform.position - Camera.main.transform.position;
                        float distance = objectToCamera.magnitude;

                        float fovRad = Camera.main.fieldOfView * Mathf.Deg2Rad;
                        float motionScale = distance * Mathf.Tan(fovRad / 2);

                        Vector3 translationInCameraRef =
                            new Vector3(motionScale * dx, motionScale * dy, 0);

                        Vector3 translationInWorldRef =
                            Camera.main.transform.TransformDirection(translationInCameraRef);

                        pickedObject.position += translationInWorldRef;
                    }
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    pickedObject = null;
                }
            }
        }
    }
}
