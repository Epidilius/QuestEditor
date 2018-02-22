public Step
{
	public int ID = null;
	public int QuestID = null;
	public string StepName = null;
	public string Dialogue = null;
	public string ExceptionDialogue = null;
	public bool UseGeneric = null;
	public bool UseTyped = null;
	public GameObject Reward = null;
	public int RewardAmount = null;
	public List<Detail> Details;
	public int AmountOfAttempts = -1;
	int AttempsCompleted = 0;
	
	public Step()
	{
		Details = new List<Detail>();
	}
	
	public void DetailComplete(int detailID, int stepID)
	{
		if(StepID != ID)
		{
			//TODO: Should I do something?
		}
		int completedDetails = 0;
		int detailsPerStep = 0;
				
		for(int i = 0; i < CurrentStep.Details.Count; i++)
		{
			detailsPerStep++;			
			if(Detail[i].Completed)
			{
				completedDetails++;
			}
		}
		
		if(completedDetails == detailsPerStep)
		{
			Script parentScript = this.transform.parent.GetComponent<Script>();
			parentScript.ProgressStep();
		}
	}
	
	public void DetailFailed(int detailID, int stepID)
	{
		if(AmountOfAttempts == -1)
		{
			ResetStep();
		}
		else
		{
			AttempsCompleted++;
			if(AmountOfAttempts == AttempsCompleted)
			{				
				Script parentScript = this.transform.parent.GetComponent<Script>();
				parentScript.FailQuest();
			}
			else
			{
				ResetStep();
			}
		}
	}
	
	void ResetStep()
	{
		//TODO: Fetch data from database, remake Details? No, because I have to also reset the NPCs and such. I'll need an origin and shit for EVERY item and detail
	}
}