using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ColorRainbow : MonoBehaviour {

    public float Speed = 1;
    private Renderer rend;
    private Text Text;
    public Material Base;

    void Start()
    {
        rend = GetComponent<Renderer>();
        Text = GetComponent<Text>();
    }

    void Update()
    {
        Base.SetColor("_Color", HSBColor.ToColor(new HSBColor(Mathf.PingPong(Time.time * Speed, 1), 1, 1)));
        Text.color = Base.color;
    }
}
