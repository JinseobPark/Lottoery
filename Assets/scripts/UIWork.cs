using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWork : MonoBehaviour
{
    public buttonManager BMscript;
    // Start is called before the first frame update
    void Start()
    {
        BMscript = GameObject.Find("EventSystem").GetComponent<buttonManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset_Numbers()
    {
        for(int i = 0; i < 45; ++i)
        {
            BMscript.buttonNumbers[i].GetComponent<buttonStat>().ChangeToNope();
        }
        BMscript.current_button_number = 0;
    }
}
