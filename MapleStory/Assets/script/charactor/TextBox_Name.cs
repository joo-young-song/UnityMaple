using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBox_Name : MonoBehaviour
{
    public string stringToEdit = "이름을 입력하세요";

    void OnGUI()
    {
        stringToEdit = GUI.TextField(new Rect(150, 190, 190, 35), stringToEdit, 30);
    }

}
