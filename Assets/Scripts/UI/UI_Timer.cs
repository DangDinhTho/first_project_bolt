using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Timer : MonoBehaviour
{

    Text _text;
    float _nextTime;
    // Start is called before the first frame update
    void Start()
    {
        _text = transform.GetChild(0).GetComponent<Text>();
    }

    public void Init(float timer)
    {
        _nextTime = Time.time + timer;
    }

    // Update is called once per frame
    void Update()
    {
        if(_nextTime > Time.time)
        {
            _text.text = UI_Cooldown.FloatToTime(-(Time.time - _nextTime), "#0:00");
        }
    }
}
