using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class View3DManager: MonoBehaviour
{
    [SerializeField] private GameObject colosseum;
    [SerializeField] private GameObject bigBen;
    [SerializeField] private GameObject tajMahal;
    [SerializeField] private GameObject whiteHouse;
    [SerializeField] private GameObject empireState;
    [SerializeField] private GameObject burjKhalifa;
    [SerializeField] private GameObject eiffelTower;
    [SerializeField] private GameObject pisaTower;
    [SerializeField] private GameObject stoneHenge;
    [SerializeField] private GameObject libertyStatue;

    [SerializeField] private GameObject confirmLanChange;
    [SerializeField] private Button playButton;
    [SerializeField] private Button stopButton;
    [SerializeField] private Button restartButton;
    [SerializeField] private Button pauseButton;
    [SerializeField] private Button englishButton;
    [SerializeField] private Button italianButton;
    [SerializeField] private GameObject mainInfo;
    
    [SerializeField] private AudioClip bigBenIta;
    [SerializeField] private AudioClip whiteHouseIta;
    [SerializeField] private AudioClip eiffelTowerIta;
    [SerializeField] private AudioClip stonehengeIta;
    [SerializeField] private AudioClip empireStateBuildingIta;
    [SerializeField] private AudioClip pisaTowerIta;
    [SerializeField] private AudioClip tajMahalIta;
    [SerializeField] private AudioClip burjKhalifaIta;
    [SerializeField] private AudioClip colosseumIta;
    [SerializeField] private AudioClip statueOfLibertyIta;
    [SerializeField] private AudioClip bigBenEng;
    [SerializeField] private AudioClip whiteHouseEng;
    [SerializeField] private AudioClip eiffelTowerEng;
    [SerializeField] private AudioClip stonehengeEng;
    [SerializeField] private AudioClip empireStateBuildingEng;
    [SerializeField] private AudioClip pisaTowerEng;
    [SerializeField] private AudioClip tajMahalEng;
    [SerializeField] private AudioClip burjKhalifaEng;
    [SerializeField] private AudioClip colosseumEng;
    [SerializeField] private AudioClip statueOfLibertyEng;
    [SerializeField] private AudioSource description;
    
    
    // Start is called before the first frame update
    void Start()
    {
        switch (LanguageFavoriteManager.PendingModel)
        {
            case "Colosseum":
                colosseum.SetActive(true);
                break;
            case "Stonehenge":
                stoneHenge.SetActive(true);
                break;
            case "BigBen":
                bigBen.SetActive(true);
                break;
            case "BurKhalifa":
                burjKhalifa.SetActive(true);
                break;
            case "EiffelTower":
                eiffelTower.SetActive(true);
                break;
            case "PisaTower":
                pisaTower.SetActive(true);
                break;
            case "WhiteHouse":
                whiteHouse.SetActive(true);
                break;
            case "StatueOfLiberty":
                libertyStatue.SetActive(true);
                break;
            case "TajMahal":
                tajMahal.SetActive(true);
                break;
            case "EmpireStateBuilding":
                empireState.SetActive(true);
                break;
            

        }
        
        //playButton.gameObject.SetActive(true);
        if (LanguageSetting.Language == "italian")
            englishButton.gameObject.SetActive(true);
        else
            italianButton.gameObject.SetActive(true);
        
        _mainInfoDisplay();
    }

    private void _mainInfoDisplay()
    {
        TMP_Text[] infos = mainInfo.GetComponentsInChildren<TMP_Text>();

        switch (LanguageFavoriteManager.PendingModel)
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
            case "StatueOfLiberty":
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
        mainInfo.SetActive(true);
        playButton.gameObject.SetActive(true);
        playButton.interactable = true;
        if (LanguageSetting.Language == "italian")
            englishButton.gameObject.SetActive(true);
        else
            italianButton.gameObject.SetActive(true);


    }

    public void ReturnToFavourites()
    {
        switch (LanguageFavoriteManager.PendingModel)
        {
            case "Colosseum":
                colosseum.SetActive(false);
                break;
            case "Stonehenge":
                stoneHenge.SetActive(false);
                break;
            case "BigBen":
                bigBen.SetActive(false);
                break;
            case "BurKhalifa":
                burjKhalifa.SetActive(false);
                break;
            case "EiffelTower":
                eiffelTower.SetActive(false);
                break;
            case "PisaTower":
                pisaTower.SetActive(false);
                break;
            case "WhiteHouse":
                whiteHouse.SetActive(false);
                break;
            case "StatueOfLiberty":
                libertyStatue.SetActive(false);
                break;
            case "TajMahal":
                tajMahal.SetActive(false);
                break;
            case "EmpireStateBuilding":
                empireState.SetActive(false);
                break;
            
        }

        description.Stop();
        stopButton.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        SceneManager.LoadScene("FavouriteList");
    }
 
    public void ONPlayClick()
    {
        //description.GetComponent<AudioSource>();
        description.clip = LanguageFavoriteManager.PendingModel switch
        {
            "BigBen" => LanguageSetting.Language == "italian" ? bigBenIta : bigBenEng,
            "WhiteHouse" => LanguageSetting.Language == "italian" ? whiteHouseIta : whiteHouseEng,
            "Colosseum" => LanguageSetting.Language == "italian" ? colosseumIta : colosseumEng,
            "TajMahal" => LanguageSetting.Language != "italian" ? tajMahalEng : tajMahalIta,
            "BurjKhalifa" => LanguageSetting.Language == "italian" ? burjKhalifaIta : burjKhalifaEng,
            "StatueOfLiberty" => LanguageSetting.Language == "italian" ? statueOfLibertyIta : statueOfLibertyEng,
            "EmpireStateBuilding" => LanguageSetting.Language == "italian"
                ? empireStateBuildingIta
                : empireStateBuildingEng,
            "EiffelTower" => LanguageSetting.Language == "italian" ? eiffelTowerIta : eiffelTowerEng,
            "Stonehenge" => LanguageSetting.Language == "italian" ? stonehengeIta : stonehengeEng,
            _ => LanguageSetting.Language == "italian" ? pisaTowerIta : pisaTowerEng
        };

        description.Play();
        playButton.interactable = false;
        pauseButton.gameObject.SetActive(true);
        stopButton.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        
    }

    public void ONPauseClick()
    {
        description.Pause();
        playButton.interactable = true;
    }

    public void ONRestartClick()
    {
        playButton.interactable = true;
        description.Stop();
        description.Play();
    }

    public void ONStopClick()
    {
        description.Stop();
        playButton.interactable = true;
        pauseButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        stopButton.gameObject.SetActive(false);
    }
    
    public void ChangeLanguage()
    {
        if (description.isPlaying)
            description.Pause();
        
        TMP_Text phrase = confirmLanChange.GetComponentInChildren<TMP_Text>();
        Button[] confirmButtons = confirmLanChange.GetComponentsInChildren<Button>();
        
        if (LanguageSetting.Language == "italian")
        {
            phrase.text = "Confermi di voler cambiare lingua?";
            confirmButtons[0].GetComponentInChildren<TMP_Text>().text = "Conferma";
            confirmButtons[1].GetComponentInChildren<TMP_Text>().text = "Annulla";
            englishButton.gameObject.SetActive(false);

        }
        else
        {
            phrase.text = "Are you sure you want to change the language?";
            confirmButtons[0].GetComponentInChildren<TMP_Text>().text = "Confirm";
            confirmButtons[1].GetComponentInChildren<TMP_Text>().text = "Delete";
            italianButton.gameObject.SetActive(false);
        }
        
        playButton.gameObject.SetActive(false);
        if (pauseButton != null)
        {
            pauseButton.gameObject.SetActive(false);
            restartButton.gameObject.SetActive(false);
            stopButton.gameObject.SetActive(false);
        }
        confirmLanChange.SetActive(true);

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
        
        confirmLanChange.SetActive(false);
        playButton.gameObject.SetActive(true);
        playButton.interactable = true;

    }

    public void DeleteChange()
    {
        confirmLanChange.SetActive(false);
        playButton.gameObject.SetActive(true);
        playButton.interactable = true;
        if (LanguageSetting.Language == "italian")
        {
            englishButton.gameObject.SetActive(true);
        }
        else
        {
            italianButton.gameObject.SetActive(true);
        }
    }


    
}

