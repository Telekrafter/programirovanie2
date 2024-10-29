using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv_move : MonoBehaviour
{
    public int speede = 20;
    public int rot = 40;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speede);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * speede);

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speede);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speede);

        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speede);

        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * rot);


        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * rot);


        }
        if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(new Vector3(1, 0, 0) * Time.deltaTime * rot);


        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(new Vector3(-1, 0, 0) * Time.deltaTime * rot);


        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speede = 40;
        }
        else
        { 
            speede = 20;
        }

        
    }
}
