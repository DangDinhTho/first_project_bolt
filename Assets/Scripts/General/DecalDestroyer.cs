using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecalDestroyer : MonoBehaviour
{

    [SerializeField]
    private float _time;

    // Start is called before the first frame update
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(_time);
        Destroy(gameObject);
    }

}
