using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Mukul : MonoBehaviour
{
    public LayerMask layer;
    public int score;
    public TextMeshProUGUI scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreUI.text = score.ToString();
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 1, layer)){
            Destroy(hit.transform.gameObject);
            score++;
        }
    }
}
