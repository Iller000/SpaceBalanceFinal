using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    [SerializeField] Text totalscoreText;
    [SerializeField] Text balancescoreText;
    

    static public int totalScore = 0;
    static public int balanceScore = 0;
    
    

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
       
        totalscoreText.text = totalScore.ToString() + " Points";
        balancescoreText.text = "Balance: " + balanceScore.ToString();
    }

    public void AddPoint()
    {
        totalScore += 1;
        totalscoreText.text = totalScore.ToString() + " Points";

    }

    public void Balance()
    {

        balanceScore = CollectorBalance._score;
        balancescoreText.text = "Balance " + balanceScore.ToString();   
        
    }
    





}
