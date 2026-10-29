using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public List<GameObject> Obiekty = new List<GameObject>();

    public Gradient gr;
    public int devide;

    public float angle = 15;

    void Start()
    {
        SortObj();
    }

    void SortObj()
    {
        foreach (GameObject go in Obiekty)
        {
            if (go.GetComponent<SpriteRenderer>() != null)
            {
                Sprite(go.GetComponent<SpriteRenderer>());
            }
            else if (go.GetComponent<MeshRenderer>() != null)
            {
                Cube(go.transform);
            }
        }
        
    }


    void Sprite(SpriteRenderer sprite)
    {
        sprite.color = gr.Evaluate(sprite.gameObject.transform.position.y);
    }


    void Cube(Transform tran)
    {
        tran.Rotate(angle, 0, 0);
        tran.position = new Vector3(tran.position.x, tran.position.y + 1 * Time.deltaTime, tran.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        SortObj();
    }
}
