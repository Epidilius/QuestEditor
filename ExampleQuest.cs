class RescueThePrincess : Quest
{	
	public RescueThePrincess()
	{		
		QuestID = 1;
		QuestName = "Rescue The Princess";
		QuestDescription = "We need a hero";
		CurrentStep = CreateFirstStep();
		Version = "4.9.4";
		Steps.Add(CurrentStep);
		
		CreateSteps();
		CreateDetails();
	}
	
	Step CreateFirstStep()
	{		
		Step step = new Step();
		step.ID = 0;
		step.QuestID = QuestID;
		step.StepName = "Quest Locked";
		
		return step;
	}
	
	void CreateSteps()
	{
		Steps.Add(CreateStep(1, QuestID, "Reach the top of the castle", "kjfhdg...", "", false, false, gold, 3000));
		Steps.Add(CreateStep(2, QuestID, "Protect Doug", "Follow me to the castle", "", false, false, Sword, 1));
		Steps.Add(CreateStep(3, QuestID, "Talk to Doug", "Thats the castle where the princess at", "", false, false, null, 0));
		//...
	}
	void CreateDetails()
	{
		Steps.Details.Add(CreateDetail(1002, 1, Player, 5, -1, -1, Doug));
		Steps.Details.Add(CreateDetail(1003, 2, Doug, 1, -1, 100, Castle));
		Steps.Details.Add(CreateDetail(1004, 2, Player, 3, -1, -1, Doug));
		//...
	}
	
	Step CreateStep(int id, int questID, string name, string dialogue, string exDialogue, bool useGeneric, bool useTyped, GameObject reward, int rewardAmount)
	{
		Step step = new Step();
		step.ID = id;
		step.QuestID = questID;
		step.StepName = name;
		step.Dialogue = dialogue;
		step.ExceptionDialogue = exDialogue;
		step.UseGeneric = useGeneric;
		step.UseTyped = useTyped;
		step.Reward = reward;
		step.RewardAmount = rewardAmount;
		return step;
	}	
	//TODO: Move to Step?
	Detail CreateDetail(int id, int stepID, GameObject activeEntity, int action, int amount, float, timerLength, /*DateTime dateLimit,*/ GameObject passiveEntity)
	{
		Detail detail = new Detail();
		detail.ID = id;
		detail.StepID = stepID;
		detail.ActiveEntity = activeEntity;
		detail.Action = action;
		detail.Amount = amount;
		detail.TimerLength = timerLength;
		detail.PassiveEntity = passiveEntity;
		detail.SetupDetail();
		return detail;
	}
		
	void ProgressStep()
	{
		//TODO: Display dialogue 
		GiveReward();
		NextStep();
	}
	void GiveReward()
	{
		if(CurrentStep.Reward == null)
			return;
		
		Player.AddItem(CurrentStep.Reward, CurrentStep.RewardAmount);
	}
	
	void NextStep()
	{
		for(int i = 0; i < Steps.Count; i++)
		{
			if(Steps[i] == CurrentStep)
			{
				CurrentStep = Steps[i + 1];
				if(CurrentStep == Steps.Last())
				{
					CompleteQuest();
				}
				break;
			}
		}
	}
	
	void CompleteQuest()
	{
		
	}
}