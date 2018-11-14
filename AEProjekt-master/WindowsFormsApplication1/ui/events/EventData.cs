using System;
using Seriendatenbank.ui.userControls;

namespace WindowsFormsApplication1.ui.events
{
	public class EventData
	{
		public EventData(Template dst, Object data, bool dispose)
		{
			Destination = dst;
			Data = data;
			ShouldDispose = dispose;
		}
		
		public EventData(Template dst, Object data): this(dst, data, true)
		{}
		
		public EventData(Template dst): this(dst, null, true)
		{}
		
		public Template Destination
		{get; private set;}
		
		public Object Data
		{get; private set;}
		
		public bool ShouldDispose
		{get; private set;}
	}
}
