using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public float score = 0;
    [SerializeField] Text text;
    [SerializeField] GameObject player;
    public float hoi = 0;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        score += 1 * Time.deltaTime;
        text.text = "Time alive: " + score.ToString();

        player.transform.rotation = Quaternion.identity;    
    }
}
