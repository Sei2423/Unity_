using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WritePoint : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cardNameText;

    void Start() {
        cardNameText.text = "�\����������������";
    }
}