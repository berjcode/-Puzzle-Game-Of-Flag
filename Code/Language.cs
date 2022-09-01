using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Language : MonoBehaviour
{
   [HideInInspector] public List<Text> sceneTexts;
    public List<SceneLanguage> translate;

    private void Start()
    {
        if (Application.systemLanguage == SystemLanguage.French)
        {

           
        }
        
        else if (Application.systemLanguage == SystemLanguage.English)
        {
            
        }

        foreach (Text items in Resources.FindObjectsOfTypeAll(typeof(Text)))
        {
            sceneTexts.Add(items);
        }
    }

    public void translateLanguage(string translateLanguage1)
    {
        for (int i=0; i < translate.Count; i++)
        {
            for (int s = 0; s < sceneTexts.Count; s++)
            {
                if (translateLanguage1 == "turkish")
                {
                    if (translate[i].english == sceneTexts[s].text)
                    {

                        sceneTexts[s].text = translate[i].turkish;



                    }
                    else
                    {
                        if (translate[i].turkish == sceneTexts[s].text)
                        {

                            sceneTexts[s].text = translate[i].english;

                        }
                    }
                }

            }
        }
    }

    public void LanguageChange(string language)
    {
        translateLanguage(language);
    }
}

[System.Serializable]
public class SceneLanguage
{
    public string turkish;
    public string english;

    public SceneLanguage(string turkish, string english)
    {
        this.turkish = turkish;
        this.english = english;
    }
}