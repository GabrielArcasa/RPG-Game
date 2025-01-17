using BlackCat.Quests;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestItemUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI title;
    [SerializeField] TextMeshProUGUI progress;
    private QuestStatus status = null;
    public void Setup(QuestStatus status)
    {
        this.status = status;


        title.text = status.GetQuest().GetTitle();
        progress.text = status.GetCompletedCount() + "/" + status.GetQuest().GetObjectiveCount();
        
    }

    public QuestStatus GetQuestStatus()
    {
        return status;
    }
}
