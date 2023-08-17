using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    // Start is called before the first frame update


    float VelocityX, Acceleration = 1.4f;
    Animator anim;
    private bool TakeSword, SaveSword;
    [HideInInspector]public bool SwordAct;
    GamePlay player;

    void Start()
    {
        anim = GetComponent<Animator>();   
        player = GetComponent<GamePlay>();  

    }

    // Update is called once per frame
    void Update()
    {
       
        PlayerAnim();
        Sword();
        

    }

    
    public void SwordTake()
    {


        SwordT();
    }


    public void SwordSaved() {

        SwordS();
    }


    void SwordT()
    {

        TakeSword = false;
        SwordAct = true;

        EnableM();
        anim.SetLayerWeight(1,1);




    }

    void SwordS() {

        EnableM();
        SaveSword = false;
        SwordAct = false;
        anim.SetLayerWeight(1, 0);

    }


    
    

    public void DisableMove()
    {

        DisableM();

    }


    public void EnableM()
    {
        player.enabled = true;


    }
    void DisableM()
    {

        player.enabled = false;

    }

    private void Sword()
    {


        if (Input.GetKey("m"))
        {

            if (SwordAct)
            {


                SaveSword = true; 

            }
            else
            {
                TakeSword = true;

            }


        }



        anim.SetBool("TakeSword", TakeSword);
        anim.SetBool("SaveSword", SaveSword);
    }


    private void PlayerAnim() {

        

        if (Input.GetKey("w"))
        {

            //walk(FindObjectOfType<GamePlay>().Force);
            if (VelocityX >= 0 && VelocityX <= 0.5f)
            {


                VelocityX += Acceleration * Time.deltaTime;


            }




            if (Input.GetKey("space"))
            {


                if (SwordAct)
                {

                    FindObjectOfType<GamePlay>().Force = 4f;

                    
                    if (VelocityX >= 0.5f && VelocityX <= 1f)
                    {


                        VelocityX += Acceleration * Time.deltaTime;


                    }

                }
                else
                {

                    FindObjectOfType<GamePlay>().Force = 2.8f;


                    if (VelocityX >= 0.5f && VelocityX <= 1f)
                    {


                        VelocityX += Acceleration * Time.deltaTime;


                    }
                }


                


            }
            if (!Input.GetKey("space"))
            {
                FindObjectOfType<GamePlay>().Force = 1.4f;
               

                if (VelocityX > 0.5f && VelocityX <= 1.5f)
                {


                    VelocityX -= Acceleration * Time.deltaTime;


                }


            }




        }


        if (!Input.GetKey("w"))
        {


            if (VelocityX > 0 && VelocityX <= 1.5f)
            {


                VelocityX -= Acceleration * Time.deltaTime;


            }


            if(VelocityX < 0)
            {


                VelocityX = 0;


            }



        }


        anim.SetFloat("VelocityX", VelocityX);
        

    }


}
