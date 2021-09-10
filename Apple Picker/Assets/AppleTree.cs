using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject apllePrefab;
    //speed movement aplee
    public float speed = 1f;
    //���������� �� ������� ������ ���������� ����������� �������� ������
    public float leftAndRightEdge = 10f;
    //����������� ���������� �������� ����������� ��������
    public float chanceToChangeDirections = 0.1f;
    //������� �������� ����������� �����
    public float secondsBetwenAppleDrop = 1f;
    private void Start()
    {
        Invoke("DropApple", 2f);
    }
    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(apllePrefab);
        apllePrefab.transform.position = transform.position;
        Invoke("DropApple", secondsBetwenAppleDrop);
    }
    private void Update()
    {
        //normal movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //������ �������� ������
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //������ �������� �����
        }
       
        

    }
    private void FixedUpdate()//��������� ����� �����������
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
