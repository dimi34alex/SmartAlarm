using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEditor.UI;
using TMPro;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject text;
    
    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<TextMeshProUGUI>().text = "АНДРЕЙ ПИДОРАС";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
