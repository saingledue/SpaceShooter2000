﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSpeed : MonoBehaviour
{
    public ParticleSystemRenderer Stars;
    public GameObject Ship;
    public Text StartText;

    public void Start()
    {
        StartText.text = "";
        Stars.lengthScale = 3;
        Ship.GetComponent<ShipMovement>().moveSpeed= 0.0f;
        StartCoroutine(LightSpeedSimilate());

    }

    IEnumerator LightSpeedSimilate()
    {
        float elapsed = 0;
        float duration = 4;
        while (elapsed < duration)
        {
            Stars.lengthScale = Mathf.Lerp(Stars.lengthScale, -140, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(1);
        float stopelapsed= 0;
        float stopduration = 3;
        while (stopelapsed < stopduration)
        {
            Stars.lengthScale = Mathf.Lerp(Stars.lengthScale, -3, stopelapsed / stopduration);
            stopelapsed += Time.deltaTime;
            yield return null;
        }
        Stars.lengthScale = -3f;
        StartText.text = "Start";
        Ship.GetComponent<ShipMovement>().moveSpeed = 4.0f;
        yield return new WaitForSeconds(1);
        StartText.text = "";


    }
}
