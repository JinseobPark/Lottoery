using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonManager : MonoBehaviour
{
    public GameObject[] buttonNumbers = new GameObject[45];
    public int max_button_number = 6;
    public int current_button_number;
    // Start is called before the first frame update
    void Start()
    {
        max_button_number = 6;
        current_button_number = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
