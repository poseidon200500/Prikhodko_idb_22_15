using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//10.1 0.84 -1.16
public class project : MonoBehaviour
{
    public GameObject sphere;
    public GameObject capsule;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    public void start_sphere ()
    {
     sphere.SetActive(!sphere.activeSelf);
    }
    public void start_capsule()
    {
     capsule.SetActive(!capsule.activeSelf);
    }
}
