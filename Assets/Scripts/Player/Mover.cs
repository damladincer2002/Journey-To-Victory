using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float leftRightSpeed = 35f;
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.fixedDeltaTime, Space.World);
#if UNITY_ANDROID

        /* Touch parmak = Input.GetTouch(0);
         if (Input.touchCount > 0)
         {
             if (parmak.phase == TouchPhase.Moved)
             {
                     if (this.gameObject.transform.position.x < LevelBoundary.leftSide || this.gameObject.transform.position.x > LevelBoundary.rightSide) return;
                     //transform.Translate(Vector3.left * leftRightSpeed * Time.fixedDeltaTime * (parmak.deltaPosition.x / 10f));
                     transform.Translate(-Vector3.left * leftRightSpeed * Time.fixedDeltaTime * (parmak.deltaPosition.x / 10f));
                 // transform.Translate(-Vector3.left * leftRightSpeed * Time.fixedDeltaTime * (parmak.deltaPosition.x / 10f));

             }


             /*if (parmak.deltaPosition.x > 20)
             {
                 if (this.gameObject.transform.position.x > LevelBoundary.rightSide) return;
                 transform.Translate(-Vector3.left * leftRightSpeed * Time.fixedDeltaTime);
             }
             if(parmak.deltaPosition.x < -20)
             {
                 if (this.gameObject.transform.position.x < LevelBoundary.leftSide) return;
                 transform.Translate(Vector3.left * leftRightSpeed * Time.fixedDeltaTime);
             }*/
        /*if (parmak.phase == TouchPhase.Began)
        {
            Debug.Log("Dokundu");
        }
        if (parmak.phase == TouchPhase.Stationary)
        {
            Debug.Log("Dokunuluyor.");
        }
        if (parmak.phase == TouchPhase.Moved)
        {
            Debug.Log("Sürükleniliniyor.");
        }
        if (parmak.phase == TouchPhase.Ended)
        {
            Debug.Log("Dokunma Bitti.");
        }
    }
    //  Debug.Log("ONLY ANDROID");*/
#endif
#if UNITY_EDITOR_WIN
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.leftSide) return;
            transform.Translate(Vector3.left * leftRightSpeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x > LevelBoundary.rightSide) return;
            transform.Translate(-Vector3.left * leftRightSpeed * Time.fixedDeltaTime);
        }
#endif
    }
    public void Move(bool isRight)
    {
        if (isRight)
        {
            if (this.gameObject.transform.position.x > LevelBoundary.rightSide) return;
            transform.Translate(Vector3.right * leftRightSpeed * Time.fixedDeltaTime);
        }
        else
        {
            if (this.gameObject.transform.position.x < LevelBoundary.leftSide) return;
            transform.Translate(Vector3.left * leftRightSpeed * Time.fixedDeltaTime);
        }

    }
}
