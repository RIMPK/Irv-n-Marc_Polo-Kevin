using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    [SerializeField]
    private Transform Y;
    private float alfa;


    // Start is called before the first frame update
    public void Awake()
    {
        /*
         alfa = Mathf.Atan2(Y.transform.position.y - transform.position.y, Y.transform.position.x - transform.position.x) * Mathf.Rad2Deg;*/

    }
    // Update is called once per frame
    public void FixedUpdate()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.rotation = Quaternion.AngleAxis(alfa, Vector3.forward);
        }*/
        Vector3 posmouse = Input.mousePosition;
        posmouse.z = 10;
        Vector3 p = Camera.main.ScreenToWorldPoint(posmouse);
        alfa = Mathf.Atan2(p.y, p.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(alfa, Vector3.forward);
    }
}
