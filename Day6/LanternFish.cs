using System;

namespace Day6
{
	public class LanternFish
	{
		public int Timer { get; private set; }

		public event EventHandler TimerReset;

		public bool IsNew { get; set; }

		public LanternFish()
		{
			Timer = 8;
			IsNew = true;
		}

		public LanternFish(int timer)
		{
			Timer = timer;
		}

		public void PassDay()
		{
			if (IsNew)
			{
				IsNew = false;
				return;
			}

			if (Timer == 0)
			{
				Timer = 6;

				OnTimerReset(EventArgs.Empty);

				return;
			}

			Timer--;			
		}

		protected virtual void OnTimerReset(EventArgs e)
		{
			EventHandler handler = TimerReset;
			handler?.Invoke(this, e);		
		}
	}
}
