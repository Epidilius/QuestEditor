public Detail
{
	enum DetailState {
		Locked = 0,
		InProgress,
		Completed,
		Failed
	}
	public int ID = null;
	public int StepID = null;
	public GameObject ActiveEntity = null;
	public GameObject PassiveEntity = null;
	public int Action = null;
	public int Amount = null;
	public float TimerLength = null;	
	public DetailState State = Locked;
	
	Timer DetailTimer;
	int AmountCompleted;
	//public DateTime DateLimit;
	
	public Detail()
	{
		
	}
	
	public SetupDetail()
	{
		AmountCompleted = 0;
		PassiveEntity.AddObserver(Action, DetailProgressed);
		DetailState = Locked;
		
		if(TimerLength != -1)
			CreateTimer();
	}
	
	void CreateTimer()
	{
		DetailTimer = new Timer(TimerLength);
		DetailTimer.AddCompletedCallback(TimerComplete);
		DetailTimer.Start();
	}
	
	//Callback Functions
	public void DetailProgressed()
	{		
		if(Amount != -1)
			AmountCompleted++;
		
		if(AmountCompleted == Amount || Amount == -1)
		{
			Script parentScript = this.transform.parent.GetComponent<Script>();
			DetailState = Completed;
			DetailTimer.Stop();
			parentScript.DetailComplete(ID, StepID);
		}
	}
	
	public void TimerComplete()
	{
		DetailState = Failed;
		
		Script parentScript = this.transform.parent.GetComponent<Script>();
		parentScript.DetailFailed(ID, StepID);
	}
}