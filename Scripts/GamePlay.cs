using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    // Start is called before the first frame update

    [HideInInspector] public float FX, FZ, Force , Degree;
    public Transform Cam;
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        //Debug.Log(Force);
    }


    float turns = 0;

    private void PlayerMovement()
    {

        Degree = (Cam.localRotation.eulerAngles.y + turns) * (Mathf.PI / 180);
        

        if (Input.GetKey("w"))
        {


            transform.localRotation = Quaternion.Euler(0, Cam.localRotation.eulerAngles.y + turns, 0);





            FX = Force * Mathf.Sin(Degree) * Time.deltaTime;
            FZ = Force * Mathf.Cos(Degree) * Time.deltaTime;


            controller.Move(new Vector3(FX, 0, FZ));

        }
        
    }

     private void OnAnimatorMove()
     {
         Force = (playerAnimator.deltaPosition / Time.deltaTime).magnitude;
    
    
    
     }

}
