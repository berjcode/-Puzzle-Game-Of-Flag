using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    [SerializeField] private Image _timerImg;
    [SerializeField] private Text _timerText;
    [SerializeField] private float _duration;

    private float _currentTime;
    public GameObject pauseMenuUI;
    public Button ExtraTimeButton;
    private float ExtraTimeCounter;
  
    private void Start()
    {
       
        _currentTime = _duration;

        _timerText.text = _currentTime.ToString();
        StartCoroutine(UpdateTime());

    }

    private IEnumerator UpdateTime()
    {
        while (_currentTime >= 0)
        {
            _timerImg.fillAmount = Mathf.InverseLerp(0, _duration, _currentTime);
            _timerText.text = _currentTime.ToString();
            yield return new WaitForSeconds(1f);
            _currentTime--;

            if (_currentTime == 0)
            {

                pause();
            }

            
        }

        
        yield return null;
       
    }

    public void Update()
    {
        controlTime();
    }

    public void controlTime()
    {
        if(ExtraTimeCounter == 1)
        {
            ExtraTimeButton.interactable = false;

        }
    }
    public void extraTime()
    {
        ExtraTimeCounter++;
        _currentTime += 10;

        
    }
   
    public void finishTime()
    {

        pauseMenuUI.SetActive(true);

    }
    void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 1f;
    }
}
