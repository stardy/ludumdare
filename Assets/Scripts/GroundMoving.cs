using UnityEngine;
using System.Collections;

public class GroundMoving : MonoBehaviour
{


    public float speed;
    public bool isGroundMoving = true;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isGroundMoving)
        {
            var temp = GetComponent<Renderer>().material.mainTextureOffset;
            temp.x += speed*Time.deltaTime;
            GetComponent<Renderer>().material.mainTextureOffset = temp;
        }
    }
}
