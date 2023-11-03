using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camarafollow : MonoBehaviour
{
    [SerializeField]private Transform target;
    public float velociad;

    private void Update()
    {
        Vector3 pos = new Vector3(target.position.x, target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, pos, velociad * Time.deltaTime);
    }
}
