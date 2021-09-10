using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public Text scoreGt;
    private void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGt = scoreGO.GetComponent<Text>();
        scoreGt.text = "0";
    }
    private void Update()
    {
        //�������� ������� ���������� ��������� ���� �� ������ �� Inpyt
        Vector3 mosePos2D = Input.mousePosition;
        //���������� Z ������ ���������� ��� ������ � ���������� ������������ ���������� ��������� ����
        mosePos2D.z = -Camera.main.transform.position.z;
        //������������� ����� �� ���������� ��������� ������ � ���������� ���������� ����
        Vector3 mousePoint3D = Camera.main.ScreenToWorldPoint(mosePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePoint3D.x;
        this.transform.position = pos;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //�������� ������,�������� � ��� �������
        GameObject colliderWith = collision.gameObject;
        if(colliderWith.tag == "Apple")
        {
            Destroy(colliderWith);
            int score = int.Parse(scoreGt.text);
            score += 1;
            scoreGt.text = score.ToString();
            if(score > HidhScore.score)
            {
                HidhScore.score = score;
            }    
        }
    }
}
