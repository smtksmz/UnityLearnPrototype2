using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    private void Awake()
    {
        _text.text = DestroyOutOfBounds.animalsCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = DestroyOutOfBounds.animalsCounter.ToString();
    }
}
