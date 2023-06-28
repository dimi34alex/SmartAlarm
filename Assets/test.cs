using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject text;
    public TextMeshProUGUI text2;
    
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<TextMeshProUGUI>().text = "АНДРЕЙ ПИДОРАС";
        text2.text = "Андрей пидорас 2";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
