using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    //�m�[�c�̃X�s�[�h��ݒ�
    int NoteSpeed = 8;
    bool start;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            start = true;
        }
        if (start)
        {
            transform.position -= transform.forward * Time.deltaTime * NoteSpeed;
        }
    }
}