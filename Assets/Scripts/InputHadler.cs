using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHadler : MonoBehaviour
{
    [SerializeField] private InputField _input;
    [SerializeField] private Text _resultText;

    public void ValidateInput() {
      string inputText = _input.text;

      if (inputText == "") {
        _resultText.text = "Invalid name";
        _resultText.color = Color.red;
      } else {
        _resultText.text = "Let's go";
        _resultText.color = Color.green;
      }
    }
}
