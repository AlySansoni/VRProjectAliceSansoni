using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Serialization;

public class ButtonManager : MonoBehaviour
{
    public GameObject mainInfos;
    public Button englishButton;
    public Button italianButton;
    public Button playButton;
    public Button pauseButton;
    public Button restartButton;
    public AudioSource description;
    [FormerlySerializedAs("BigBenIta")] public AudioClip bigBenIta;
    [FormerlySerializedAs("WhiteHouseIta")] public AudioClip whiteHouseIta;
    [FormerlySerializedAs("EiffelTowerIta")] public AudioClip eiffelTowerIta;
    [FormerlySerializedAs("StonehengeIta")] public AudioClip stonehengeIta;
    [FormerlySerializedAs("EmpireStateBuildingIta")] public AudioClip empireStateBuildingIta;
    [FormerlySerializedAs("PisaTowerIta")] public AudioClip pisaTowerIta;
    [FormerlySerializedAs("TajMahalIta")] public AudioClip tajMahalIta;
    [FormerlySerializedAs("BurjKhalifaIta")] public AudioClip burjKhalifaIta;
    [FormerlySerializedAs("ColosseumIta")] public AudioClip colosseumIta;
    [FormerlySerializedAs("StatueOfLibertyIta")] public AudioClip statueOfLibertyIta;
    [FormerlySerializedAs("BigBenEng")] public AudioClip bigBenEng;
    [FormerlySerializedAs("WhiteHouseEng")] public AudioClip whiteHouseEng;
    [FormerlySerializedAs("EiffelTowerEng")] public AudioClip eiffelTowerEng;
    [FormerlySerializedAs("StonehengeEng")] public AudioClip stonehengeEng;
    [FormerlySerializedAs("EmpireStateBuildingEng")] public AudioClip empireStateBuildingEng;
    [FormerlySerializedAs("PisaTowerEng")] public AudioClip pisaTowerEng;
    [FormerlySerializedAs("TajMahalEng")] public AudioClip tajMahalEng;
    [FormerlySerializedAs("BurjKhalifaEng")] public AudioClip burjKhalifaEng;
    [FormerlySerializedAs("ColosseumEng")] public AudioClip colosseumEng;
    [FormerlySerializedAs("StatueOfLibertyEng")] public AudioClip statueOfLibertyEng;
    public Button stopButton;
    private String _model;
    public GameObject confirmLanguageChange;

    public void BigBenFound()
    {
        _model = "BigBen";
    }
    
    public void WhiteHouseFound()
    {
        _model = "WhiteHouse";
    }
    
    public void ColosseumFound()
    {
        _model = "Colosseum";
    }
    
    public void TajMahalFound()
    {
        _model = "TajMahal";
    }

    public void BurjKhalifaFound()
    {
        _model = "BurjKhalifa";
    }
    
    public void LibertyStatueFound()
    {
        _model = "LibertyStatue";
    }
    
    public void EmpireBuildingFound()
    {
        _model = "EmpireStateBuilding";
    }
    
    public void EiffelTowerFound()
    {
        _model = "EiffelTower";
    }
    
    public void StonehengeFound()
    {
        _model = "Stonehenge";
    }
    public void PisaTowerFound()
    {
        _model = "PisaTower";
    }

    public void OnTargetFound()
    {
        TMP_Text[] infos = mainInfos.GetComponentsInChildren<TMP_Text>();

        switch (_model)
        {
            case "BigBen":
                if (LanguageSetting.Language == "italian")
                {
                    infos[0].text = "Big Ben";
                    infos[1].text = "Luogo: Londra, Regno Unito";
                    infos[2].text = "Data: 1834-1858"; 
                }
                else
                {
                    infos[0].text = "Big Ben";
                    infos[1].text = "Where: London, United Kingdom";
                    infos[2].text = "When: 1834-1858"; 
                }
                break;
            case "WhiteHouse":
                if (LanguageSetting.Language == "italian")
                {
                    infos[0].text = "Casa Bianca";
                    infos[1].text = "Luogo: Londra, Regno Unito";
                    infos[2].text = "Data: 1834-1858"; 
                }
                else
                {
                    infos[0].text = "The White House";
                    infos[1].text = "Where: London, United Kingdom";
                    infos[2].text = "When: 1834-1858"; 
                }
                break;
            case "Colosseum":
                if (LanguageSetting.Language == "italian")
                {
                    infos[0].text = "Colosseo";
                    infos[1].text = "Luogo: Roma, Italia";
                    infos[2].text = "Data: 70-80 DC"; 
                }
                else
                {
                    infos[0].text = "Colosseum";
                    infos[1].text = "Where: Rome, Italy";
                    infos[2].text = "When: 70-80 AC"; 
                }
                break;
            case "TajMahal":
                if (LanguageSetting.Language == "italian")
                {
                    infos[0].text = "Taj Mahal";
                    infos[1].text = "Luogo: Agra, India";
                    infos[2].text = "Data: 1632-1654"; 
                }
                else
                {
                    infos[0].text = "Taj Mahal";
                    infos[1].text = "Where: Agra, India";
                    infos[2].text = "When: 1632-1654"; 
                }
                break;
            case "BurjKhalifa":
                if (LanguageSetting.Language == "italian")
                {
                    infos[0].text = "Burj Khalifa";
                    infos[1].text = "Luogo: Dubai, Emirati Arabi Uniti";
                    infos[2].text = "Data: 2004-2009"; 
                }
                else
                {
                    infos[0].text = "Burj Khalifa";
                    infos[1].text = "Where: Dubai, United Arab Emirates";
                    infos[2].text = "When: 2004-2009"; 
                }
                break;
            case "LibertyStatue":
                if (LanguageSetting.Language == "italian")
                {
                    infos[0].text = "Statua della libertà";
                    infos[1].text = "Luogo: New York, Stati Uniti";
                    infos[2].text = "Data: 1886"; 
                }
                else
                {
                    infos[0].text = "Statue of Liberty";
                    infos[1].text = "Where: New York, United States";
                    infos[2].text = "When: 1886"; 
                }
                break;
            case "EmpireStateBuilding":
                if (LanguageSetting.Language == "italian")
                {
                    infos[0].text = "Empire State Building";
                    infos[1].text = "Luogo: New York, Stati Uniti";
                    infos[2].text = "Data: 1930-1931"; 
                }
                else
                {
                    infos[0].text = "Empire State Building";
                    infos[1].text = "Where: New York, United States";
                    infos[2].text = "When: 1930-1931"; 
                }
                break;
            case "EiffelTower":
                if (LanguageSetting.Language == "italian")
                {
                    infos[0].text = "Torre Eiffel";
                    infos[1].text = "Luogo: Parigi, Francia";
                    infos[2].text = "Data: 1887-1889"; 
                }
                else
                {
                    infos[0].text = "Eiffel Tower";
                    infos[1].text = "Where: Paris, France";
                    infos[2].text = "When: 1887-1889"; 
                }
                break;
            case "Stonehenge":
                if (LanguageSetting.Language == "italian")
                {
                    infos[0].text = "Stonehenge";
                    infos[1].text = "Luogo: Wiltshire, Regno Unito";
                    infos[2].text = "Data: tra 3100 e 1600 a.C"; 
                }
                else
                {
                    infos[0].text = "Stonehenge";
                    infos[1].text = "Where: Wiltshire, United Kingdom";
                    infos[2].text = "When: between 3100-1600 BC"; 
                }
                break;
            default:
                if (LanguageSetting.Language == "italian")
                {
                    infos[0].text = "Torre Pendente";
                    infos[1].text = "Luogo: Pisa, Italia";
                    infos[2].text = "Data: 1173-1373"; 
                }
                else
                {
                    infos[0].text = "Leaning Tower";
                    infos[1].text = "Where: Pisa, Italy";
                    infos[2].text = "When: 1173-1373"; 
                }

                break;
        }
        mainInfos.SetActive(true);
        playButton.gameObject.SetActive(true);
        playButton.interactable = true;
        if (LanguageSetting.Language == "italian")
            englishButton.gameObject.SetActive(true);
        else
            italianButton.gameObject.SetActive(true);
    
    }

    public void OnTargetLost()
    {
        mainInfos.SetActive(false);
        playButton.gameObject.SetActive(false);
        if (englishButton != null)
            englishButton.gameObject.SetActive(false);
        if (italianButton != null)
            italianButton.gameObject.SetActive(false);
        if (pauseButton == null) return;
        pauseButton.gameObject.SetActive(false);
        stopButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        
        
        description.Stop();


    }

    public void ChangeLanguage()
    {
        if (description.isPlaying)
            description.Pause();
        
        TMP_Text phrase = confirmLanguageChange.GetComponentInChildren<TMP_Text>();
        Button[] confirmButtons = confirmLanguageChange.GetComponentsInChildren<Button>();
        
        if (LanguageSetting.Language == "italian")
        {
            phrase.text = "Confermi di voler cambiare lingua?";
            confirmButtons[0].GetComponentInChildren<TMP_Text>().text = "Conferma";
            confirmButtons[1].GetComponentInChildren<TMP_Text>().text = "Annulla";

        }
        else
        {
            phrase.text = "Are you sure you want to change the language?";
            confirmButtons[0].GetComponentInChildren<TMP_Text>().text = "Confirm";
            confirmButtons[1].GetComponentInChildren<TMP_Text>().text = "Delete";
        }
        
        confirmLanguageChange.SetActive(true);

    }

    public void ConfirmChange()
    {
        description.Stop();
        if (LanguageSetting.Language == "italian")
        {
            LanguageSetting.Language = "english";
            englishButton.gameObject.SetActive(false);
            italianButton.gameObject.SetActive(true);
        }
        else
        {
            LanguageSetting.Language = "italian";
            englishButton.gameObject.SetActive(true);
            italianButton.gameObject.SetActive(false);
        }
        
        confirmLanguageChange.SetActive(false);
        playButton.interactable = true;
        OnTargetLost();
        OnTargetFound();
    }

    public void DeleteChange()
    {
        confirmLanguageChange.SetActive(false);
        playButton.interactable = true;
    }

    public void StartDescription()
    {
        //description.GetComponent<AudioSource>();
        switch (_model){
            case "BigBen":
                if (LanguageSetting.Language == "italian")
                    description.clip = bigBenIta;
                else
                    description.clip = bigBenEng; 
                break;
            case "WhiteHouse":
                if (LanguageSetting.Language == "italian")
                    description.clip = whiteHouseIta;
                else
                    description.clip = whiteHouseEng;
                break;
            case "Colosseum":
                if (LanguageSetting.Language == "italian")
                    description.clip = colosseumIta;
                else
                {
                    description.clip = colosseumEng;
                }

                break;
            case "TajMahal":
                if (LanguageSetting.Language == "italian")
                    description.clip = tajMahalIta;
                else
                    description.clip = tajMahalEng;
                break;
            case "BurjKhalifa":
                if (LanguageSetting.Language == "italian")
                    description.clip = burjKhalifaIta;
                else
                    description.clip = burjKhalifaEng; 
                break;
            case "LibertyStatue":
                    if (LanguageSetting.Language == "italian")
                        description.clip = statueOfLibertyIta;
                    else
                        description.clip = stonehengeEng; 
                    break;
            case "EmpireStateBuilding":
                if (LanguageSetting.Language == "italian")
                    description.clip = empireStateBuildingIta;
                else
                    description.clip = empireStateBuildingEng;
                break;
            case "EiffelTower":
                if (LanguageSetting.Language == "italian")
                    description.clip = eiffelTowerIta;
                else
                    description.clip = eiffelTowerEng;
                break;
            case "Stonehenge":
                if (LanguageSetting.Language == "italian")
                    description.clip = stonehengeIta;
                else
                    description.clip = stonehengeEng;
                break;
            default:
                if (LanguageSetting.Language == "italian")
                    description.clip = pisaTowerIta;
                else
                    description.clip = pisaTowerEng;
                break;
        }
        
        description.Play();
        playButton.interactable = false;
        pauseButton.gameObject.SetActive(true);
        stopButton.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void PauseDescription()
    {
        description.Pause();
        playButton.interactable = true;
    }

    public void StopDescription()
    {
        description.Stop();
        playButton.interactable = true;
        pauseButton.gameObject.SetActive(false);
        stopButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
    }
    public void RestartDescription()
    {
        description.Stop();
        description.Play();
    }
    
   
    
}
