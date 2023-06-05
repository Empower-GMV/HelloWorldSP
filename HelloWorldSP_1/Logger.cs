namespace HelloWorldSP_1
{
    using System;
    using Skyline.DataMiner.Automation;

    public class Logger
	{
		#region Fields
		private IEngine _engine;
		#endregion

		#region Constructors
		public Logger(IEngine engine)
		{
			_engine = engine;
		}
		#endregion

		#region Public properties
		public Engine Engine => (Engine)_engine ?? throw new Exception("Engine object is null");
		#endregion

		#region Public methods
		public void Log(string message)
		{
			Engine.GenerateInformation(message);
		}
		#endregion
	}

}