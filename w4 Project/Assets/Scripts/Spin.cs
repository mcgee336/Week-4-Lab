using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 450f;
    


// Update is called once per frame
void Update()
    {

        transform.Rotate(0f, 1 * Time.deltaTime * rotateSpeed, 0f, Space.Self);

     if (gameObject.tag == "Hit")
        {
            rotateSpeed = -450f;
        }

    }


}
