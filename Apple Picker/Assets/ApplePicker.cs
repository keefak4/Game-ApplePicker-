using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    public int numBasket = 3;
    public float basketBottoY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;

    private void Start()
    {
        basketList = new List<GameObject>();
        for(int i = 0;i < numBasket;i++)
        {
            GameObject tbasketGo = Instantiate<GameObject>(basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottoY + (basketSpacingY * i);
            tbasketGo.transform.position = pos;
            basketList.Add(tbasketGo);
        }
    }

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach(GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
        int basketIndex = basketList.Count - 1;
        GameObject tBasketGO = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);
        if(basketList.Count == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
