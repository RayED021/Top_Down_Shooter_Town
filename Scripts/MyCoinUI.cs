using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyCoinUI : MonoBehaviour
{
    public TMP_Text text;
    public MyScriptableInteger coinScriptable;

    void Update()
    {
        text.text = coinScriptable.value.ToString();
    }
}