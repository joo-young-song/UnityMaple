using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Charactor_INFO : MonoBehaviour
{
   public TextMeshProUGUI Char_name;
   public int Char_level;
   private void Awake()
   {
      if (GameObject.Find("Charactor_INFO") != null)
      {
         var charactor_info = GameObject.Find("Charactor_INFO").GetComponent<CharactorStat>();
         Char_name.text = charactor_info.Char_name;

      }
   }
   
}
