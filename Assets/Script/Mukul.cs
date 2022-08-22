using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Mukul : MonoBehaviour
{
    public LayerMask layer;
    public int score;
    public TextMeshProUGUI scoreUI;

    public ParticleSystem destroyparticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // scoreUI.text = score.ToString();
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, 1, layer)){
            Destroy(hit.transform.gameObject);
            Instantiate(destroyparticle, hit.transform.position, Quaternion.identity);
        }
    }

//     private void OnCollisionEnter(Collision col) {
//         scoreUI.text = score.ToString();
//         if (col.gameObject.tag == "Target"){
//             score++;
//         }
//     }
}
