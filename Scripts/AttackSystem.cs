using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    // Start is called before the first frame update

    float Attacks_1;
    [HideInInspector] public bool AttackAtv;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


        AttackEnemy();


    }


    public void AttackAtc_Close()
    {
        FindObjectOfType<CharacterAnimation>().EnableM();
        closed();
        
    }


    void closed()
    {

        AttackAtv = false;

    }

    void AttackEnemy()
    {





        if (FindObjectOfType<CharacterAnimation>().SwordAct)
        {


            if (Input.GetKey("p"))
            {
         
                AttackAtv = true;
              
            }
            
        }


        /*if (AttackAtv)
        {

            FindObjectOfType<GamePlay>().enabled = false;
        }
        else
        {
            FindObjectOfType<GamePlay>().enabled = true;

        }*/


        anim.SetBool("AttackAtv", AttackAtv);
        
    }

}
