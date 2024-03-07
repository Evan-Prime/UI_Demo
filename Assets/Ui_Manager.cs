using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ui_Manager : MonoBehaviour
{

    public TextMeshProUGUI output;
    public TMP_InputField input;
    private string userInput;

    private void Update()
    {
        userInput = input.text;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            output.text = userInput;
            input.text = null;
        }
    }
}
