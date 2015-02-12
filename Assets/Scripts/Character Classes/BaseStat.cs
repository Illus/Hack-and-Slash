public class BaseStat 
{
	private int _baseValue;			//the base value of this stat
	private int _buffValue;			//the amount of the buff to this stat
	private int _expToLevel;		//the total of of exp needed to raise this skill
	private float _levelModifier;   //the modifier applied to the exp needed to raise the skill

	public BaseStat ()
	{
		_baseValue = 0;
		_buffValue = 0;
		_expToLevel = 100;
		_levelModifier = 1.1f;
	}
}
