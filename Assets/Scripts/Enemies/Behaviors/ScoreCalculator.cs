﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    public Text scoreValueText;
    private int scoreValue;

    private void Start()
    {
        //scoreValueText = 
    }

    private void OnEnable()
    {
        Enemy.OnDeath += Calculate;
    }

    private void OnDisable()
    {
        Enemy.OnDeath -= Calculate;
    }

    private void Calculate()
    {
        scoreValue = Convert.ToInt32(scoreValueText.text.ToString());
        scoreValue++;
        scoreValueText.text = String.Format("{0:000}", scoreValue);
    }
 }