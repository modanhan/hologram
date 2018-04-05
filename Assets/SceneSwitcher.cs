using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneSwitcher : MonoBehaviour
{

    public int currentScene, maxScene;

    public GameObject scenes;
    public Image cover;
    public AnimationCurve curve;
    float t;

    // Use this for initialization
    void Start()
    {
        t = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            t = 0;
            StartCoroutine(Switch());
        }
        cover.color = Color.Lerp(Color.clear, Color.black, curve.Evaluate(t));
        t += Time.deltaTime;
    }

    IEnumerator Switch()
    {
        yield return new WaitForSeconds(0.5f);
        for (int i = 0; i < scenes.transform.childCount; i++)
        {
            scenes.transform.GetChild(i).gameObject.SetActive(false);
        }
        currentScene++;
        currentScene %= maxScene;
        scenes.transform.GetChild(currentScene).gameObject.SetActive(true);
    }
}
