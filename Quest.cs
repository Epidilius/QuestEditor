public Quest
{
	protected List<Step> Steps;
	public GameObject Player;
	public int QuestID = null;
	public string QuestName = null;
	public string QuestDescription = null;
	public Step CurrentStep = null;
	public string Version = null;
	
	public Quest()
	{
		Steps = new List<Step>();
	}
	
	public void FailQuest()
	{
		//TODO: Display failure for all to see
	}
}