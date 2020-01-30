using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMagic : MonoBehaviour
{
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        //float health = 50.45f
        // bool 
        int minNumber = 1;
        int maxNumber = 1000;
        int guess;
        Debug.Log("Добро пожаловать.");
        Debug.Log("Загадайте число.");
        Debug.Log("Мин число : " + minNumber);
  
        Debug.Log("Макс чило: " + maxNumber);

        guess = (minNumber + maxNumber) / 2;
        Debug.Log("Ваше число : " + guess + "?");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow press");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))

        {
            Debug.Log("Down Arrow press");
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Я угадал! Ваше число : " + guess);
        }
    }

}
