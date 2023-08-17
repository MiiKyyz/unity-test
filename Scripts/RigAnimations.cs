using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class RigAnimations : MonoBehaviour
{
    // Start is called before the first frame update

    public MultiParentConstraint Rigger;
 
    bool LeaveSwordA=true;

    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        SwordPanel();
       
    }


    private void LeaveSwordAnim()
    {

        LeaveSwordA = true;
        

  

    }


    private void TakeSwordAnim()
    {

        LeaveSwordA = false;


        
        

        

    }



    void SwordPanel()
    {


     


        if (LeaveSwordA)
        {


            var miky = Rigger.data.sourceObjects;
            miky.SetWeight(0, 0);
            miky.SetWeight(1, 1);
            Rigger.data.sourceObjects = miky;
       

        }
        else
        {
            var miky = Rigger.data.sourceObjects;
            miky.SetWeight(0, 1);
            miky.SetWeight(1, 0);
            Rigger.data.sourceObjects = miky;
         
        }

    }


}
