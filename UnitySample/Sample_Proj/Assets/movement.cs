using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour
{

    private float walkingSpeed = 3f;
   
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //Controller Buttons for control gameobject
        MoveRightAndLeft(Input.GetAxis("Horizontal"));
        MoveForwardAndBack(Input.GetAxis("Vertical"));

    }

    //Moves gameobject left and right
    void MoveRightAndLeft(float direction)
    {
       
        transform.position += walkingSpeed * Vector3.right * direction * Time.deltaTime;

    }

    //Moves gameobject forward and backwards
    void MoveForwardAndBack(float direction)
    {
      

        transform.position += walkingSpeed * Vector3.forward * direction * Time.deltaTime;
    }

   

}
