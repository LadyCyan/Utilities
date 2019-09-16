using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class InputManager : MonoBehaviour
{
    public Text outText;
    public InputField textIn;
    public Button enterButton;

    // Start is called before the first frame update
    void Start()
    {
        outText.text = "";
    }

    public void EnterPressed()
    {
        outText.text = Utilities.ProcessText(textIn.text);
    }
}
