using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "Pull the bird and send it to attack the monsters!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
