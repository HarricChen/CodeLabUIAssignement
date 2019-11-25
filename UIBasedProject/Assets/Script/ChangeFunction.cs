using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeFunction : MonoBehaviour
{
    int counter = 1;
    int order;
    BoxCollider2D currentMaterial;
    public Text functionText;
    public PhysicsMaterial2D[] mat2D;
    public GameObject cubeSelf;
    public GameObject upDraft;
    public GameObject ballSelf;
    Bounce bounceComponent;
    
    

    string[] functions = {"1:Default" , "2:Bouncy" , "3:Smooth" , "4:ZeroG"}; 
    // Start is called before the first frame update

  
    void Start()
    {
        currentMaterial = cubeSelf.GetComponent<BoxCollider2D>(); //BOXCOLLIDER2D + SHAREDMATERIAL .. (COULDBE REND.SHARED MAT) (QUESTION: THESE SYNTAX, IF WE DONT KNOW THEY EXIST WE WILL NEVER THINK OF USING IT? HOW TO AVOID THIS SITUATION)
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changetext()
    {  
        //Change Text Part work with On Click Event;
        //get the order of the function.
        order = counter % functions.Length;
        counter = counter + 1;
        functionText.text = functions[order];

        //execute whatever happened;
        if (order == 0)
        {
            callDefault();
        }

        if (order == 1)
        {
            callBouncy();
        }

        if (order == 2)
        {
            callSmooth();
        }

        if (order == 3)
        {
            callUpdraft();
        }
    }

    public void callDefault()
    {
        clearstats();
    }

    public void callBouncy()
    {
        clearstats();
        currentMaterial.sharedMaterial = mat2D[0];
        // ballSelf.GetComponent<Bounce>().enabled = true;
    
    }


    public void callSmooth()
    {
        clearstats();
        currentMaterial.sharedMaterial = mat2D[1];

    }
    public void callUpdraft()
    {
        clearstats();
        upDraft.SetActive(true);
    }

    public void clearstats()
    {
        //ballSelf.GetComponent<Bounce>().enabled = false;

        upDraft.SetActive(false);
        currentMaterial.sharedMaterial = mat2D[2];
    }

   

    //instantitate (prefab, cubepos.position, cubePos.rotation); vs cubePos.up vs. Vector2 (cubePos.position.x , cubePos.position.y + 5, cubePos.rotation);
    //Destroy Prefab and Destory the prefab that is on collision with the player is different?
    //how to refer to the file in the asset folder without using public.
}
