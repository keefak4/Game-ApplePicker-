using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject apllePrefab;
    //speed movement aplee
    public float speed = 1f;
    //Расстояине на котором должно измениться направление движения яблони
    public float leftAndRightEdge = 10f;
    //Вероятность случайного изменеия направления движения
    public float chanceToChangeDirections = 0.1f;
    //Частота создания экземпларов яблок
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
            speed = Mathf.Abs(speed); //Начать движение вправо
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //Начать движение влево
        }
       
        

    }
    private void FixedUpdate()//случайная смена направления
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
