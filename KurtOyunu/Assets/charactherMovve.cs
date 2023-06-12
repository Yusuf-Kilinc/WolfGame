using System.Collections.Generic;
using UnityEngine;

public class charactherMovve : MonoBehaviour
{
    public GameObject Head;
    float rotasyona;
    float rotasyonb;
    public FixedJoystick Fj;
    public float force;

    public List<GameObject> Yenilebilirler;

    public List<Transform> body;
  //  public GameObject target;
   
    private void Update()
    {
        rotasyona = Input.GetAxis("Horizontal");
        rotasyonb = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(-rotasyonb, 0,  rotasyona) * force * Time.deltaTime;
        Head.transform.Translate(movement);


        if (Input.GetKeyDown(KeyCode.E))
        {
            force = 8;
        }else if(Input.GetKeyUp(KeyCode.E)) 
        {
            force = 5;
        }

    }



}
